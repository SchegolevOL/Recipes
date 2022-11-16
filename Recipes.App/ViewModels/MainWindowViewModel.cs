using Recipes.App.Commands;
using Recipes.App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Recipes = new ObservableCollection<Recipe>();
            Recipe = new Recipe();
        }

        private string _search;
        public string Search { get => _search; set => SetField(ref _search, value); }

        public LambdaCommand CommandSearch { get; set; }
        public LambdaCommand CommandClear { get; set; }

    }
}
