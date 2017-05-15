using Microsoft.EntityFrameworkCore;
using SingersWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SingersWebApi
{
    public class ListsContext: DbContext
    {
        public ListsContext(DbContextOptions<ListsContext> options)
            : base(options)
        {
        }

        public DbSet<List> Lists { get; set; }

        public DbSet<Singer> Singers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<List>()
                .Property(l => l.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Singer>()
                .Property(l => l.Id)
                .ValueGeneratedOnAdd();
        }

        public static void SeedTestData(ListsContext context)
        {
            var lists = new List[]
            {
                new List
                {
                    Name = "Good Songs",
                    Order = 1,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    FirstName = "Michael",
                    LastName = "Jackson",
                    BirthDate = "1958-08-29",
                    IsAlive = false
                },
                new List
                {
                    Name = "Bad Songs",
                    Order = 2,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    FirstName = "Mikhail",
                    LastName = "Shufutinski",
                    BirthDate = "1948-04-13",
                    IsAlive = true
                },
                new List
                {
                    Name = "Pop Songs",
                    Order = 3,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    FirstName = "Taylor",
                    LastName = "Swift",
                    BirthDate = "1989-12-13",
                    IsAlive = false
                },
            };
            context.Lists.AddRange(lists);

            context.SaveChanges();
        }

    }
}
