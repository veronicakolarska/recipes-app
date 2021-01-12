using Recipes.Data.Models;
using Recipes.Desktop.Events;
using Recipes.Desktop.ViewModels;
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
    public partial class UsersAdmin : UserControl
    {
        public UsersAdmin(IList<User> users)
        {
            this.InitializeComponent();

            this.LoadAdminUsersDataGrid(users);
        }

        protected void OnUserAdded(CreateUserEventArgs e)
        {
            if (this.UserAdded != null)
            {
                this.UserAdded(this, e);
            }
        }
        public event EventHandler<CreateUserEventArgs> UserAdded;

        protected void OnUserEdited(EditUserEventArgs e)
        {
            if (this.UserEdited != null)
            {
                this.UserEdited(this, e);
            }
        }
        public event EventHandler<EditUserEventArgs> UserEdited;

        protected void OnUserDeleted(DeleteUserEventArgs e)
        {
            if (this.UserDeleted != null)
            {
                this.UserDeleted(this, e);
            }
        }
        public event EventHandler<DeleteUserEventArgs> UserDeleted;


        private void LoadAdminUsersDataGrid(IList<User> users)
        {
            var allUsers = users.Select(x => new UserViewModel
            {
                Id = x.Id,
                CreatedOn = x.CreatedOn,
                Description = x.Description,
                Email = x.Email,
                ImageUrl = x.ImageUrl,
                ModifiedOn = x.ModifiedOn,
                Role = x.Role.ToString(),
            }).ToList();
            this.usersAdminDataGrid.DataSource = new BindingSource(new BindingList<UserViewModel>(allUsers), null);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm();
            addUserForm.UserAdded += this.AddUserFormHandler_UserAdded;
            addUserForm.Show();
        }

        private void AddUserFormHandler_UserAdded(object sender, Events.CreateUserEventArgs e)
        {
            this.OnUserAdded(e);
        }
    }
}

