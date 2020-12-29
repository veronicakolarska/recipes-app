using Recipes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Desktop.Events
{
    public class CreateRecipeEventArgs : EventArgs
    {
        // wrapped packet through the pipe
        public Recipe Recipe { get; set; }

        public CreateRecipeEventArgs(Recipe recipe)
        {
            this.Recipe = recipe;
        }
    }
}
