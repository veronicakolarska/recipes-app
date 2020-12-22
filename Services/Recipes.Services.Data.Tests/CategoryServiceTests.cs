using System;
using Xunit;
using Recipes.Data.Models;
using Recipes.Data.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [Fact]
        public async Task Create_IfGivenAValidCategory_ShouldAddToAllCategoriesAsync()
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
                }, new Category(){
                     Id = 3,
                    Name = "Salads",
                    CreatorId = 1
                }
            };

            var inMemoryCategoryRepository = new InMemoryRepository<Category>(initialData);
            var categoryService = new CategoryService(inMemoryCategoryRepository);

            var category = new Category()
            {
                Id = 4,
                Name = "Soups",
                CreatorId = 1
            };
            await categoryService.Create(category);

            var allCategories = inMemoryCategoryRepository.InMemoryStore;
            int expectedCategoryCount = 4;
            Assert.StrictEqual(expectedCategoryCount, allCategories.Count);

            var addedCategory = allCategories.FirstOrDefault(categoryTest => categoryTest.Id == category.Id);
            Assert.NotNull(addedCategory);
            Assert.StrictEqual(category, addedCategory);
        }


        [Fact]
        public void Create_IfGivenInvalidInput_ShouldThrowException()
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
                }, new Category(){
                     Id = 3,
                    Name = "Salads",
                    CreatorId = 1
                }
            };

            var inMemoryCategoryRepository = new InMemoryRepository<Category>(initialData);
            var categoryService = new CategoryService(inMemoryCategoryRepository);

            Category categoryTestNull = null;


            var allCategories = inMemoryCategoryRepository.InMemoryStore;
            int expectedCategoryCount = 4;
            Assert.StrictEqual(expectedCategoryCount, allCategories.Count);

            // TODO: category tests
            // var addedCategory = allCategories.FirstOrDefault(categoryTest => categoryTest.Id == category.Id);
            //  Assert.NotNull(addedCategory);
            //  Assert.StrictEqual(category, addedCategory);
        }

        [Fact]
        public void GetAll_ShouldReturnAllEntitiesInTheRepository()
        {
        }
    }
}
