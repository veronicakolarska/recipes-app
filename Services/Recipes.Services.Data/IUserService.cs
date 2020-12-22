using System;
using System.Threading.Tasks;
using Recipes.Data.Models;
using System.Collections.Generic;

namespace Recipes.Services.Data
{
    public interface IUserService
    {
        Task Create(User user);

        Task Update(User user);

        User GetById(int id);

        bool Exists(int id);

        Task Delete(int id);

        IEnumerable<User> GetAll();

        User Login(string email, string password);

        Task<User> Register(string email, string password);
    }
}