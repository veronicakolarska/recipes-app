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
            throw new NotImplementedException();
        }

        public Task<User> Register(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}