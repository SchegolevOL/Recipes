using Recipes.App.Models;
using Recipes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.App.Lib
{
    public static class RecipesConverter
    {

        public static async IAsyncEnumerable<Models.Recipe> ConvertAsync(Root recipes)
        {
            foreach (var recipe in recipes.Hits.Select(hit => hit.Recipe))
            {
                yield return await Task.Run(() => new Models.Recipe
                {
                    Title = recipe.Label,
                    Ingredients = new ObservableCollection<string>(recipe.IngredientLines),
                    Image = recipe.Images.THUMBNAIL.Url
                });
            }
        }
    }
}
