namespace Recipes.Data.Models
{
    using System;
    using Recipes.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Recipes.Common.Constants;

    public class User : AuditableEntity
    {
        public User()
        {
            this.Recipes = new HashSet<Recipe>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(GlobalConstants.UserNameMaxLength, MinimumLength = GlobalConstants.UserNameMinLength)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(GlobalConstants.PasswordCheck)]
        public string Password { get; set; }

        public ICollection<Recipe> Recipes { get; set; }
    }
}