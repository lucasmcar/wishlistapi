using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WishListApi.Models;
using WishListApi.Repositories;

namespace WishListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserWishController : ControllerBase
    {

        private readonly UserWishRepository _userWishRepository;

        public UserWishController(UserWishRepository userWishRepository)
        {
            _userWishRepository = userWishRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<UserWish>>> GetAllUsers()
        {
            List<UserWish> userWishes = await _userWishRepository.GetAllUser();
            return Ok(userWishes);
        }
        
    }
}
