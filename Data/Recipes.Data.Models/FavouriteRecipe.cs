namespace Recipes.Data.Models
{
    using System;
    using Recipes.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class FavouriteRecipe : AuditableEntity
    {
        public int UserId { get; set; }

        public User User { get; set; }

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }
    }
}