using Recipes.Data.Models;
using Recipes.Desktop.Events;
using System;
using System.Windows.Forms;


namespace Recipes.Desktop
{
    public partial class AddUserForm : Form
    {
        private User model;
        public AddUserForm(User user = null)
        {
            this.model = user;

            this.InitializeComponent();

            if (user != null)
            {
                // TODO: this needs to be hashed
                // TODO: edit panel

                this.userDescriptionInput.Text = user.Description;
                this.userEmailInput.Text = user.Email;
                this.userImageURLInput.Text = user.ImageUrl;
            }
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
            var confirmPassword = this.confirmPasswordInput.Text;
            var userImageUrl = this.userImageURLInput.Text;
            var userDescription = this.userDescriptionInput.Text;

            if (userPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            // This updates the existing model if we are using the form for editing

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(userPassword);

            if (this.model != null)
            {
                this.model.Email = userEmail;
                if (!string.IsNullOrEmpty(passwordHash))
                {
                    this.model.Password = passwordHash;
                }
                this.model.ImageUrl = userImageUrl;
                this.model.Description = userDescription;
                this.OnUserAdded(new CreateUserEventArgs(this.model));
                this.Close();
            }
            else
            {

                var user = new User()
                {
                    Email = userEmail,
                    Password = passwordHash,
                    ImageUrl = userImageUrl,
                    Description = userDescription
                };

                this.OnUserAdded(new CreateUserEventArgs(user));
                this.Close();
            }
        }


    }
}
