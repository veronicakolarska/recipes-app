using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Desktop.Events
{

    public class DeleteRecipeEventArgs : EventArgs
    {
        public int Id { get; set; }

        public DeleteRecipeEventArgs(int id)
        {
            this.Id = id;
        }

    }
}
