namespace Recipes.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Recipes.Data.Models;

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        // configuration of relationships between every entity (table) in the database
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasMany(x => x.Recipes)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}