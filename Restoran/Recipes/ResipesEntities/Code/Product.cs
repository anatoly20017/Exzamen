using RecipesDomainAbstractions.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResipesEntities.Code
{
    [Table("Products")]
    public class Product : DbEntity
    {
        public string Name { get; set; }
        public string Dimension { get; set; }
    }
}
