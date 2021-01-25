using Recipes.Data.Models;
using Recipes.Desktop.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    public partial class RecipeTile : UserControl
    {
        public Recipe Recipe { get; private set; }

        private int CurrentUserId { get; set; }

        private IEnumerable<Category> Categories { get; set; }

        public RecipeTile(
            IEnumerable<Category> categories,
            Recipe recipe,
            int currentUserId)
        {
            this.InitializeComponent();
            this.Recipe = recipe;
            this.CurrentUserId = currentUserId;
            this.Categories = categories;
            this.recipeTitleLabel.Text = recipe.Name;
            this.recipePictureBox.Load(recipe.TitleImageUrl);
            var isFavouriteRecipeForCurrentUser = recipe.FavouriteRecipes.Any(x => x.UserId == currentUserId);
            this.favouriteCheckBox.Checked = isFavouriteRecipeForCurrentUser;
            var isNotMyRecipe = recipe.CreatorId != currentUserId;
            if (isNotMyRecipe)
            {
                this.editRecipeButton.Hide();
            }

            // triggers the event for file if we click on the picture
            this.recipePictureBox.Click += this.ControlClick;
            // triggers the event for file if we click on the label
            this.recipeTitleLabel.Click += this.ControlClick;
        }


        // triggers new event for tile
        private void ControlClick(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void favouriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.favouriteCheckBox.Checked)
            {
                this.OnMadeFavouriteRecipe(new MadeFavouriteRecipeEventArgs(this.Recipe.Id));
            }
            else
            {
                this.OnUnMadeFavouriteRecipe(new MadeFavouriteRecipeEventArgs(this.Recipe.Id));
            }

        }

        protected void OnMadeFavouriteRecipe(MadeFavouriteRecipeEventArgs e)
        {
            if (this.MadeFavouriteRecipe != null)
            {
                this.MadeFavouriteRecipe(this, e);
            }
        }

        public event EventHandler<MadeFavouriteRecipeEventArgs> MadeFavouriteRecipe;

        protected void OnUnMadeFavouriteRecipe(MadeFavouriteRecipeEventArgs e)
        {
            if (this.UnMadeFavouriteRecipe != null)
            {
                this.UnMadeFavouriteRecipe(this, e);
            }
        }

        public event EventHandler<MadeFavouriteRecipeEventArgs> UnMadeFavouriteRecipe;

        protected void OnRecipeEdited(EditRecipeEventArgs e)
        {

            if (this.RecipeEdited != null)
            {
                this.RecipeEdited(this, e);
            }
        }

        public event EventHandler<EditRecipeEventArgs> RecipeEdited;

        private void editRecipeButton_Click(object sender, EventArgs e)
        {
            var editRecipeForm = new AddRecipeForm(this.Categories, this.CurrentUserId, this.Recipe);
            editRecipeForm.RecipeAdded += this.EditRecipeForm_RecipeAdded;
            editRecipeForm.Show();
        }

        private void EditRecipeForm_RecipeAdded(object sender, CreateRecipeEventArgs e)
        {
            this.OnRecipeEdited(new EditRecipeEventArgs(e.Recipe));
        }
    }
}
