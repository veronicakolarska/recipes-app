using Recipes.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    public partial class RecipeDetails : Form
    {
        public RecipeDetails(Recipe recipe)
        {
            this.InitializeComponent();

            this.recipeTitleLabel.Text = recipe.Name;
            this.recipeImagePictureBox.Load(recipe.TitleImageUrl);
            this.recipeDescriptionTextBox.Text = recipe.Description;

            var ingredientsList = recipe.Ingredients
                .Select((ingredient) => $"{ingredient.Name} - {ingredient.Quantity} ({ingredient.Unit})");

            this.recipeIngredientsListBox.DataSource = ingredientsList;
        }
    }
}
