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
        public static void EditDetails()
        {
            int a;
            if (contacts.Count > 0)
            {
                Console.Write("Enter the option which you need to edit : ");
                string editName = Console.ReadLine();

                foreach (var x in contacts)
                {
                    if (editName.ToLower() == x.FirstName.ToLower())
                    {
                        while (true)
                        {
                            a = 0;
                            Console.WriteLine("1.First name\n2.Last name\n3.Address\n4.City\n5.State\n6.ZipCode\n7.Phone Number\n8.email\n9.Exit");
                            Console.WriteLine("Enter Option You want to edit");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("Enter New First name");
                                    x.FirstName = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter New Last name");
                                    x.LastName = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 3:
                                    Console.WriteLine("Enter New Address");
                                    x.Address = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 4:
                                    Console.WriteLine("Enter New City");
                                    x.City = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 5:
                                    Console.WriteLine("Enter New State");
                                    x.State = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 6:
                                    Console.WriteLine("Enter New Zip Code");
                                    x.ZipCode = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 7:
                                    Console.Write("Enter new Phone Number: ");
                                    x.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;

                                case 8:
                                    Console.Write("Enter new Email-id: ");
                                    x.Email = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 9:
                                    Console.WriteLine("Exited");
                                    a = 1;
                                    break;

                            }
                            if (a == 1)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entered name is not in Contact list");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your contact list is empty");
            }
        }

    }
}