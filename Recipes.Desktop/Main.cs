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
        public Main(ICategoryService categoryService)
        {
            var allData = categoryService.GetAll().ToList();
            this.InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var email = this.emailInput.Text;
            var password = this.passwordInput.Text;
            MessageBox.Show($"Login button, clicked! {email} {password}");
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var email = this.registerEmailInput.Text;
            var password = this.registerPasswordInput.Text;
            var confirmPasswrod = this.registerConfirmPasswordInput.Text;
            MessageBox.Show($"Login button, clicked! {email} {password} {confirmPasswrod}");
        }
    }
}
