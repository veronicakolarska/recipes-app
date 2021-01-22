using Recipes.Data.Models;
using Recipes.Services.Data.Contracts;
using System;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    public partial class AuthenticationForm : Form
    {
        private IUserService userService;
        private ICategoryService categoryService;
        private IRecipeService recipeService;
        private IFavouriteRecipeService favouriteRecipeService;
        private IIngredientService ingredientService;

        public AuthenticationForm(
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

        // event handlers
        private void loginButton_Click(object sender, EventArgs e)
        {
            var email = this.emailInput.Text;
            var password = this.passwordInput.Text;

            var loggedInUser = this.userService.Login(email, password);
            if (loggedInUser == null)
            {
                MessageBox.Show("Invalid user!");
                return;
            }

            this.SetCurrentPrincipal(loggedInUser);

            this.ShowMainForm();
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            var email = this.registerEmailInput.Text;
            var password = this.registerPasswordInput.Text;
            var confirmPassword = this.registerConfirmPasswordInput.Text;

            var registeredUser = await this.userService.Register(email, password);

            if (registeredUser == null)
            {
                MessageBox.Show("Can not register a new user!");
                return;
            }
            this.SetCurrentPrincipal(registeredUser);

            this.ShowMainForm();
        }


        private void SetCurrentPrincipal(User currentUser)
        {
            // from .NET - the classes for setting the user between forms
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(currentUser.Email), new string[] { currentUser.Role.ToString() });
        }

        private void ShowMainForm()
        {
            this.Hide();
            var mainForm = new MainForm(this.categoryService, this.recipeService, this.userService);
            mainForm.Show();
        }
    }
}
