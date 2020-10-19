namespace Recipes_app.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Recipes_app.Data.Models;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // TODO: Configure
            // builder
            //     .HasMany(x => x.Recipes)
            //     .WithOne(x => x.User)
            //     .HasForeignKey(x => x.UserId);
        }

    }
}