using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using _20250118_ShopAspNetMvc.Models;

namespace _20250118_ShopAspNetMvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "iPhone",
                    Price = 699,
                    Quantity = 10,
                    Discount = 10,
                    Description = "iPhone is a line of smartphones designed and marketed by Apple Inc. They run Apple's iOS mobile operating system. The first iPhone was released on June 29, 2007, and an iPhone has been released every year since then.",
                    ImageUrl = "https://m.media-amazon.com/images/I/61bK6PMOC3L.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "iMac",
                    Price = 1999,
                    Quantity = 20,
                    Discount = 0,
                    Description = "The iMac is a family of all-in-one Macintosh desktop computers designed and built by Apple Inc. It has been the primary part of Apple's consumer desktop offerings since its debut in August 1998, and has evolved through seven distinct forms.",
                    ImageUrl = "https://m.media-amazon.com/images/I/71gqlRrQCuL.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Ak-74",
                    Price = 200,
                    Quantity = 100,
                    Discount = 30,
                    Description = "The AK-74 is an assault rifle developed in the early 1970s by Russian designer Mikhail Kalashnikov as the replacement for the earlier AKM. It uses a smaller 5.45×39mm cartridge, replacing the 7.62×39mm chambering of earlier Kalashnikov-pattern weapons.",
                    ImageUrl = "https://modernfirearms.net/wp-content/uploads/2010/10/ak74-1980-tula.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Skoda Octavia A5FL 2011",
                    Price = 7000,
                    Quantity = 1,
                    Discount = 0,
                    Description = "The Škoda Octavia is a small family car produced by the Czech car manufacturer Škoda Auto since the end of 1996. It shares its name with an earlier Škoda model produced between 1959 and 1971. There have been three generations of the modern-era Octavia model to date, delivered with five-door liftback saloon or five-door estate styles only.",
                    ImageUrl = "https://vag-com-perm.ru/f1d43dc617f7.jpg"
                }
            );
        }
    }
}
