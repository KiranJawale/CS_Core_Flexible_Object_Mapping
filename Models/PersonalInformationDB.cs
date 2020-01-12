using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Core_Flexible_Object_Mapping.Models
{
   public class PersonalInfoDBContext :  DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=.;Database=BatchEV;Trusted_Connection=True;");
               // .UseLoggerFactory(new LoggerFactory().AddConsole());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property<string>("Email").HasField("_Email");
            modelBuilder.Entity<Person>()
                .Property<string>("ContactNo").HasField("_ContactNo");
        }
    }
}
