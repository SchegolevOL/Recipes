using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.App.Models
{
    public class Recipe: BaseNotification
    {
        private string _title;
        public string Title 
        { get=>_title; set=>SetField(ref _title, value); }
        
        public ObservableCollection<string> Ingredients { get; set; }
        
        public ObservableCollection<string> Instructins { get; set; }
        private string _image;
        public string Image { get=> _image; set=> SetField(ref _image, value); }

        public Recipe()
        {
            Ingredients = new ObservableCollection<string>();
            Instructins = new ObservableCollection<string>();
        }
    }
}
