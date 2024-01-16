using WishListApi.Models;

namespace WishListApi.Repositories.Interfaces
{
    public interface IWishList
    {
        Task<List<WishList>> GetListItems();
        Task<WishList> GetItemById(int id);
        Task<WishList> CreateWishItem(WishList wish);
        Task<WishList> UpdateWishList(WishList wish);
        Task<bool> DeleteWish(int id);
    }
}
