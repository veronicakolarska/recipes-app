using Recipes.Data.Models;
using System;

namespace Recipes.Desktop.Events
{
    public class EditRecipeEventArgs : EventArgs
    {
        public Recipe Recipe { get; set; }

        public EditRecipeEventArgs(Recipe recipe)
        {
            this.Recipe = recipe;
        }
    }
}
