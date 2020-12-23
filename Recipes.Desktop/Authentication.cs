using Recipes.Data.Models;
using Recipes.Services.Data.Contracts;
using System;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    public partial class Authentication : Form
    {
        private IUserService userService;
        private ICategoryService categoryService;
        private IRecipeService recipeService;
        private IFavouriteRecipeService favouriteRecipeService;
        private IIngredientService ingredientService;

        public Authentication(
            IUserService userService,
            ICategoryService categoryService,
            IRecipeService recipeService,
            IFavouriteRecipeService favouriteRecipeService,
            IIngredientService ingredientService
            )
        {
            this.userService = userService;
            this.categoryService = categoryService;
            this.recipeService = recipeService;
            this.favouriteRecipeService = favouriteRecipeService;
            this.ingredientService = ingredientService;
            this.InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var email = this.emailInput.Text;
            var password = this.passwordInput.Text;

            var loggedInUser = this.userService.Login(email, password);
            if (loggedInUser == null)
            {
                // TODO: Show error.
            }

            // TODO: Role getting needs to be dynamic.
            this.SetCurrentPrincipal(loggedInUser, new[] { "User" });

            this.ShowMainForm();
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            var email = this.registerEmailInput.Text;
            var password = this.registerPasswordInput.Text;
            var confirmPasswrod = this.registerConfirmPasswordInput.Text;

            var registeredUser = await this.userService.Register(email, password);

            if (registeredUser == null)
            {
                // TODO: Show error
            }

            // TODO: Role getting needs to be dynamic.
            this.SetCurrentPrincipal(registeredUser, new[] { "User" });

            this.ShowMainForm();
        }

        private void SetCurrentPrincipal(User currentUser, string[] roles)
        {
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(currentUser.Email), roles);
        }

        private void ShowMainForm()
        {
            this.Hide();
            var mainForm = new Main(this.categoryService, this.recipeService, this.userService);
            mainForm.Show();
        }
    }
}
