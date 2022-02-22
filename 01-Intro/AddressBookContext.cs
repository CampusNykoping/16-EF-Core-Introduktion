using Microsoft.EntityFrameworkCore;

namespace _01_Intro
{
    public class AddressBookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("AddressBook");
        }

        public DbSet<Person> People { get; set; }

    }
}
