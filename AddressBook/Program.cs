using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact obj = new Contact();
            obj.ContactDetails("Bhargavi", "Nadimpalli", "GolfCity", "Lucknow", "UP", 500252, 938102999, "bhargavinadimpalli@gmail.com");
            obj.Display();

            
        }
    }
}
