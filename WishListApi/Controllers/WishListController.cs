using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using WishListApi.Models;
using WishListApi.Repositories;

namespace WishListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishListController : ControllerBase
    {
       
        private readonly WishListRepository _wishList;
        public WishListController(WishListRepository wishList)
        {
            _wishList = wishList;
        }

        [HttpGet]
        public async Task<ActionResult<List<WishList>>> GetAllItems()
        {
            List<WishList> wishes = await _wishList.GetListItems();
            return Ok(wishes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<WishList>>> GetById(int id)
        {
            WishList wish = await _wishList.GetItemById(id);
            return Ok(wish);
        }

        [HttpPost]
        public async Task<ActionResult<WishList>> CreateWish([FromBody] WishList wishList)
        {
            WishList wish = await _wishList.CreateWishItem(wishList);
            return Ok(wish);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WishList>> UpdateWish([FromBody] WishList wishList, int id)
        {
            wishList.Id = id;
            WishList wish = await _wishList.UpdateWishList(wishList, id);
            return Ok(wish);
        }
    
    }
}
