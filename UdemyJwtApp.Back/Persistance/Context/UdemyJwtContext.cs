using Microsoft.EntityFrameworkCore;
using UdemyJwtApp.Back.Core.Domain;
using UdemyJwtApp.Back.Persistance.Configurations;

namespace UdemyJwtApp.Back.Persistance.Context
{
    public class UdemyJwtContext:DbContext
    {
        public UdemyJwtContext(DbContextOptions<UdemyJwtContext> options) : base(options) 
        {
        }

        public DbSet<Product> Produtcs => this.Set<Product>();
        //{ 
        //    get
        //    {
        //        return this.Set<Product>(); BURASI NASIL ÜSTTEKİYLE AYNI OLDU?
        //    } 
        //}
        public DbSet<Category> Categories => this.Set<Category>();

        public DbSet<AppUser> AppUsers => this.Set<AppUser>();

        public DbSet<AppRole> AppRoles => this.Set<AppRole>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
