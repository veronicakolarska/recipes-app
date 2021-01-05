using Recipes.Data.Models;
using Recipes.Desktop.Events;
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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            this.InitializeComponent();
        }

        protected void OnUserAdded(CreateUserEventArgs e)
        {
            if (this.UserAdded != null)
            {
                this.UserAdded(this, e);
            }
        }

        public event EventHandler<CreateUserEventArgs> UserAdded;

        private void userAddedButton_Click(object sender, EventArgs e)
        {
            var userEmail = this.userEmailInput.Text;
            var userPassword = this.userPasswordInput.Text;
            var userImageUrl = this.userImageURLInput.Text;
            var userDescription = this.userDescriptionInput.Text;

            var user = new User()
            {
                Email = userEmail,
                Password = userPassword,
                ImageUrl = userImageUrl,
                Description = userDescription
            };

            this.OnUserAdded(new CreateUserEventArgs(user));
            this.Close();
        }
    }
}
