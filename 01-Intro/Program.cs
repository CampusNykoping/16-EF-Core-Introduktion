namespace _01_Intro;
partial class Program
{
    static void Main()
    {
        using (var db=new AddressBookContext())
        {
            WriteToDb(db);
            ReadFromDb(db);
        }
        
        
        Console.Write("Press any key to continue . . . ");
        Console.ReadKey();
    }

    

    static void WriteToDb(AddressBookContext db)
    {
        db.People.Add(new Person() { FirstName = "Claes", LastName = "Engelin" });

        db.SaveChanges();
    }
}