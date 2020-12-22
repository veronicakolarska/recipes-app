using Microsoft.Extensions.Logging;
using Recipes.Data.Models;
using Recipes.Services.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    public partial class Authentication : Form
    {
        private IUserService userService;
        private ICategoryService categoryService;

        public Authentication(IUserService userService, ICategoryService categoryService)
        {
            this.userService = userService;
            this.categoryService = categoryService;
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

            this.Hide();
            var mainForm = new Main(this.categoryService);
            mainForm.Show();
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

            this.Hide();
            var mainForm = new Main(this.categoryService);
            mainForm.Show();

        }

        private void SetCurrentPrincipal(User currentUser, string[] roles)
        {
            // TODO: Role getting needs to be dynamic.
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(currentUser.Email), roles);
        }
    }
}
