namespace Recipes_app.Data.Models
{
    using System;
    using Recipes_app.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Ingredient : AuditableEntity
    {
        public Ingredient()
        {
            this.Ingredients = new HashSet<Ingredient>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        // TODO: [StringLength()]
        public string Name { get; set; }

        [Required]
        public decimal Quantity { get; set; }
    }
}