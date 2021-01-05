using System;

namespace Recipes.Desktop.ViewModels
{
    public class BaseViewModel
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
