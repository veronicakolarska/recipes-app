using Recipes.Data.Models;
using System;

namespace Recipes.Desktop.Events
{
    public class EditCategoryEventArgs : EventArgs
    {
        public Category Category { get; set; }

        public EditCategoryEventArgs(Category category)
        {
            this.Category = category;
        }
    }
}
