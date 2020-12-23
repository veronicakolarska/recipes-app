using Recipes.Data.Models;
using System;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    public partial class RecipeTile : UserControl
    {
        public int RecipeId { get; private set; }

        public RecipeTile(Recipe recipe)
        {
            this.InitializeComponent();
            this.RecipeId = recipe.Id;
            this.recipeTitleLabel.Text = recipe.Name;
            this.recipePictureBox.Load(recipe.TitleImageUrl);

            this.recipePictureBox.Click += this.ControlClick;
            this.recipeTitleLabel.Click += this.ControlClick;
        }

        private void ControlClick(object sender, EventArgs e) 
        {
            this.OnClick(e);
        }
    }
}
