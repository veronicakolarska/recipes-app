using System;
using System.Threading.Tasks;
using Recipes.Data.Models;
using System.Collections.Generic;

namespace Recipes.Services.Data
{
    public interface IFavouriteRecipeService
    {
        Task Create(FavouriteRecipe favouriteRecipe);

        Task Update(FavouriteRecipe favouriteRecipe);

        FavouriteRecipe GetById(int id);

        bool Exists(int id);

        Task Delete(int id);

        IEnumerable<FavouriteRecipe> GetAll();
    }
}