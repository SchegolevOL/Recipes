using Recipes.App.Models;
using Recipes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Recipes.Models;
using Recipe = Recipes.App.Models.Recipe;
using System.Net.Http;
using System.IO;

namespace Recipes.App.Lib;
public static class RecipesConverter
{
    public static async IAsyncEnumerable<Recipe> ConvertAsync(Root recipes)
    {
        foreach (var hits in recipes.Hits)
        {
            var recipe = hits.Recipe;
            yield return new Recipe()
            {
                Title = recipe.Label,
                Ingredients = string.Join("\n", recipe.IngredientLines),
                Image = await DownloadImageAsync(recipe.Images.THUMBNAIL.Url, recipe.Label)
            };
        }

    }
    private static async Task<string> DownloadImageAsync(string url, string title)
    {
        var dir = $@"{Directory.GetCurrentDirectory()}\imajes";
        Directory.CreateDirectory(dir);
        var path = $@"{dir}\{title}.jpg";

        var http = new HttpClient();
        var respons = await http.GetAsync(url);
        await using var file = new FileStream(path, FileMode.Create, FileAccess.Write);
        await respons.Content.CopyToAsync(file);
        return path;
    }
}