namespace Recipes.Data.Models
{
    using System;
    using Recipes.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Recipes.Common.Constants;

    public class Category : AuditableEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(GlobalConstants.CategoryNameMaxLength, MinimumLength = GlobalConstants.CategoryNameMinLength)]
        public string Name { get; set; }

        [Required]
        public int CreatorId { get; set; }

        public User Creator { get; set; }
    }
}
