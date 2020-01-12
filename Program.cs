using System;
using CS_Core_Flexible_Object_Mapping.Models;
using Microsoft.EntityFrameworkCore;

namespace CS_Core_Flexible_Object_Mapping
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            try
            {
                ManageDatabse();
                var person = new Person
                {
                    FisrtName = "Mahesh",
                    MiddleName = "Ramesh",
                    LastName = "Sabnis",
                    Address = "Bavdhan-Pune"
                };
                person.SetEmail("Kiran@gmail.com");
                person.SetContactNo("9970758776");

                var DB = new PersonalInfoDBContext();
                DB.Persons.Add(person);
                DB.SaveChanges();
                var persons = DB.Persons.ToListAsync().Result;
                foreach (var item in persons)
                {
                    Console.WriteLine($" Person Details {item.FisrtName} {item.MiddleName} {item.LastName} {item.Address} {item.GetEmail()} {item.GetContact()}");
                }
            }
            catch (Exception ex)
            {

                // throw;
                Console.WriteLine("Error"+ex.Message);
            }
            Console.ReadLine();
        }

        static void ManageDatabse()
        {
            using (var ctx = new PersonalInfoDBContext())
            {
                ctx.Database.EnsureDeleted();
                ctx.Database.EnsureCreated();
            }
        }
    }
}
