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
    // UserControl comes from EF
    // CategoriesAdmin is a control with data - table
    public partial class CategoriesAdmin : UserControl
    {
        private int userId;

        public CategoriesAdmin(IList<Category> categories, int userId)
        {
            this.InitializeComponent();
            this.userId = userId;

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
            var addCategoryForm = new AddCategoryForm(this.userId);

            addCategoryForm.CategoryAdded += this.AddCategoryHandler;
            addCategoryForm.Show();
        }

        // event handler - for addCategoryForm.CategoryAdded
        // for event bubbling
        private void AddCategoryHandler(object sender, CreateCategoryEventArgs e)
        {
            this.OnCategoryAdded(e);
        }

        protected void OnCategoryAdded(CreateCategoryEventArgs e)
        {
            if (this.CategoryAdded != null)
            {
                this.CategoryAdded(this, e);
            }
        }

        public event EventHandler<CreateCategoryEventArgs> CategoryAdded;

        protected void OnCategoryEdited(EditCategoryEventArgs e)
        {
            if (this.CategoryEdited != null)
            {
                this.CategoryEdited(this, e);
            }
        }

        public event EventHandler<EditCategoryEventArgs> CategoryEdited;

        protected void OnCategoryDeleted(DeleteCategoryEventArgs e)
        {
            if (this.CategoryDeleted != null)
            {
                this.CategoryDeleted(this, e);
            }
        }

        public event EventHandler<DeleteCategoryEventArgs> CategoryDeleted;
    }
}
