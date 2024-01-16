using Microsoft.EntityFrameworkCore;
using WishListApi.Data;
using WishListApi.Models;

namespace WishListApi.Repositories
{
    public class UserWishRepository
    {

        private readonly WishListDbContext _dbContext;

        public UserWishRepository(WishListDbContext db)
        {
            _dbContext = db;
        }
        public async Task<List<UserWish>> GetAllUser()
        {
            return await _dbContext.UsersWish.ToListAsync();

        }
    }
}
