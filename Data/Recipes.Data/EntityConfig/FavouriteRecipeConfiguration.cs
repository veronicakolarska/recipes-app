namespace Recipes.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Recipes.Data.Models;

    public class FavouriteRecipeConfiguration : IEntityTypeConfiguration<FavouriteRecipe>
    {
        public void Configure(EntityTypeBuilder<FavouriteRecipe> builder)
        {
            // TODO: Configure
        }

    }
}