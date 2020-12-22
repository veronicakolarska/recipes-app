using Recipes.Data.Models;
using Recipes.Services.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    public partial class Main : Form
    {
        private ICategoryService categoryService;

        public Main(ICategoryService categoryService)
        {

            this.categoryService = categoryService;

            this.InitializeComponent();

            this.FormClosed += this.Main_FormClosed;

            this.recipesFlowPanel.Controls.Add(new RecipeTile(new Recipe { Name = "Test recipe1!" }));
            this.recipesFlowPanel.Controls.Add(new RecipeTile(new Recipe { Name = "Test recipe2!" }));
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e) 
        {
            var allOpenForms = Application.OpenForms.Cast<Form>();
            foreach (var form in allOpenForms)
            {
                form.Close();
            }
        }
    }
}
