using Recipes.Data.Models;
using System;

namespace Recipes.Desktop.Events
{
    public class EditUserEventArgs : EventArgs
    {
        public User User { get; set; }

        public EditUserEventArgs(User user)
        {
            this.User = user;
        }
    }
}
