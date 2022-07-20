using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngredientApi.EFCore.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string MealName { get; set; }
        public string MealPicture { get; set; }
        public string Instructions { get; set; }
        public virtual ICollection<MealContainsIngredient> Ingredients { get; set; }
    }
}
