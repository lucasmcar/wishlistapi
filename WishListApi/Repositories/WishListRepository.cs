
using Microsoft.EntityFrameworkCore;
using WishListApi.Data;
using WishListApi.Models;
using WishListApi.Repositories.Interfaces;

namespace WishListApi.Repositories
{
    public class WishListRepository : IWishList
    {

        private readonly WishListDbContext _dbContext;

        public WishListRepository(WishListDbContext db)
        {
            _dbContext = db;
        }


        public async Task<WishList> CreateWishItem(WishList wish)
        {
            await _dbContext.WishLists.AddAsync(wish);
            await _dbContext.SaveChangesAsync();

            return wish;
        }

        public async Task<bool> DeleteWish(int id)
        {
            WishList wishL = await GetItemById(id);

            if (wishL == null)
            {
                throw new Exception("Item não encontrado");
            }

            _dbContext.WishLists.Remove(wishL);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<WishList> GetItemById(int id)
        {
            return await _dbContext.WishLists.FirstOrDefaultAsync(x => x.Id == id);
            
        }

        public async Task<List<WishList>> GetListItems()
        {
            return await _dbContext.WishLists.ToListAsync();
            
        }

        public async Task<WishList> UpdateWishList(WishList wish, int id)
        {
            WishList wishL = await GetItemById(id);

            if(wishL == null)
            {
                throw new Exception("Item não encontrado");
            }

            wishL.Item = wish.Item;
            wishL.Link = wish.Link;

            _dbContext.WishLists.Update(wishL);
            await _dbContext.SaveChangesAsync();

            return wishL;
        }

        public Task<WishList> UpdateWishList(WishList wish)
        {
            throw new NotImplementedException();
        }
    }
}
