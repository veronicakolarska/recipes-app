namespace Recipes.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Recipes.Data.Models;

    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder
               .HasMany(x => x.Ingredients)
               .WithOne(x => x.Recipe)
               .HasForeignKey(x => x.RecipeId);

            builder
                .HasMany(x => x.FavouriteRecipes)
                .WithOne(x => x.Recipe)
                .HasForeignKey(x => x.RecipeId);
        }
    }
}