using Recipes.Data.Models;
using Recipes.Desktop.Events;
using System;
using System.Windows.Forms;

namespace Recipes.Desktop
{

    public partial class AddCategoryForm : Form
    {
        private Category model;
        private int userId;

        // If we pass a category, It will be populated in the form for editing
        public AddCategoryForm(int userId, Category category = null)
        {
            this.userId = userId;
            this.model = category;

            this.InitializeComponent();

            if (category != null)
            {
                this.categoryNameInput.Text = category.Name;
            }
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

            // This updates the existing model if we are using the form for editing
            if (this.model != null)
            {
                this.model.Name = categoryName;
                this.OnCategoryAdded(new CreateCategoryEventArgs(this.model));
                this.Close();
            }
            else
            {
                var category = new Category()
                {
                    Name = categoryName,
                    CreatorId = this.userId
                };

                this.OnCategoryAdded(new CreateCategoryEventArgs(category));
                this.Close();
            }
        }
    }
}
