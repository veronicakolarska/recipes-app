using Microsoft.Extensions.Logging;
using Recipes.Services.Data;
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
    public partial class Main : Form
    {
        private IUserService userService;

        public Main(IUserService userService)
        {
            this.userService = userService;
            this.InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var email = this.emailInput.Text;
            var password = this.passwordInput.Text;

            var hasLoggedIn = this.userService.Login(email, password);

            // If login was ok:
            // Set user for application.
            // Redirect to main page.
            // If not show an error.
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var email = this.registerEmailInput.Text;
            var password = this.registerPasswordInput.Text;
            var confirmPasswrod = this.registerConfirmPasswordInput.Text;

            var hasLoggedIn = this.userService.Register(email, password);
            // If register was ok:
            // Set user for application.
            // Redirect to main page.
            // If not show an error.
        }
    }
}
