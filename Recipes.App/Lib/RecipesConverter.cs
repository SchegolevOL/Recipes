using Recipes.App.Models;
using Recipes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Recipes.Models;
using Recipe = Recipes.App.Models.Recipe;
namespace Recipes.App.Lib;
public static class RecipesConverter
{
    public static async Task<IEnumerable<Recipe>> ConvertAsync(Root recipes)
    {
        return await Task.Run(() => recipes.Hits
            .Select(hit => hit.Recipe)
            .Select(recipe => new Recipe
            {
                Title = recipe.Label,
                Ingredients = new ObservableCollection<string>(recipe.IngredientLines),
                Image = recipe.Images.THUMBNAIL.Url
            }));
    }
}