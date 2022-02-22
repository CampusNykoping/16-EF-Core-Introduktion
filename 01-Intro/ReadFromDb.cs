using System.Linq;

namespace _01_Intro;

partial class Program
{
    static void ReadFromDb(AddressBookContext db)
    {
        var persons = db.People
            .Where(p => p.FirstName.StartsWith("C")).ToList();

        foreach (var person in persons)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }
    }
}
