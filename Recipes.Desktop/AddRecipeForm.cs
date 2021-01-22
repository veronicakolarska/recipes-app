using Recipes.Data.Models;
using Recipes.Desktop.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    public partial class AddRecipeForm : Form
    {
        private Recipe model;
        private int userId;

        // If we pass a recipe, It will be populated in the form for editing
        public AddRecipeForm(
                IEnumerable<Category> categories,
                int userId,
                Recipe recipe = null
            )
        {
            this.userId = userId;
            this.model = recipe;

            this.InitializeComponent();

            var allCategories = categories
                .Select(category => new { category.Id, category.Name })
                .ToList();

            this.categoryDropDown.ValueMember = "Id";
            this.categoryDropDown.DisplayMember = "Name";
            this.categoryDropDown.DataSource = allCategories;

            if (recipe != null)
            {
                this.nameInput.Text = recipe.Name;
                this.imageUrlInput.Text = recipe.TitleImageUrl;
                this.descriptionInput.Text = recipe.Description;
            }
        }

        protected void OnRecipeAdded(CreateRecipeEventArgs e)
        {

            if (this.RecipeAdded != null)
            {
                this.RecipeAdded(this, e);
            }
        }

        public event EventHandler<CreateRecipeEventArgs> RecipeAdded;

        private void createRecipeButton_Click(object sender, EventArgs e)
        {
            var name = this.nameInput.Text;
            var imageUrl = this.imageUrlInput.Text;
            var description = this.descriptionInput.Text;
            var categoryId = (int)this.categoryDropDown.SelectedValue;

            if (this.model != null)
            {
                this.model.Name = name;
                this.model.TitleImageUrl = imageUrl;
                this.model.Description = description;
                this.model.CategoryId = categoryId;
                this.OnRecipeAdded(new CreateRecipeEventArgs(this.model));
                this.Close();
            }
            else
            {
                var recipeToAdd = new Recipe()
                {
                    Name = name,
                    TitleImageUrl = imageUrl,
                    Description = description,
                    CategoryId = categoryId,
                    CreatorId = userId,
                };

                this.OnRecipeAdded(new CreateRecipeEventArgs(recipeToAdd));
                this.Close();
            }

        }
    }
}
