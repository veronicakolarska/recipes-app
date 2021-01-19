using Recipes.Data.Models;
using Recipes.Desktop.Events;
using Recipes.Desktop.UserControls;
using Recipes.Desktop.ViewModels;
using Recipes.Services.Data;
using Recipes.Services.Data.Contracts;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    public partial class MainForm : Form
    {
        private ICategoryService categoryService;
        private IRecipeService recipeService;
        private IUserService userService;

        public MainForm(
            ICategoryService categoryService,
            IRecipeService recipeService,
            IUserService userService)
        {

            this.categoryService = categoryService;
            this.recipeService = recipeService;
            this.userService = userService;

            this.InitializeComponent();

            // Clean up all open forms after the  Main form is closed.
            this.FormClosed += this.Main_FormClosed;

            // TODO: Activate when login works
            //if (!Thread.CurrentPrincipal.IsInRole(Role.Administrator))
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
                // loads all recipes to the tab
                this.LoadAllRecipesPanel();

                // TODO: Activate when user loggin is ready.
                // this.LoadFavouriteRecipesPanel();

                this.LoadAdminRecipesPanel();
                this.LoadAdminCategoriesPanel();
                this.LoadAdminUsersPanel();
            }
            // TODO: Refine exception handling
            catch (Exception exception)
            {
                MessageBox.Show($"Fatal error! Please reload your application and try again! {exception}", "Fatal error!");
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

            // removes any existing controls (if eny)
            this.recipesFlowPanel.Controls.Clear();
            // adds all the recipe tiles
            this.recipesFlowPanel.Controls.AddRange(recipeTiles);
        }


        private void LoadAdminRecipesPanel()
        {
            var allRecipes = this.recipeService
                .GetAllWithRelatedData()
                .ToList();

            // add new control (grid) to the recipesAdmin to the tab
            // TODO: get actual id
            var userId = 1;
            var categories = this.categoryService.GetAll();
            var recipeAdmin = new RecipesAdmin(allRecipes, userId, categories);
            this.recipeAdminTabPage.Controls.Clear();
            this.recipeAdminTabPage.Controls.Add(recipeAdmin);
            recipeAdmin.RecipeAdded += this.RecipeAdmin_RecipeAdded;
            recipeAdmin.RecipeEdited += this.RecipeAdmin_RecipeEdited;
            recipeAdmin.RecipeDeleted += this.RecipeAdmin_RecipeDeleted;
        }

        private async void RecipeAdmin_RecipeAdded(object sender, CreateRecipeEventArgs e)
        {
            await this.recipeService.Create(e.Recipe);
            this.LoadAdminRecipesPanel();
        }


        private void RecipeAdmin_RecipeEdited(object sender, EditRecipeEventArgs e)
        {
            MessageBox.Show("Recipe edited");
        }


        private async void RecipeAdmin_RecipeDeleted(object sender, DeleteRecipeEventArgs e)
        {
            await this.recipeService.Delete(e.Id);
            this.LoadAdminRecipesPanel();
        }


        private void LoadAdminCategoriesPanel()
        {
            var allCategories = this.categoryService.GetAllWithRelatedData().ToList();
            // TODO: get actual id when login is ready
            var userId = 1;
            var categoryAdmin = new CategoriesAdmin(allCategories, userId);
            this.categoryAdminTabPage.Controls.Clear();
            this.categoryAdminTabPage.Controls.Add(categoryAdmin);
            categoryAdmin.CategoryAdded += this.CategoryAdmin_CategoryAdded;
            categoryAdmin.CategoryEdited += this.CategoryAdmin_CategoryEdited;
            categoryAdmin.CategoryDeleted += this.CategoryAdmin_CategoryDeleted;
        }

        private async void CategoryAdmin_CategoryAdded(object sender, CreateCategoryEventArgs e)
        {
            await this.categoryService.Create(e.Category);
            this.LoadAdminCategoriesPanel();
        }

        private async void CategoryAdmin_CategoryEdited(object sender, EditCategoryEventArgs e)
        {
            await this.categoryService.Update(e.Category);
            this.LoadAdminCategoriesPanel();
        }

        private async void CategoryAdmin_CategoryDeleted(object sender, DeleteCategoryEventArgs e)
        {
            await this.categoryService.Delete(e.Id);
            this.LoadAdminCategoriesPanel();
        }

        private void LoadAdminUsersPanel()
        {
            var allUsers = this.userService.GetAll().ToList();
            var userAdmin = new UsersAdmin(allUsers);
            this.userAdminTabPage.Controls.Clear();
            this.userAdminTabPage.Controls.Add(userAdmin);
            userAdmin.UserAdded += this.UserAdmin_UserAdded;
            userAdmin.UserEdited += this.UserAdmin_UserEdited;
            userAdmin.UserDeleted += this.UserAdmin_UserDeleted;
        }
        private async void UserAdmin_UserAdded(object sender, CreateUserEventArgs e)
        {
            await this.userService.Create(e.User);
            this.LoadAdminUsersPanel();
        }

        private void UserAdmin_UserEdited(object sender, EditUserEventArgs e)
        {
            MessageBox.Show("User edited");
        }

        private async void UserAdmin_UserDeleted(object sender, DeleteUserEventArgs e)
        {
            await this.userService.Delete(e.Id);
            this.LoadAdminUsersPanel();
        }


        private void RecipeTile_Click(object sender, EventArgs e)
        {
            var tile = (RecipeTile)sender;

            var recipe = this.recipeService.GetByIdWithIngredients(tile.RecipeId);
            var recipeDetails = new RecipeDetailsForm(recipe);
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

            // TODO: This should come from Thread.CurrentPrincipal when ready!
            var userId = 1;

            var addRecipeForm = new AddRecipeForm(allCategories, userId);
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
