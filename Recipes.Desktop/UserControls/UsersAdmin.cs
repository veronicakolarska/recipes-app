using Recipes.Data.Models;
using Recipes.Desktop.Events;
using Recipes.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Recipes.Desktop.UserControls
{
    // UserControl comes from EF
    // UserAdmin is a control with data - table
    public partial class UsersAdmin : UserControl
    {
        private IEnumerable<User> users;

        // view model
        // displaying data in user-friendly way
        public UsersAdmin(IList<User> users)
        {
            this.InitializeComponent();
            this.users = users;
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

            // load data to dataGrid (WinForms control - table)
            this.usersAdminDataGrid.DataSource = new BindingSource(new BindingList<UserViewModel>(allUsers), null);

            // Adding edit button to each grid row
            var editButton = new DataGridViewButtonColumn();
            this.usersAdminDataGrid.Columns.Add(editButton);
            editButton.HeaderText = "Edit?";
            editButton.Text = "Edit";
            editButton.Name = "Edit";
            editButton.UseColumnTextForButtonValue = true;

            // Adding Delete button to each grid row
            var deleteButton = new DataGridViewButtonColumn();
            this.usersAdminDataGrid.Columns.Add(deleteButton);
            deleteButton.HeaderText = "Delete?";
            deleteButton.Text = "Delete";
            deleteButton.Name = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            this.usersAdminDataGrid.CellContentClick += this.UsersAdminDataGrid_CellContentClick;
        }

        private void UsersAdminDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                //They clicked the header column, do nothing
                return;
            }
            // Check if it's a grid action button
            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                var columnName = grid.Columns[e.ColumnIndex].Name;
                // Get the view model for the row, which had it's action button clicked
                var userViewModel = (UserViewModel)grid.Rows[e.RowIndex].DataBoundItem;

                if (columnName == "Edit")
                {
                    var userToEdit = this.users.FirstOrDefault(x => x.Id == userViewModel.Id);
                    var userAddForm = new AddUserForm(userToEdit);
                    userAddForm.Show();
                    userAddForm.UserAdded += this.UserAddForm_UserAdded;

                }

                if (columnName == "Delete")
                {
                    var areYouSure = MessageBox.Show("Are you sure you want to delete this?", "Delete item", MessageBoxButtons.YesNo);
                    if (areYouSure == DialogResult.Yes)
                    {
                        this.OnUserDeleted(new DeleteUserEventArgs(userViewModel.Id));
                    }
                }
            }
        }

        // The UserAdded event is call both when we Add a new User and we Editr a new category. 
        // In this case we want to transform the event to an Edit event.
        private void UserAddForm_UserAdded(object sender, CreateUserEventArgs e)
        {
            this.OnUserEdited(new EditUserEventArgs(e.User));
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm();
            addUserForm.UserAdded += this.AddUserFormHandler_UserAdded;
            addUserForm.Show();
        }

        // event handler - for addUserForm_UserAdded
        // for event bubbling
        private void AddUserFormHandler_UserAdded(object sender, CreateUserEventArgs e)
        {
            this.OnUserAdded(e);
        }
    }
}

