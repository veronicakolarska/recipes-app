namespace Recipes_app.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Recipes_app.Data.Models;

    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            // TODO: Configure
            // builder
            //    .HasMany(x => x.Ingredients)
            //    .WithOne(x => x.Recipe)
            //    .HasForeignKey(x => x.RecipeId);
        }
    }
}