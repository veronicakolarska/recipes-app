using Recipes.Data.Models;
using System;

namespace Recipes.Desktop.Events
{
    public class CreateUserEventArgs : EventArgs
    {
        public User User { get; set; }

        public CreateUserEventArgs(User user)
        {
            this.User = user;
        }
    }
}
