using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookDetails
    {
        private static List<Person> contacts = new List<Person>();
        public static void AddContact()
        {
            Person obj = new Person();

            Console.Write("Enter First Name: ");
            obj.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            obj.LastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            obj.Address = Console.ReadLine();
            Console.Write("Enter City: ");
            obj.City = Console.ReadLine();
            Console.Write("Enter State: ");
            obj.State = Console.ReadLine();
            Console.Write("Enter Zip Code: ");
            obj.ZipCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Email : ");
            obj.Email = Console.ReadLine();
            Console.Write("Enter Phone Number : ");
            obj.PhoneNumber = Convert.ToInt32(Console.ReadLine());

            contacts.Add(obj);

            Console.WriteLine("Successfully Added");
        }

        public static void ViewContact()
        {
            if (contacts.Count > 0)
            {
                Console.WriteLine("Your Contact List is");
                foreach (var x in contacts)
                {
                    PrintValues(x);
                }
            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }
        }
        public static void PrintValues(Person x)
        {
            Console.WriteLine($"First Name : {x.FirstName}");
            Console.WriteLine($"Last Name : {x.LastName}");
            Console.WriteLine($"Address : {x.Address}");
            Console.WriteLine($"City : {x.City}");
            Console.WriteLine($"State : {x.State}");
            Console.WriteLine($"Zip Code: {x.ZipCode}");
            Console.WriteLine($"Phone Number: {x.PhoneNumber}");
            Console.WriteLine($"Email: {x.Email}");

        }
    }
}