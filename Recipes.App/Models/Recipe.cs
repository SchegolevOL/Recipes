using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.App.Models
{
    public class Recipe : BaseNotification
    {
        public int Id {set; get;}
        private string _title;
        public string Title 
        { get=>_title; set=>SetField(ref _title, value); }
        private string _ingredents;
        public string Ingredients { get=>_ingredents; set => SetField(ref _ingredents, value); }
        
        
        private string _image;
        public string Image { get=> _image; set=> SetField(ref _image, value); }

        public Recipe()
        { 
           
        }

        
    }
}
