using System.Threading.Tasks;
using Recipes.Data.Common.Repositories;
using Recipes.Data.Models;
using System.Linq;
using System.Collections.Generic;
using Recipes.Services.Data.Contracts;
using Microsoft.EntityFrameworkCore;

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
            // 1. Validate data. Is it empty? Etc.
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }
            // 2. Check if there is a user in the Database that has this email.

            var userExists = this.GetAll().Any((user) => user.Email == email);
            if (!userExists)
            {
                return null;
            }
            // 3. Compare password to existing user using a bcrypt package (https://github.com/BcryptNet/bcrypt.net).
            var userToCompare = this.GetAll().FirstOrDefault((user) => user.Email == email);
            var isPasswordCorrect = BCrypt.Net.BCrypt.Verify(password, userToCompare.Password);
            // If all checks are correct, return a user object for the logged in user.
            if (!isPasswordCorrect)
            {
                return null;
            }

            return userToCompare;
        }

        public async Task<User> Register(string email, string password)
        {
            // 1. Validate data. Is it empty? Etc.
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            // 2. Check if there is NO user in the Database that has this email.

            var userAlreadyExists = this.GetAll().Any((user) => user.Email == email);

            if (userAlreadyExists)
            {
                return null;
            }

            // 3. Hash password using a bcrypt package (https://github.com/BcryptNet/bcrypt.net).

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            var newUser = new User()
            {
                Email = email,
                Password = passwordHash,
                Role = Role.User,
            };

            await this.Create(newUser);

            // If all checks are correct, return a user object for the registered user.
            return newUser;
        }

        public User GetByEmailWithFavouriteRecipes(string email)
        {
            return this.userRepository
                    .All()
                    .Include(x => x.FavouriteRecipes)
                    .FirstOrDefault(x => x.Email == email);
        }
    }
}