using System;

namespace Recipes.Desktop.Events
{
    public class MadeFavouriteRecipeEventArgs : EventArgs
    {
        public int Id { get; set; }

        public MadeFavouriteRecipeEventArgs(int recipeId)
        {
            this.Id = recipeId;
        }
    }
}
