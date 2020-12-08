using System;
using System.Threading.Tasks;
using Recipes.Data.Models;
using System.Collections.Generic;

namespace Recipes.Services.Data
{
    public interface IIngredientService
    {
        Task Create(Ingredient ingredient);

        Task Update(Ingredient ingredient);

        Ingredient GetById(int id);

        bool Exists(int id);

        Task Delete(int id);

        IEnumerable<Ingredient> GetAll();
    }
}