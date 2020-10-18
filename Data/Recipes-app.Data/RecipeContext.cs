namespace Recipes_app.Data
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Recipes_app.Data.Models;
    using System.Linq;
    // TODO: EntityConfig in TrainMe.Data, using Recipes_app.Data.EntityConfig;

    public class RecipeContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<FavouriteRecipe> FavouriteRecipes { get; set; }

        public RecipeContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
