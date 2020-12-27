using System;
using System.Threading.Tasks;
using Recipes.Data.Models;
using System.Collections.Generic;

namespace Recipes.Services.Data.Contracts
{
    // use of interface - because we should also programme against interfaces in order to have loose coupling
    // so we won't use exactly one implementation

    // business logic  - rules specific for the application
    // organized in one place
    // exactly how something works - utilities in the UI
    public interface ICategoryService
    {
        Task Create(Category category);

        Task Update(Category category);

        Category GetById(int id);

        bool Exists(int id);

        Task Delete(int id);

        IEnumerable<Category> GetAll();

        IEnumerable<Category> GetAllWithRelatedData();
    }
}