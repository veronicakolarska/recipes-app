using Recipes.Data.Models;
using Recipes.Desktop.Events;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    public partial class RecipeTile : UserControl
    {
        public int RecipeId { get; private set; }

        public RecipeTile(Recipe recipe, int currentUserId)
        {
            this.InitializeComponent();
            this.RecipeId = recipe.Id;
            this.recipeTitleLabel.Text = recipe.Name;
            this.recipePictureBox.Load(recipe.TitleImageUrl);
            var isFavouriteRecipeForCurrentUser = recipe.FavouriteRecipes.Any(x => x.UserId == currentUserId);
            this.favouriteCheckBox.Checked = isFavouriteRecipeForCurrentUser;

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
                this.OnMadeFavouriteRecipe(new MadeFavouriteRecipeEventArgs(this.RecipeId));
            }
            else
            {
                this.OnUnMadeFavouriteRecipe(new MadeFavouriteRecipeEventArgs(this.RecipeId));
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
    }
}
