using RecipesDomainAbstractions.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResipesEntities.Code
{
    [Table("Recipes")]
    public class Recipe : DbEntity
    {
            public string Name { get; set; }
            public List<Product> Products { get; set; }
        public string TextRecipe { get; set; }
    }
}
