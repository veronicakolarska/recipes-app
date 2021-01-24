using Recipes.Data.Models;
using Recipes.Desktop.Events;
using Recipes.Desktop.UserControls;
using Recipes.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    public partial class MainForm : Form
    {
        private ICategoryService categoryService;
        private IRecipeService recipeService;
        private IUserService userService;
        private User currentUser;

        public MainForm(
            ICategoryService categoryService,
            IRecipeService recipeService,
            IUserService userService)
        {

            this.categoryService = categoryService;
            this.recipeService = recipeService;
            this.userService = userService;

            var currentUser = this.userService.GetByEmailWithFavouriteRecipes(Thread.CurrentPrincipal.Identity.Name);
            this.currentUser = currentUser;

            this.InitializeComponent();

            // Clean up all open forms after the  Main form is closed.
            this.FormClosed += this.Main_FormClosed;

            // if not admin - hide the panels
            if (!Thread.CurrentPrincipal.IsInRole(Role.Administrator.ToString()))
            {
                this.HideAdminTabs();
            }

            this.LoadDataToComponents();
        }

        private async void UserProfileControl_UserEdited(object sender, EditUserEventArgs e)
        {
            await this.userService.Update(e.User);
            // update the property after the user is edited
            this.currentUser = e.User;
            this.LoadUserProfilePanel();
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

                this.LoadAdminRecipesPanel();
                this.LoadAdminCategoriesPanel();
                this.LoadAdminUsersPanel();
                this.LoadUserProfilePanel();
                // Loads data and attaches events to the recipe filter dropdown/combobox
                this.LoadRecipeTypeFilterComboBox();
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

        private void LoadRecipeTypeFilterComboBox()
        {
            this.recipeTypeComboBox.SelectedIndex = 0;
            this.recipeTypeComboBox.SelectedIndexChanged += this.RecipeTypeComboBox_SelectedIndexChanged;
        }

        private void RecipeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentSelectedFilterType = this.recipeTypeComboBox.SelectedItem.ToString();
            switch (currentSelectedFilterType)
            {
                case "All Recipes":
                    this.LoadAllRecipesPanel();
                    break;
                case "My Recipes":
                    {
                        var myRecipes = this.recipeService
                            .GetAll()
                            .Where((recipe) => recipe.CreatorId == this.currentUser.Id)
                            .ToList();
                        this.LoadAllRecipesPanel(myRecipes);
                    }
                    break;
                case "Favourite Recipes":
                    {
                        var allFavouriteRecipes = this.currentUser.FavouriteRecipes.Select(x => x.Recipe);
                        this.LoadAllRecipesPanel(allFavouriteRecipes);
                    }
                    break;
                default:
                    break;
            }
        }

        // load side panel Profile
        private void LoadUserProfilePanel()
        {
            var userProfileControl = new Profile(this.currentUser);
            this.userProfilePanel.Controls.Clear();
            this.userProfilePanel.Controls.Add(userProfileControl);
            userProfileControl.UserEdited += this.UserProfileControl_UserEdited;
        }

        private void LoadAllRecipesPanel(IEnumerable<Recipe> recipes = null)
        {
            IEnumerable<Recipe> allRecipes = recipes;
            if (recipes == null)
            {
                allRecipes = this.recipeService
                    .GetAll()
                    .OrderByDescending((x) => x.CreatedOn)
                    .ToList();
            }

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
            var userId = this.currentUser.Id;
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
            // refresh all recipies tab after a new recipe is added
            this.LoadAllRecipesPanel();
        }


        private async void RecipeAdmin_RecipeEdited(object sender, EditRecipeEventArgs e)
        {
            await this.recipeService.Update(e.Recipe);
            this.LoadAdminRecipesPanel();
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
            var userId = this.currentUser.Id;
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

        private async void UserAdmin_UserEdited(object sender, EditUserEventArgs e)
        {
            await this.userService.Update(e.User);
            this.LoadAdminUsersPanel();
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

            var userId = this.currentUser.Id;
            var addRecipeForm = new AddRecipeForm(allCategories, userId);
            addRecipeForm.RecipeAdded += this.AddRecipeForm_RecipeAdded;
            addRecipeForm.Show();
        }

        private async void AddRecipeForm_RecipeAdded(object sender, CreateRecipeEventArgs e)
        {
            await this.recipeService.Create(e.Recipe);
            this.LoadAllRecipesPanel();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure?", "Loging out...", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // TODO: Figure out how to show the Authentication form
                //Thread.CurrentPrincipal = null;
                //var authenticationForm = Application.OpenForms
                //    .OfType<AuthenticationForm>()
                //    .FirstOrDefault();
                //this.Close();
                //authenticationForm.Show();
                Application.Exit();
            }
        }
    }
}
