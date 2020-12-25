using Recipes.Data.Models;
using Recipes.Desktop.Extensions;
using Recipes.Services.Data;
using Recipes.Services.Data.Contracts;
using System;
using System.ComponentModel;
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

            // Clean up all open forms after the thie Main form is closed.
            this.FormClosed += this.Main_FormClosed;
            
            // TODO: Activate when login works
            //if (!Thread.CurrentPrincipal.IsAdmin())
            //{
            //    this.HideAdminTabs();
            //}

            this.LoadDataToComponents();
        }

        private void HideAdminTabs()
        {
            this.mainTabs.Controls.Remove(this.recipeAdminTabPage);
            this.mainTabs.Controls.Remove(this.categoryAdminTabPage);
            this.mainTabs.Controls.Remove(this.userAdminTabPage);
        }

        private void LoadDataToComponents()
        {
            try
            {
                this.LoadAllRecipesPanel();

                // TODO: Activate when user loggin is ready.
                // this.LoadFavouriteRecipesPanel();

                this.LoadAdminRecipesPanel();
            }
            // TODO: Refine exception handling
            catch (Exception exception)
            {
                MessageBox.Show($"Fatal error! Please reolad your application and try again! {exception}", "Fatal error!");
                Application.Exit();
            }
            finally
            {
            }
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

            this.recipesFlowPanel.Controls.Clear();
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

        private void LoadAdminRecipesPanel()
        {
            var allRecipes = this.recipeService.GetAll().ToList();
            this.recipeGridView.DataSource = new BindingSource(new BindingList<Recipe>(allRecipes), null);
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

        private void addRecipeButton_Click(object sender, EventArgs e)
        {
            var allCategories = this.categoryService.GetAll().ToList();

            // TODO: This should come from Thread.CurrentPrinciapl when ready!
            var userId = 1;

            var addRecipeForm = new AddRecipe(allCategories, userId);
            addRecipeForm.RecipeAdded += this.AddRecipeForm_RecipeAdded;
            addRecipeForm.Show();
        }

        private async void AddRecipeForm_RecipeAdded(object sender, Events.CreateRecipeEventArgs e)
        {
            await this.recipeService.Create(e.Recipe);
            this.LoadAllRecipesPanel();

        }
    }
}
