namespace Recipes.Data.Models
{
    using System;
    using Recipes.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class FavouriteRecipe : AuditableEntity
    {
        public string UserId { get; set; }

        public User User { get; set; }

        public string RecipeId { get; set; }

        public Recipe Recipe { get; set; }
    }
}