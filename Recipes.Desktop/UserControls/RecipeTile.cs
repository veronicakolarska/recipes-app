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

            // triggers the event for file if we click on the picture
            this.recipePictureBox.Click += this.ControlClick;
            // triggers the event for file if we click on the label
            this.recipeTitleLabel.Click += this.ControlClick;
        }


        // triggers new event for tile
        private void ControlClick(object sender, EventArgs e) 
        {
            this.OnClick(e);
        }
    }
}
