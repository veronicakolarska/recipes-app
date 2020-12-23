using System;
using System.Threading.Tasks;
using Recipes.Data.Models;
using System.Collections.Generic;

namespace Recipes.Services.Data.Contracts
{
    public interface ICategoryService
    {
        Task Create(Category category);

        Task Update(Category category);

        Category GetById(int id);

        bool Exists(int id);

        Task Delete(int id);

        IEnumerable<Category> GetAll();
    }
}