namespace Recipes.Data.Models
{
    using System;
    using Recipes.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Recipe : AuditableEntity
    {
        public Recipe()
        {
              this.Ingredients = new HashSet<Ingredient>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        // TODO: [StringLength()]
        public string Name { get; set; }

        // TODO: [StringLength()]
        public string Description { get; set; }

        [Required]
        public int CreatorId { get; set; }

        public User Creator { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
