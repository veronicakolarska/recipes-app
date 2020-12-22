using Recipes.Data.Models;
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
    public partial class RecipeTile : UserControl
    {
        public int RecipeId { get; private set; }

        public RecipeTile(Recipe recipe)
        {
            this.InitializeComponent();
            this.RecipeId = recipe.Id;
            this.recipeTitleLabel.Text = recipe.Name;
            this.recipePictureBox.Load("https://store-images.s-microsoft.com/image/apps.14591.9a19b1cb-7ffc-4b32-bf97-25ef75ec69a3.753de052-0f07-4e5e-a20d-e4d5688136af.e2247862-7caa-44e8-8915-ca934ab9b663.png");

            this.recipePictureBox.Click += this.ControlClick;
            this.recipeTitleLabel.Click += this.ControlClick;
        }

        private void ControlClick(object sender, EventArgs e) 
        {
            this.OnClick(e);
        }
    }
}
