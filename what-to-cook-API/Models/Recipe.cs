using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace what_to_cook_API.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Category { get; set; }
        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal PrepTime { get; set; }
        [MaxLength(200)]
        public string DescriptionShort { get; set; }
        public string DescriptionLong { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}
