using Recipes.Services.Data;
using Recipes.Services.Data.Contracts;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    public partial class Main : Form
    {
        private ICategoryService categoryService;
        private IRecipeService recipeService;
        private IUserService userService;

        public Main(
            ICategoryService categoryService, 
            IRecipeService recipeService, 
            IUserService userService)
        {

            this.categoryService = categoryService;
            this.recipeService = recipeService;
            this.userService = userService;

            this.InitializeComponent();

            this.FormClosed += this.Main_FormClosed;

            this.LoadAllRecipesPanel();

            // TODO: Activate when user loggin is ready.
            // this.LoadFavouriteRecipesPanel();
        }

        private void LoadAllRecipesPanel()
        {
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

        private void LoadFavouriteRecipesPanel()
        {
            var currentUserEmail = Thread.CurrentPrincipal.Identity.Name;
            var currentUser = this.userService.GetByEmailWithFavouriteRecipes(currentUserEmail);
            var allFavoureRecipes = currentUser.FavouriteRecipes.Select(x => x.Recipe);

            var recipeTiles = allFavoureRecipes.Select((recipe) =>
            {
                var recipeTile = new RecipeTile(recipe);
                recipeTile.Click += this.RecipeTile_Click;
                return (Control)recipeTile;
            }).ToArray();

            this.favouriteRecipesFlowLayoutPanel.Controls.AddRange(recipeTiles);
        }

        private void RecipeTile_Click(object sender, EventArgs e)
        {
            var tile = (RecipeTile)sender;

            var recipe = this.recipeService.GetByIdWithIngredients(tile.RecipeId);
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
