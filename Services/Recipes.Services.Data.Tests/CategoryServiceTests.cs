using System;
using Xunit;
using Recipes.Data.Models;
using Recipes.Data.Repositories;
using System.Collections.Generic;

namespace Recipes.Services.Data.Tests
{
    public class CategoryServiceTests
    {
        [Fact]
        public void Exists_IfGivenExistingId_ShouldReturnTrue()
        {
            var initialData = new List<Category>()
            {
                new Category(){
                    Id = 1,
                    Name = "Desserts",
                    CreatorId = 1
                }, new Category(){
                     Id = 2,
                    Name = "Main course",
                    CreatorId = 1
                }
            };

            var inMemoryCategoryRepository = new InMemoryRepository<Category>(initialData);
            var categoryService = new CategoryService(inMemoryCategoryRepository);

            var exist = categoryService.Exists(1);
            Assert.True(exist);
        }

        [Fact]
        public void Exists_IfGivenNonExistingId_ShouldReturnFalse()
        {
            var initialData = new List<Category>()
            {
                new Category(){
                    Id = 1,
                    Name = "Desserts",
                    CreatorId = 1
                }, new Category(){
                     Id = 2,
                    Name = "Main course",
                    CreatorId = 1
                }
            };

            var inMemoryCategoryRepository = new InMemoryRepository<Category>(initialData);
            var categoryService = new CategoryService(inMemoryCategoryRepository);

            // check by id
            var exist = categoryService.Exists(1245);
            Assert.False(exist);
        }
    }
}
