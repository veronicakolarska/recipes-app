namespace Recipes.Common.Constants
{
    public class GlobalConstants
    {
        public const int CategoryNameMaxLength = 20;
        public const int CategoryNameMinLength = 3;

        public const int IngredientNameMaxLength = 20;
        public const int IngredientNameMinLength = 3;

        public const int RecipeNameMaxLength = 20;
        public const int RecipeNameMinLength = 3;

        public const int RecipeDescriptionNameMaxLength = 20;
        public const int RecipeDescriptionNameMinLength = 3;

        public const int UserNameMaxLength = 20;
        public const int UserNameMinLength = 3;

        // at least 1 uppercase, at least 1 lowercase, at least 1 number or special character
        // at least 8 characters in length, max length is not limited
        public const string PasswordCheck = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";

    }
}