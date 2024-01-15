using WishListApi.Models;

namespace WishListApi.Repositories.Interfaces
{
    public interface IWishList
    {
        Task<List<WishList>> getListItems();
        Task<WishList> getItemById(int id);
        Task<WishList> CreateWishItem(WishList wish);
        Task<WishList> UpdateWishList(WishList wish);
        Task<bool> DeleteWish(int id);
    }
}
