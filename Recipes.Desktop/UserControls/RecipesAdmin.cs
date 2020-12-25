using Recipes.Data.Models;
using Recipes.Desktop.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Recipes.Desktop.UserControls
{
    public partial class RecipesAdmin : UserControl
    {
        public RecipesAdmin(IList<Recipe> recipes)
        {
            this.InitializeComponent();

            this.LoadAdminRecipesDataGrid(recipes);
        }

        private void LoadAdminRecipesDataGrid(IList<Recipe> recipes)
        {
            var allRecipes = recipes.Select(x => new RecipeViewModel
            {
                Id = x.Id,
                Category = x.Category.Name,
                Creator = x.Creator.Email,
                Name = x.Name,
                Description = x.Description,
                TitleImageUrl = x.TitleImageUrl,
                CreatedOn = x.CreatedOn,
                ModifiedOn = x.ModifiedOn
            }).ToList();
            this.recipeAdminDataGrid.DataSource = new BindingSource(new BindingList<RecipeViewModel>(allRecipes), null);

            var button = new DataGridViewButtonColumn();
            this.recipeAdminDataGrid.Columns.Add(button);
            button.HeaderText = "Actions";
            button.Text = "Click Here";
            button.Name = "Delete Button";
            button.UseColumnTextForButtonValue = true;
        }
    }
}
