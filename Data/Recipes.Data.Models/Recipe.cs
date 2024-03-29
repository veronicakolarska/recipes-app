namespace Recipes.Data.Models
{
    using System;
    using Recipes.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Recipes.Common.Constants;

    public class Recipe : AuditableEntity
    {
        public Recipe()
        {
            this.FavouriteRecipes = new HashSet<FavouriteRecipe>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(GlobalConstants.RecipeNameMaxLength, MinimumLength = GlobalConstants.RecipeNameMinLength)]
        public string Name { get; set; }

        [StringLength(GlobalConstants.RecipeDescriptionNameMaxLength, MinimumLength = GlobalConstants.RecipeDescriptionNameMinLength)]
        public string Description { get; set; }

        [Required]
        public string TitleImageUrl { get; set; }

        [Required]
        public int CreatorId { get; set; }

        public User Creator { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<FavouriteRecipe> FavouriteRecipes { get; set; }
    }
}
