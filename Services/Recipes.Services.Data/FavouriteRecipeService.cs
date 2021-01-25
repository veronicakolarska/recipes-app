using System.Threading.Tasks;
using Recipes.Data.Models;
using System.Collections.Generic;
using Recipes.Services.Data.Contracts;
using Recipes.Data.Contracts;
using System.Linq;

namespace Recipes.Services.Data
{
    public class FavouriteRecipeService : IFavouriteRecipeService
    {
        private readonly IRepository<FavouriteRecipe> favouriteRecipeRepository;

        public FavouriteRecipeService(
            IRepository<FavouriteRecipe> favouriteRecipeRepository
        )
        {
            this.favouriteRecipeRepository = favouriteRecipeRepository;
        }

        public async Task Create(FavouriteRecipe favouriteRecipe)
        {
            await this.favouriteRecipeRepository.AddAsync(favouriteRecipe);
            await this.favouriteRecipeRepository.SaveChangesAsync();
        }

        public Task Delete(int userId, int recipeId)
        {
            var favouriteRecipe = this.favouriteRecipeRepository
                .All()
                .FirstOrDefault((recipe) => (recipe.UserId == userId && recipe.RecipeId == recipeId));
            this.favouriteRecipeRepository.Delete(favouriteRecipe);
            return this.favouriteRecipeRepository.SaveChangesAsync();
        }

        public IEnumerable<FavouriteRecipe> GetAll()
        {
            var favouriteRecipe = this.favouriteRecipeRepository.All();
            return favouriteRecipe;
        }

        public async Task Update(FavouriteRecipe favouriteRecipe)
        {
            this.favouriteRecipeRepository.Update(favouriteRecipe);
            await this.favouriteRecipeRepository.SaveChangesAsync();
        }
    }
}