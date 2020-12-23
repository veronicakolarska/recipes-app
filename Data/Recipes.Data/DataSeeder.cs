using Microsoft.EntityFrameworkCore;
using Recipes.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data
{
    class DataSeeder
    {

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new { Id = 1, Email = "someMail@abv.bg", Password = "123FDGEF", ImageUrl = "https://p7.hiclipart.com/preview/780/873/166/cooking-mama-world-kitchen-cooking-mama-lets-cookuff01-puzzle-cooking-mama-cooking-png-photo-thumbnail.jpg", Description = "I'm 20 years old", Role = Role.User, CreatedOn = DateTime.Now },
                new { Id = 2, Email = "other@abv.bg", Password = "12FddFDDGEF2", ImageUrl = "https://p7.hiclipart.com/preview/780/873/166/cooking-mama-world-kitchen-cooking-mama-lets-cookuff01-puzzle-cooking-mama-cooking-png-photo-thumbnail.jpg", Description = "Hello there", Role = Role.User, CreatedOn = DateTime.Now },
                new { Id = 3, Email = "email@abv.bg", Password = "werDGEF2", ImageUrl = "https://p7.hiclipart.com/preview/780/873/166/cooking-mama-world-kitchen-cooking-mama-lets-cookuff01-puzzle-cooking-mama-cooking-png-photo-thumbnail.jpg", Description = "I'm new here", Role = Role.User, CreatedOn = DateTime.Now },
                new { Id = 4, Email = "email@abv.bg", Password = "ggdsg@gmail.com", ImageUrl = "https://p7.hiclipart.com/preview/780/873/166/cooking-mama-world-kitchen-cooking-mama-lets-cookuff01-puzzle-cooking-mama-cooking-png-photo-thumbnail.jpg", Description = "Admin", Role = Role.Administrator, CreatedOn = DateTime.Now }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Salads", CreatorId = 4, CreatedOn = DateTime.Now },
                new Category { Id = 2, Name = "Soups", CreatorId = 4, CreatedOn = DateTime.Now },
                new Category { Id = 3, Name = "Main dishes", CreatorId = 4, CreatedOn = DateTime.Now },
                new Category { Id = 4, Name = "Vegetarian", CreatorId = 4, CreatedOn = DateTime.Now },
                new Category { Id = 5, Name = "Desserts", CreatorId = 4, CreatedOn = DateTime.Now },
                new Category { Id = 6, Name = "Drinks", CreatorId = 4, CreatedOn = DateTime.Now }
              );

            modelBuilder.Entity<Recipe>().HasData(
                new Recipe { Id = 1, Name = "Musaka", CategoryId = 3, CreatorId = 1, Description = "Traditional Bulgarian dish", TitleImageUrl = "https://i0.wp.com/www.kashkaval-tourist.com/wp-content/uploads/2014/02/musaka.jpg", CreatedOn = DateTime.Now },
                new Recipe { Id = 2, Name = "Chocolate cake", CategoryId = 5, CreatorId = 3, Description = "Classic chocolate cake", TitleImageUrl = "https://cdn.sallysbakingaddiction.com/wp-content/uploads/2013/04/triple-chocolate-cake-4.jpg", CreatedOn = DateTime.Now }
                );


            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { Id = 1, Name = "Potatoes", Unit = "kg", Quantity = 1.5m, RecipeId = 1, CreatedOn = DateTime.Now },
                new Ingredient { Id = 2, Name = "Meat", Unit = "kg", Quantity = 0.7m, RecipeId = 1, CreatedOn = DateTime.Now },
                new Ingredient { Id = 3, Name = "Milk", Unit = "ml", Quantity = 1m, RecipeId = 2, CreatedOn = DateTime.Now },
                new Ingredient { Id = 4, Name = "Biscuits", Unit = "kg", Quantity = 0.25m, RecipeId = 2, CreatedOn = DateTime.Now },
                new Ingredient { Id = 5, Name = "Chocolate", Unit = "kg", Quantity = 0.2m, RecipeId = 2, CreatedOn = DateTime.Now }
                );

        }
    }
}
