using Recipes.Data.Models;
using Recipes.Desktop.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    public partial class AddRecipe : Form
    {
        private int userId;

        public AddRecipe(
                IEnumerable<Category> categories,
                int userId
            )
        {
            this.userId = userId;

            this.InitializeComponent();

            var allCategories = categories
                    .Select(category => new { category.Id, category.Name })
                    .ToList();

            this.categoryDropDown.ValueMember = "Id";
            this.categoryDropDown.DisplayMember = "Name";
            this.categoryDropDown.DataSource = allCategories;
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

            var recipeToAdd = new Recipe
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
