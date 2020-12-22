using System.Threading.Tasks;
using Recipes.Data.Common.Repositories;
using Recipes.Data.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Recipes.Services.Data
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;

        public UserService(
            IRepository<User> userRepository
        )
        {
            this.userRepository = userRepository;
        }

        public async Task Create(User user)
        {
            await this.userRepository.AddAsync(user);
            await this.userRepository.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return this.userRepository.All().Any((x) => x.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            var user = this.userRepository.All();
            return user;
        }

        public User GetById(int id)
        {
            return this.GetAll().FirstOrDefault((x) => x.Id == id);
        }

        public async Task Delete(int id)
        {
            var user = this.GetById(id);
            this.userRepository.Delete(user);
            await this.userRepository.SaveChangesAsync();
        }

        public async Task Update(User user)
        {
            this.userRepository.Update(user);
            await this.userRepository.SaveChangesAsync();
        }

        public User Login(string email, string password)
        {
            // 1. Validate data. Is it empty? Has requred length? Etc.
            // 2. Check if there is a user in the Database that has this email.
            // 3. Compare password to existing user using a bcrypt package (https://github.com/BcryptNet/bcrypt.net).
            // If all checks are correct, return a user object for the logged in user.

            return new User { Email = "dummy@test.bg"  };
        }

        public Task<User> Register(string email, string password)
        {
            // 1. Validate data. Is it empty? Has requred length? Etc.
            // 2. Check if there is NO user in the Database that has this email.
            // 3. Hash password using a bcrypt package (https://github.com/BcryptNet/bcrypt.net).
            // If all checks are correct, return a user object for the registered user.

            return Task.FromResult(new User { Email = "dummy@test.bg" });
        }
    }
}