using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngredientApi.EFCore.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string IngredientName { get; set; }
        public string PictureUrlName { get; set; }
        public virtual ICollection<MealContainsIngredient> MealsContainingIngredient { get; set; }


    }
}
