using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WishListApi.Models;

namespace WishListApi.Data.Map
{
    public class WishListMap : IEntityTypeConfiguration<WishList>
    {
        public void Configure(EntityTypeBuilder<WishList> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Item).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Link).IsRequired().HasMaxLength(250);
            
        }
    }
}
