namespace Recipes_app.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using Recipes_app.Data.Common.Models;

    public class DeletableEntity : AuditableEntity, IDeletableEntity
    {
        public DateTime? DeletedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}