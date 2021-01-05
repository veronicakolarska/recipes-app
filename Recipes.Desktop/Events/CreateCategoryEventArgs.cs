using Recipes.Data.Models;
using System;

namespace Recipes.Desktop.Events
{
    public class CreateCategoryEventArgs : EventArgs
    {
        public Category Category { get; set; }

        public CreateCategoryEventArgs(Category Category)
        {
            this.Category = Category;
        }
    }
}
