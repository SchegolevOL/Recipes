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
            Recipes = new ObservableCollection<Models.Recipe>();
            Recipe = new Recipe();
            CommandSearch = new LambdaCommand(_ => true, async _=> await GetData());
        }
        private async Task GetData()
        {
            var r = await EdaMamApi.GetRecipesAsync(Search);
            var t = await RecipesConverter.ConvertAsync(r);
            foreach (var item in t)
            {
                Recipes.Add(item);
            }
        }
        private string _search;
        public string Search { get => _search; set => SetField(ref _search, value); }

        public LambdaCommand CommandSearch { get; set; }
        public LambdaCommand CommandClear { get; set; }

    }
}
