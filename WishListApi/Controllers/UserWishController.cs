using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WishListApi.Models;

namespace WishListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserWishController : ControllerBase
    {
        [HttpPost]
        public ActionResult<List<UserWish>> getAllItems()
        {
            return Ok();
        }
        
    }
}
