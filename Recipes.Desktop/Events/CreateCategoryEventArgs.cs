using Recipes.Data.Models;

namespace Recipes.Desktop.Events
{
    public class CreateCategoryEventArgs
    {
        public Category Category { get; set; }

        public CreateCategoryEventArgs(Category Category)
        {
            this.Category = Category;
        }
    }
}
