using System.Collections.Generic;
using RecipeSharingAPI.Models;

namespace RecipeSharingAPI.Services
{
    public interface IRecipeService
    {
        Recipe GetRecipe(int id);
        List<Recipe> GetRecipes();
        Recipe CreateRecipe(Recipe recipe);
        Recipe UpdateRecipe(Recipe recipe);
        Recipe DeleteRecipe(int id);

        List<Recipe> SearchRecipeByTitle(string title);
    }
}