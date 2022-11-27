using Microsoft.EntityFrameworkCore;
using Recipes.App.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.App.Lib
{
    public class DataBase : DbContext 
    {
        public DbSet<Recipe> Recipes { get; set; }

        public DataBase()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=recipes.db;");
        }

        public async Task AddRecipeAsync(Recipe recipe)
        {
            var contains = await Recipes.AnyAsync(r => r.Title == recipe.Title);
            if (!contains)
            {
                await Recipes.AddAsync(recipe);
                await SaveChangesAsync();
            }

        }
    }

}
