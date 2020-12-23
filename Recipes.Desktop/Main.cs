using Recipes.Data.Models;
using Recipes.Services.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    public partial class Main : Form
    {
        private ICategoryService categoryService;
        private IRecipeService recipeService;

        public Main(ICategoryService categoryService, IRecipeService recipeService)
        {

            this.categoryService = categoryService;
            this.recipeService = recipeService;

            this.InitializeComponent();

            this.FormClosed += this.Main_FormClosed;

            var allRecipes = this.recipeService
                .GetAll()
                .OrderByDescending((x) => x.CreatedOn)
                .ToList();

            var recipeTiles = allRecipes.Select((recipe) =>
            {
                var recipeTile = new RecipeTile(recipe);
                recipeTile.Click += this.RecipeTile_Click;
                return (Control)recipeTile;
            }).ToArray();

            this.recipesFlowPanel.Controls.AddRange(recipeTiles);
        }

        private void RecipeTile_Click(object sender, EventArgs e)
        {
            var tile = (RecipeTile)sender;

            var recipe = this.recipeService.GetById(tile.RecipeId);
            var recipeDetails = new RecipeDetails(recipe);
            recipeDetails.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            var allOpenForms = Application.OpenForms.Cast<Form>();
            foreach (var form in allOpenForms)
            {
                form.Close();
            }
        }
    }
}
