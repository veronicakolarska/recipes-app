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

            MessageBox.Show($"{Thread.CurrentPrincipal.Identity.Name}");

            this.InitializeComponent();
        }
    }
}
