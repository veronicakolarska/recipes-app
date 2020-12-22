namespace Recipes.Console
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Recipes.Data;
    using Recipes.Data.Models;
    using Recipes.Data.Repositories;

    class Program
    {
        public static async Task Main(string[] args)
        {
            var RecipeContext = new RecipeContext();

            var efRepositoryUser = new EfRepository<User>(RecipeContext);
            var efRepositoryRecipe = new EfRepository<Recipe>(RecipeContext);
            var efRepositoryCategory = new EfRepository<Category>(RecipeContext);
            var efRepositoryFavouriteRecipe = new EfRepository<FavouriteRecipe>(RecipeContext);
            var efRepositoryIngredient = new EfRepository<Ingredient>(RecipeContext);
            // TODO: await
        }
    }
}
