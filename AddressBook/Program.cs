using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Program");
            AddressBookDetails obj = new AddressBookDetails();
            while (true)
            {

                Console.WriteLine("\n1.Add details to Contact list \n2.View details in Contact List \n3.Edit details in contact list\n4.Delete details in contact list\n5.Exit");
                Console.WriteLine("Enter the option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        obj.AddContact();
                        break;
                    case 2:
                        obj.ViewContact();
                        break;
                    case 3:
                        obj.EditDetails();
                        break;
                    case 4:
                        obj.DeleteDetails();
                        break;
                    case 5:
                        Console.WriteLine("Exited");
                        return;

                }

            }
        }
    }
}
