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
    // UserControl comes from EF
    // RecipesAdmin is a control with data - table
    public partial class RecipesAdmin : UserControl
    {
        private int userId;
        private IEnumerable<Category> categories;
        private IEnumerable<Recipe> recipes;

        // view model
        // displaying data in user-friendly way
        public RecipesAdmin(IList<Recipe> recipes, int userId, IEnumerable<Category> categories)
        {
            this.InitializeComponent();
            this.userId = userId;
            this.categories = categories;
            this.recipes = recipes;

            this.LoadAdminRecipesDataGrid(recipes);
        }

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

            // Adding edit button to each grid row
            var editButton = new DataGridViewButtonColumn();
            this.recipeAdminDataGrid.Columns.Add(editButton);
            editButton.HeaderText = "Edit?";
            editButton.Text = "Edit";
            editButton.Name = "Edit";
            editButton.UseColumnTextForButtonValue = true;

            // Adding Delete button to each grid row
            var deleteButton = new DataGridViewButtonColumn();
            this.recipeAdminDataGrid.Columns.Add(deleteButton);
            deleteButton.HeaderText = "Delete?";
            deleteButton.Text = "Delete";
            deleteButton.Name = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            this.recipeAdminDataGrid.CellContentClick += this.RecipeAdminDataGrid_CellContentClick;
        }

        private void RecipeAdminDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                //They clicked the header column, do nothing
                return;
            }

            // Check if it's a grid action button
            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                var columnName = grid.Columns[e.ColumnIndex].Name;
                // Get the view model for the row, which had it's action button clicked
                var recipeViewModel = (RecipeViewModel)grid.Rows[e.RowIndex].DataBoundItem;

                if (columnName == "Edit")
                {
                    var recipeToEdit = this.recipes.FirstOrDefault(x => x.Id == recipeViewModel.Id);
                    var recipeAddForm = new AddRecipeForm(this.categories, this.userId, recipeToEdit);
                    recipeAddForm.Show();
                    recipeAddForm.RecipeAdded += this.RecipeAddForm_RecipeAdded;
                }

                if (columnName == "Delete")
                {
                    this.OnRecipeDeleted(new DeleteRecipeEventArgs(recipeViewModel.Id));
                }
            }
        }


        // The RecipeAdded event is call both when we Add a new Recipe and we Edit a new category. 
        // In this case we want to transform the event to an Edit event.
        private void RecipeAddForm_RecipeAdded(object sender, CreateRecipeEventArgs e)
        {
            this.OnRecipeEdited(new EditRecipeEventArgs(e.Recipe));
        }


        private void addRecipeButton_Click(object sender, EventArgs e)
        {
            var addRecipeForm = new AddRecipeForm(this.categories, this.userId);
            addRecipeForm.RecipeAdded += this.AddRecipeFormHandler_RecipeAdded;
            addRecipeForm.Show();
        }

        // event handler - for addRecipeForm_RecipeAdded
        // for event bubbling
        private void AddRecipeFormHandler_RecipeAdded(object sender, CreateRecipeEventArgs e)
        {
            this.OnRecipeAdded(e);
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
    }
}
