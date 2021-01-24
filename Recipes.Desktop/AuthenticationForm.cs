using Recipes.Common.Constants;
using Recipes.Data.Models;
using Recipes.Services.Data.Contracts;
using System;
using System.Security.Principal;
using System.Text.RegularExpressions;
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

        private void emailInput_TextChanged(object sender, EventArgs e)
        {
            Regex emailValidation = new Regex(GlobalConstants.EmailValidation);
            if (this.emailInput.Text.Length < GlobalConstants.UserNameMinLength
                || this.emailInput.Text.Length > GlobalConstants.UserNameMaxLength)
            {
                this.emailErrorProvider.SetError(this.emailInput, "Invalid user email length!");
            }

            Match match = emailValidation.Match(this.emailInput.Text);
            if (!match.Success)
            {
                this.emailErrorProvider.SetError(this.emailInput, "Invalid email!");
            }
            else
            {
                this.emailErrorProvider.Clear();
            }
        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {
            Regex passwordValidation = new Regex(GlobalConstants.PasswordCheck);
            Match match = passwordValidation.Match(this.passwordInput.Text);
            if (!match.Success)
            {
                this.passwordErrorProvider.SetError(this.passwordInput, "Invalid password! Try again!");
            }
            else
            {
                this.passwordErrorProvider.Clear();
            }
        }

        private void registerEmailInput_TextChanged(object sender, EventArgs e)
        {
            Regex emailValidation = new Regex(GlobalConstants.EmailValidation);
            if (this.registerEmailInput.Text.Length < GlobalConstants.UserNameMinLength
                || this.registerEmailInput.Text.Length > GlobalConstants.UserNameMaxLength)
            {
                this.registerEmailErrorProvider.SetError(this.emailInput, "Invalid user email length!");
            }

            Match match = emailValidation.Match(this.registerEmailInput.Text);
            if (!match.Success)
            {
                this.registerEmailErrorProvider.SetError(this.registerEmailInput, "Invalid email!");
            }
            else
            {
                this.registerEmailErrorProvider.Clear();
            }
        }

        private void registerPasswordInput_TextChanged(object sender, EventArgs e)
        {
            Regex passwordValidation = new Regex(GlobalConstants.PasswordCheck);
            Match match = passwordValidation.Match(this.registerPasswordInput.Text);
            if (!match.Success)
            {
                this.registerPasswordErrorProvider.SetError(this.registerPasswordInput, "Invalid password! Try again!");
            }
            else
            {
                this.registerPasswordErrorProvider.Clear();
            }
        }

        private void registerConfirmPasswordInput_TextChanged(object sender, EventArgs e)
        {
            var password = this.registerPasswordInput.Text;
            var confirmPassword = this.registerConfirmPasswordInput.Text;
            if (password != confirmPassword)
            {
                this.confirmPasswordErrorProvider.SetError(this.registerConfirmPasswordInput, "Passwords do not match!");
            }
            else
            {
                this.confirmPasswordErrorProvider.Clear();
            }
        }
    }
}
