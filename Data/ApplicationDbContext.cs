using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using iBookStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace iBookStore.Data
{
    public class ApplicationDbContext : IdentityDbContext<DefaultUser>
    {
        //internal object CartItems;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
            new Book
             {
              Id = 1,  
              Title = "Crack the coding Interview",
              Description =" Test Description",
              Language = "English",
              ISBN = "0984782869",
              DatePublished = DateTime.Parse("2022-9-26"),
              Price = 139,
              Author = "Gayle Laakmann McDowell",
              ImageUrl = "/images/coding.jpg"},



                    new Book
                    {
                        Id = 2,
                        Title = "Python Coding",
                        Description =" Test Description",
                        Language = "English",
                        ISBN = "0984782862",
                        DatePublished = DateTime.Parse("2021-9-26"),
                        Price = 139,
                        Author = "Imran Al Munyeem",
                        ImageUrl = "/images/python.jpg"
                    },

                    new Book
                    {
                        Id = 3,
                        Title = "MVC Dot net core",
                        Description = " Test Description",
                        Language = "English",
                        ISBN = "0984782861",
                        DatePublished = DateTime.Parse("2020-9-26"),
                        Price = 139,
                        Author = "Mahmoud Artemi",
                        ImageUrl = "/images/netcore.jpg"
                    },

                    new Book
                    {
                        Id = 4,
                        Title = "Advance JavaScript",
                        Description = " Test Description",
                        Language = "English",
                        ISBN = "0984782862",
                        DatePublished = DateTime.Parse("2021-9-26"),
                        Price = 139,
                        Author = "Imran Al Munyeem",
                        ImageUrl = "/images/javascript.jpg"
                    },

                    new Book
                    {
                        Id = 5,
                        Title = "API Testing",
                        Description = " Test Description",
                        Language = "English",
                        ISBN = "0984782863",
                        DatePublished = DateTime.Parse("2022-9-26"),
                        Price = 139,
                        Author = "Imran Al Munyeem",
                        ImageUrl = "/images/apitest.jpg"
                    },

                    new Book
                    {
                        Id = 6,
                        Title = "Automate Everything",
                        Description = " Test Description",
                        Language = "English",
                        ISBN = "0984782864",
                        DatePublished = DateTime.Parse("2021-9-26"),
                        Price = 139,
                        Author = "Imran Al Munyeem",
                        ImageUrl = "/images/automation.jpg"
                    },

                    new Book
                    {
                        Id = 7,
                        Title = "Design Pattern",
                        Description = " Test Description",
                        Language = "English",
                        ISBN = "0984782865",
                        DatePublished = DateTime.Parse("2020-9-26"),
                        Price = 139,
                        Author = "Mahmoud Artemi",
                        ImageUrl = "/images/pattern.jpg"
                    }
                );


            
        }
    }
}







