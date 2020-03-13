using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_JMarshall_ProgrammingChallenge1.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, categoryName = "family" },
                new Category { CategoryID = 2, categoryName = "friend" },
                new Category { CategoryID = 3, categoryName = "Work" },
                new Category { CategoryID = 4, categoryName = "N/A" }
            );

            modelBuilder.Entity<Contact>().HasData(
                new Contact { contactID = 1, firstName = "James", lastName = "marshall", phone = "720-965-1983", email = "james_marshall48@aol.com", CategoryID = 2, dateAdded = DateTime.Today, organization = "NONE" },
                 new Contact { contactID = 2, firstName = "Philip", lastName = "marshall", phone = "720-965-2248", email = "philip.marshall123456789@gmail.com", CategoryID = 1, dateAdded = DateTime.Today, organization = "Cresco" },
                  new Contact { contactID = 3, firstName = "Sarah", lastName = "marshall", phone = "720-965-1111", email = "sarah.carpenteyro@gmail.com", CategoryID = 1, dateAdded = DateTime.Now });
        }
    }
}

