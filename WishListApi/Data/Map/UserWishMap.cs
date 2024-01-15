using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WishListApi.Models;

namespace WishListApi.Data.Map
{
    public class UserWishMap : IEntityTypeConfiguration<UserWish>
    {
        public void Configure(EntityTypeBuilder<UserWish> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(250);
        }
    }
}
