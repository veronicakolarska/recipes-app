namespace Recipes_app.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Recipes_app.Data.Models;

    public class FavouriteRecipeConfiguration : IEntityTypeConfiguration<FavouriteRecipe>
    {
        public void Configure(EntityTypeBuilder<FavouriteRecipe> builder)
        {
        }

    }
}