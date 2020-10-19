namespace Recipes.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using Recipes.Data.Common.Models;

    public class DeletableEntity : AuditableEntity, IDeletableEntity
    {
        public DateTime? DeletedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}