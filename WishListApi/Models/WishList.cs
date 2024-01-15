using Org.BouncyCastle.Asn1.Crmf;
using WishListApi.Enums;

namespace WishListApi.Models
{
    public class WishList
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Link { get; set; }

        public WishStatus status { get; set; }

        public int IdUsuario { get; set; }

    }
}
