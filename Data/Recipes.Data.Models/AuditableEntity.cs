namespace Recipes.Data.Models
{
    using Recipes.Data.Models.Contracts;
    using System;

    public class AuditableEntity : IAuditInfo
    {
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}