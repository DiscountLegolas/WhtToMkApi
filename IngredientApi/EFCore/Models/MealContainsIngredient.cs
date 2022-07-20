using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngredientApi.EFCore.Models
{
    public class MealContainsIngredient
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public int IngredientId { get; set; }
        public int MealId { get; set; }
        public virtual Ingredient Ingredient { get; set; }
        public virtual Meal Meal { get; set; }

    }
}
