using IngredientApi.ApiResources;
using IngredientApi.EFCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IngredientApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private MealDatabaseContext _context;
        public IngredientsController()
        {
            _context = new MealDatabaseContext();

        }
        [Authorize]
        [HttpGet]
        public IActionResult GetIngredients()
        {
            var token = HttpContext.GetTokenAsync("access_token").Result;
            Console.WriteLine(token);
            GetIngredientResponseBody body=new GetIngredientResponseBody() { Ingredients= _context.Ingredients.Where(x => x.Id == _context.Ingredients.First(a => a.IngredientName.ToLower() == x.IngredientName.ToLower()||a.PictureUrlName==x.PictureUrlName).Id).ToList() };
            return Ok(body);
        }
    }
}
