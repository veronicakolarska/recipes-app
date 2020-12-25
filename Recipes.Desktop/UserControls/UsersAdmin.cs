using Recipes.Data.Models;
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
    }
}
