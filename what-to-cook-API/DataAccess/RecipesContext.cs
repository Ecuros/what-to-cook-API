using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using what_to_cook_API.Models;

namespace what_to_cook_API.DataAccess
{
    public class RecipesContext : DbContext
    {
        public RecipesContext(DbContextOptions options) : base(options) { }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        
    }
}
