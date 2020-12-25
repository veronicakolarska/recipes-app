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
    public partial class CategoriesAdmin : UserControl
    {
        public CategoriesAdmin(IList<Category> categories)
        {
            this.InitializeComponent();

            this.LoadAdminCategoriesDataGrid(categories);
        }

        private void LoadAdminCategoriesDataGrid(IList<Category> categories)
        {
            var allCategories = categories.Select(x => new CategoryViewModel
            {
                Id = x.Id,
                Creator = x.Creator.Email,
                CreatedOn = x.CreatedOn,
                ModifiedOn = x.ModifiedOn,
                Name = x.Name,
            }).ToList();
            this.categoriesAdminDataGrid.DataSource = new BindingSource(new BindingList<CategoryViewModel>(allCategories), null);
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
        }
    }
}
