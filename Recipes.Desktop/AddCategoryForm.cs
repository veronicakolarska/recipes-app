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
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            this.InitializeComponent();
        }

        protected void OnCategoryAdded(CreateCategoryEventArgs e)
        {
            if (this.CategoryAdded != null)
            {
                this.CategoryAdded(this, e);
            }
        }

        public event EventHandler<CreateCategoryEventArgs> CategoryAdded;

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            var categoryName = this.categoryNameInput.Text;

            var category = new Category()
            {
                Name = categoryName,
                CreatorId = 1
            };

            this.OnCategoryAdded(new CreateCategoryEventArgs(category));
            this.Close();
        }
    }
}
