using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YumRestaurants.Model.Data;
using YumRestaurants.Model.Entities;

namespace YumRestaurants.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        IMenuRepo repo = new MenuRepo();
        [HttpGet]
        public ActionResult<List<MenuItem>> GetItemById(int id)
        {
            var menu = repo.GetItemById(id);
            if (menu == null)
            {
                return NotFound();
            }
          
           
            return Ok(menu);

          
        }


    }
}
