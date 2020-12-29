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
        public CategoriesAdmin(IList<Category> categories)
        {
            this.InitializeComponent();

            this.LoadAdminCategoriesDataGrid(categories);

            // this.CategoryAdded += (object sender, CreateCategoryEventArgs e) => {

            // };
        }



        // event handler - way to expect some event to happen
        public event EventHandler<CreateCategoryEventArgs> CategoryAdded;

        // a way to trigger the event when the category is added
        protected virtual void OnCategoryAdded(CreateCategoryEventArgs e)
        {
            // checks if someone is subscribed for the event
            if (this.CategoryAdded != null)
            {
                // triggers the event with the sender (current form) and the packet with information
                this.CategoryAdded(this, e);
            }
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
            // get name
            // get description
            // etc.

            var newCategory = new Category {};
            this.OnCategoryAdded(new CreateCategoryEventArgs(newCategory));
        }
    }
}
