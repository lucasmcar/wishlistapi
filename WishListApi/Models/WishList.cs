
namespace WishListApi.Models
{
    public class WishList
    {
        public int Id { get; set; }
        public required string Item { get; set; }
        public required string Link { get; set; }

        public int IdUsuario { get; set; }

    }
}
