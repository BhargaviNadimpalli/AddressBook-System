using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Program");
            while (true)
            {

                Console.WriteLine("\n1.Add details to Contact list \n2.View details in Contact List\n3.Edit the details\n4.Exit");
                Console.WriteLine("Enter the option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        AddressBookDetails.AddContact();
                        break;
                    case 2:
                        AddressBookDetails.ViewContact();
                        break;
                    case 3:
                        AddressBookDetails.EditDetails();
                        break;
                    case 4:
                        Console.WriteLine("exited");
                        return;

                }

            }
        }
    }
}
