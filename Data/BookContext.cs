using CS321_W3D1_BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CS321_W3D1_BookAPI.Data
{
    public class BookContext : DbContext
    {
        DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder myBuilder)
        {
            myBuilder.UseSqlite("Data Source=Books.db");
        }

        protected override void OnModelCreating(ModelBuilder myModelBuilder)
        {
            base.OnModelCreating(myModelBuilder);

            myModelBuilder.Entity<Book>().HasData(
                new Book { Title = "Lord of the Rings", Author="Tolkien", Category="Fantasy"},
                new Book { Title = "Super Powered year 1", Author="Drew Hayes", Category="Superheroes"},
                new Book { Title = "Pride and Prejudice", Author = "Jane Austin", Category= "Satirer"}
                );
        }
    }
}
