using System;
using System.Threading.Tasks;
using Recipes.Data.Models;
using System.Collections.Generic;

namespace Recipes.Services.Data.Contracts
{
    public interface IRecipeService
    {
        Task Create(Recipe recipe);

        Task Update(Recipe recipe);

        Recipe GetById(int id);

        Recipe GetByIdWithIngredients(int id);

        bool Exists(int id);

        Task Delete(int id);

        IEnumerable<Recipe> GetAll();
    }
}