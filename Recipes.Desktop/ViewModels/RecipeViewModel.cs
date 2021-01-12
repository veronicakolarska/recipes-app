using Recipes.Data.Models;
using System;

namespace Recipes.Desktop.ViewModels
{
    public class RecipeViewModel : BaseViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string TitleImageUrl { get; set; }

        public string Creator { get; set; }

        public string Category { get; set; }
    }
}
