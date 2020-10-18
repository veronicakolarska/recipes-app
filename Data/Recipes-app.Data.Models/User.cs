namespace Recipes_app.Data.Models
{
    using System;
    using Recipes_app.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User : AuditableEntity
    {
        public User()
        {
            this.Recipes = new HashSet<Recipe>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        // TODO: [StringLength()]
        public string UserName { get; set; }

        [Required]
        // [StringLength()]
        public string Email { get; set; }

        [Required]
        // [StringLength()]
        public string Password { get; set; }

        public ICollection<Recipe> Recipes { get; set; }
    }
}