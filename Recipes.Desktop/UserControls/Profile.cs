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

namespace Recipes.Desktop.UserControls
{
    public partial class Profile : UserControl
    {
        private User user;

        public Profile(User user)
        {
            this.InitializeComponent();
            this.user = user;
            this.emailTextbox.Text = user.Email;
            this.descriptionTextbox.Text = user.Description;
            if (!string.IsNullOrEmpty(user.ImageUrl))
            {
                this.profilePictureBox.Load(user.ImageUrl);
            }
        }

        protected void OnUserEdited(EditUserEventArgs e)
        {
            if (this.UserEdited != null)
            {
                this.UserEdited(this, e);
            }
        }
        public event EventHandler<EditUserEventArgs> UserEdited;


        private void editProfileButton_Click(object sender, EventArgs e)
        {
            var editUser = new AddUserForm(this.user);
            editUser.UserAdded += this.EditUser_UserAdded;
            editUser.Show();
        }

        private void EditUser_UserAdded(object sender, Events.CreateUserEventArgs e)
        {
            this.OnUserEdited(new EditUserEventArgs(e.User));
        }
    }
}
