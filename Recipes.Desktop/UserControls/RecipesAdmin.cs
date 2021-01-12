using Recipes.Data.Models;
using Recipes.Desktop.Events;
using Recipes.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Recipes.Desktop.UserControls
{
    public partial class RecipesAdmin : UserControl
    {
        private int userId;

        private IEnumerable<Category> categories;

        // view model
        // displaying data in user-friendly way
        public RecipesAdmin(IList<Recipe> recipes, int userId, IEnumerable<Category> categories)
        {
            this.InitializeComponent();
            this.userId = userId;
            this.categories = categories;

            this.LoadAdminRecipesDataGrid(recipes);
        }

        protected void OnRecipeAdded(CreateRecipeEventArgs e)
        {

            if (this.RecipeAdded != null)
            {
                this.RecipeAdded(this, e);
            }
        }

        public event EventHandler<CreateRecipeEventArgs> RecipeAdded;

        protected void OnRecipeEdited(EditRecipeEventArgs e)
        {

            if (this.RecipeEdited != null)
            {
                this.RecipeEdited(this, e);
            }
        }

        public event EventHandler<EditRecipeEventArgs> RecipeEdited;

        protected void OnRecipeDeleted(DeleteRecipeEventArgs e)
        {

            if (this.RecipeDeleted != null)
            {
                this.RecipeDeleted(this, e);
            }
        }

        public event EventHandler<DeleteRecipeEventArgs> RecipeDeleted;

        private void LoadAdminRecipesDataGrid(IList<Recipe> recipes)
        {
            // map all recipes to the viewModels 
            var allRecipes = recipes.Select(x => new RecipeViewModel
            {
                Id = x.Id,
                Category = x.Category.Name,
                Creator = x.Creator.Email,
                Name = x.Name,
                Description = x.Description,
                TitleImageUrl = x.TitleImageUrl,
                CreatedOn = x.CreatedOn,
                ModifiedOn = x.ModifiedOn
            }).ToList();
            // load data to dataGrid (WinForms control - table)
            this.recipeAdminDataGrid.DataSource = new BindingSource(new BindingList<RecipeViewModel>(allRecipes), null);

            // TODO: add more columns 
            var button = new DataGridViewButtonColumn();
            this.recipeAdminDataGrid.Columns.Add(button);
            button.HeaderText = "Actions";
            button.Text = "Click Here";
            button.Name = "Delete Button";
            button.UseColumnTextForButtonValue = true;
        }

        private void addRecipeButton_Click(object sender, System.EventArgs e)
        {
            var addRecipeForm = new AddRecipeForm(this.categories, this.userId);
            addRecipeForm.RecipeAdded += this.AddRecipeFormHandler_RecipeAdded;
            addRecipeForm.Show();
        }

        private void AddRecipeFormHandler_RecipeAdded(object sender, Events.CreateRecipeEventArgs e)
        {
            this.OnRecipeAdded(e);
        }

    }
}
