using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using WishListApi.Data.Map;
using WishListApi.Models;

namespace WishListApi.Data
{
    public class WishListDbContext : DbContext
    {

        public WishListDbContext()
        {
            
        }
        public WishListDbContext(DbContextOptions<WishListDbContext> options)
            :base(options) {}

        public DbSet<WishList> WishLists { get; set; }
        public DbSet<UserWish> UsersWish { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*Replicar para User Wish*/
            modelBuilder.ApplyConfiguration(new WishListMap());
            modelBuilder.ApplyConfiguration(new UserWishMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
