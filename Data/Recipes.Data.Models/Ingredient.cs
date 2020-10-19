namespace Recipes.Data.Models
{
    using System;
    using Recipes.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Ingredient : AuditableEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        // TODO: [StringLength()]
        public string Name { get; set; }

        [Required]
        public decimal Quantity { get; set; }
    }
}