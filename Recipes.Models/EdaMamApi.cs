using System.Text.Json;

namespace Recipes.Models
{
    public static class EdaMamApi
    {
        public static async Task<Root> GetRecipesAsync(string quary)
        {
            var appId = "45d8b6fa";
            var appKey = "bf72c7e4fec04d45aec7471754063466";
            var url = $"https://api.edamam.com/api/recipes/v2?app_id={appId}&app_key={appKey}&q={quary}&type=public";
            using var client = new HttpClient();
            var stream = await client.GetStreamAsync(url);
            return await JsonSerializer.DeserializeAsync<Root>(stream);
        }
    }
}
