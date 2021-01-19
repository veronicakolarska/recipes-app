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
    // CategoriesAdmin is a control with data - table
    public partial class CategoriesAdmin : UserControl
    {
        private int userId;
        private IEnumerable<Category> categories;

        // view model
        // displaying data in user-friendly way
        public CategoriesAdmin(IList<Category> categories, int userId)
        {
            this.InitializeComponent();
            this.userId = userId;
            this.categories = categories;

            this.LoadAdminCategoriesDataGrid(categories);
        }

        private void LoadAdminCategoriesDataGrid(IList<Category> categories)
        {
            // map all recipes to the viewModels 
            var allCategories = categories.Select(x => new CategoryViewModel
            {
                Id = x.Id,
                Creator = x.Creator.Email,
                CreatedOn = x.CreatedOn,
                ModifiedOn = x.ModifiedOn,
                Name = x.Name,
            }).ToList();

            // load data to dataGrid (WinForms control - table)
            this.categoriesAdminDataGrid.DataSource = new BindingSource(new BindingList<CategoryViewModel>(allCategories), null);

            // add edit button to each grid row
            var editButton = new DataGridViewButtonColumn();
            this.categoriesAdminDataGrid.Columns.Add(editButton);
            editButton.HeaderText = "Edit?";
            editButton.Text = "Edit";
            editButton.Name = "Edit";
            editButton.UseColumnTextForButtonValue = true;

            // Adding Delete button to each grid row
            var deleteButton = new DataGridViewButtonColumn();
            this.categoriesAdminDataGrid.Columns.Add(deleteButton);
            deleteButton.HeaderText = "Delete?";
            deleteButton.Text = "Delete";
            deleteButton.Name = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            this.categoriesAdminDataGrid.CellContentClick += this.CategoriesAdminDataGrid_CellContentClick;
        }

        private void CategoriesAdminDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                var categoryViewModel = (CategoryViewModel)grid.Rows[e.RowIndex].DataBoundItem;

                if (columnName == "Edit")
                {
                    var categoryToEdit = this.categories.FirstOrDefault(x => x.Id == categoryViewModel.Id);
                    var categoryAddForm = new AddCategoryForm(this.userId, categoryToEdit);
                    categoryAddForm.Show();
                    categoryAddForm.CategoryAdded += this.CategoryAddForm_CategoryAdded;
                }

                if (columnName == "Delete")
                {
                    this.OnCategoryDeleted(new DeleteCategoryEventArgs(categoryViewModel.Id));
                }
            }
        }


        // The CateogryAdded event is call both when we Add a new Category and we Editr a new category. 
        // In this case we want to transform the event to an Edit event.
        private void CategoryAddForm_CategoryAdded(object sender, CreateCategoryEventArgs e)
        {
            this.OnCategoryEdited(new EditCategoryEventArgs(e.Category));
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
