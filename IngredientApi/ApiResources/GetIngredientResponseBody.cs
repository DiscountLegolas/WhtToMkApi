using IngredientApi.EFCore.Models;

namespace IngredientApi.ApiResources
{
    public class GetIngredientResponseBody
    {
        public List<Ingredient> Ingredients { get; set; }
    }
}
