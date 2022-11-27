using Recipes.App.Commands;
using Recipes.App.Lib;
using Recipes.App.Models;
using Recipes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recipe = Recipes.App.Models.Recipe;
namespace Recipes.App.ViewModels
{
    public class MainWindowViewModel: BaseNotification
    {
        private Recipe _recipe;
        public Recipe Recipe
        {
            get { return _recipe; }
            set { SetField(ref _recipe, value); }            
        }
        public ObservableCollection<Recipe> Recipes { get; set; }

        public MainWindowViewModel()
        {
            _db = new DataBase();
            Recipes = new ObservableCollection<Recipe>();
            Recipe = new Recipe();
            CommandSearch = new LambdaCommand(_ => true, async _=> await GetData());
            CommandClear = new LambdaCommand(_ => true, _ => Clear());
            CommandSaveToDb = new LambdaCommand(_ => true, async _ => await SaveToDbAsync());
            CommandShowFavorite = new LambdaCommand(_ => true, _ => ShowFavorite());
        }
        private async Task GetData()
        {
            Recipes.Clear();
            await foreach (var item in RecipesConverter.ConvertAsync(await EdaMamApi.GetRecipesAsync(Search)))
            {
                Recipes.Add( item);
            }
        }

        private void Clear()
        {
            Search = string.Empty;
        }

        private async Task SaveToDbAsync()
        {
            await _db.AddRecipeAsync(Recipe);
        }

        private void ShowFavorite()
        {
            Recipes.Clear();
            foreach (var recipe in _db.Recipes)
            {
                Recipes.Add(recipe);
            }
        }


        private DataBase _db;

        private string _search;
        public string Search { get => _search; set => SetField(ref _search, value); }

        public LambdaCommand CommandSearch { get; set; }
        public LambdaCommand CommandClear { get; set; }
        public LambdaCommand CommandSaveToDb { get; set; }
        public LambdaCommand CommandShowFavorite { get; set; }

    }
}
