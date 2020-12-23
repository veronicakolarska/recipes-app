using System;
using System.Threading.Tasks;
using Recipes.Data.Models;
using System.Collections.Generic;

namespace Recipes.Services.Data.Contracts
{
    public interface IFavouriteRecipeService
    {
        Task Create(FavouriteRecipe favouriteRecipe);

        Task Update(FavouriteRecipe favouriteRecipe);

        IEnumerable<FavouriteRecipe> GetAll();
    }
}