using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                new Product() { ProductId = 1, CategoryId = 2, ImageUrl = "/img/1.jpg", ProductName = "Computer", Price = 17000, ShowCase = false },
                new Product() { ProductId = 2, CategoryId = 2, ImageUrl = "/img/2.jpg", ProductName = "Keyboard", Price = 1000, ShowCase = false },
                new Product() { ProductId = 3, CategoryId = 2, ImageUrl = "/img/3.jpg", ProductName = "Mouse", Price = 500, ShowCase = false },
                new Product() { ProductId = 4, CategoryId = 2, ImageUrl = "/img/4.jpg", ProductName = "Monitor", Price = 7000, ShowCase = false },
                new Product() { ProductId = 5, CategoryId = 2, ImageUrl = "/img/5.jpg", ProductName = "Deck", Price = 1500, ShowCase = false },
                new Product() { ProductId = 6, CategoryId = 1, ImageUrl = "/img/6.jpg", ProductName = "Suc ve Ceza", Price = 200, ShowCase = false },
                new Product() { ProductId = 7, CategoryId = 1, ImageUrl = "/img/7.jpg", ProductName = "Kizil Isyan", Price = 1000, ShowCase = false },
                new Product() { ProductId = 8, CategoryId = 1, ImageUrl = "/img/8.jpg", ProductName = "Labirent", Price = 1100, ShowCase = true },
                new Product() { ProductId = 9, CategoryId = 2, ImageUrl = "/img/9.jpg", ProductName = "Telefon", Price = 1200, ShowCase = true },
                new Product() { ProductId = 10, CategoryId = 1, ImageUrl = "/img/10.jpg", ProductName = "Oyun Ustasi", Price = 1300, ShowCase = true }
            );
        }
    }
}
