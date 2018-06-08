using RecipesDomainAbstractions.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResipesEntities.Code
{
    [Table("Dishes")]
    public class Dish : DbEntity
    {
        public string Name { get; set; }
        public virtual List<Recipe> Recipes { get; set; }
    }
}
