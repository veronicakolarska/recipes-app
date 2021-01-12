using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Desktop.Events
{

    public class DeleteCategoryEventArgs : EventArgs
    {
        public int Id { get; set; }

        public DeleteCategoryEventArgs(int id)
        {
            this.Id = id;
        }

    }
}
