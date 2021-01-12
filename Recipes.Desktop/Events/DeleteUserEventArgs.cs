using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Desktop.Events
{

    public class DeleteUserEventArgs : EventArgs
    {
        public int Id { get; set; }

        public DeleteUserEventArgs(int id)
        {
            this.Id = id;
        }

    }
}
