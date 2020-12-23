namespace Recipes.Data.Models
{
    using System;
    using Recipes.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Recipes.Common.Constants;

    public class Ingredient : AuditableEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(GlobalConstants.IngredientNameMaxLength, MinimumLength = GlobalConstants.IngredientNameMinLength)]
        public string Name { get; set; }

        [Required]
        public decimal Quantity { get; set; }

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }
    }
}