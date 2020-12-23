namespace Recipes.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Recipes.Data.Models;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasMany(x => x.Recipes)
                .WithOne(x => x.Creator)
                .HasForeignKey(x => x.CreatorId);

            builder
                .HasMany(x => x.FavouriteRecipes)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);
        }

    }
}