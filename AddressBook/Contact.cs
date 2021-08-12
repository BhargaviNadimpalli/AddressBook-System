using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookDetails
    {
        private List<Person> contacts;
        //address book dictioanry to store values
        private static Dictionary<string, List<Person>> addressBookDictionary = new Dictionary<string, List<Person>>();
        public void AddContact()
        {
            string addressBookName;
            contacts = new List<Person>();
            while (true)
            {
                Console.WriteLine("Enter The Name of the Address Book");
                addressBookName = Console.ReadLine();
                //Checking uniqueness of address books
                if (addressBookDictionary.Count > 0)
                {
                    if (addressBookDictionary.ContainsKey(addressBookName))
                    {
                        Console.WriteLine("This name of address book already exists");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }

            }

            Console.Write("Enter Number of contacts you want to add:");
            int numOfContacts = Convert.ToInt32(Console.ReadLine());
            while (numOfContacts > 0)
            {
                //object for person class
                Person person = new Person();

                Console.Write("Enter First Name: ");
                person.FirstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();
                Console.Write("Enter Address: ");
                person.Address = Console.ReadLine();
                Console.Write("Enter City: ");
                person.City = Console.ReadLine();
                Console.Write("Enter State: ");
                person.State = Console.ReadLine();
                Console.Write("Enter Zip Code: ");
                person.ZipCode = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Phone Number: ");
                double PhoneNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Email-id: ");
                string Email = Console.ReadLine();
                contacts.Add(person);
                Console.WriteLine("----------------------------------");
                numOfContacts--;
            }
            //adding into address book dictionary
            addressBookDictionary.Add(addressBookName, contacts);
            Console.WriteLine("\t \t \tSuccessfully Added");
        }


        public void ViewContact()
        {
                if (addressBookDictionary.Count > 0)
                {
                    foreach (KeyValuePair<string, List<Person>> dict in addressBookDictionary)
                    {
                        Console.WriteLine($"\t \t \t{dict.Key}");
                        foreach (var addressBook in dict.Value)
                        {
                            PrintValues(addressBook);
                        Console.WriteLine("-----------------------\n");
                    }
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
        public void EditDetails()
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
        public void DeleteDetails()
        {
            int a = 0;
            if (contacts.Count > 0)
            {
                Console.Write("Enter name of a person you want to Delete: ");
                string deleteName = Console.ReadLine();

                foreach (var x in contacts)
                {
                    if (deleteName.ToLower() == x.FirstName.ToLower())
                    {
                        
                        Console.WriteLine("\t \t \tDELETED");
                        Console.WriteLine($"You have deleted {x.FirstName} contact");
                        contacts.Remove(x);
                        a = 1;
                        break;
                    }
                }
                if (a == 0)
                {
                    Console.WriteLine("The name you entered is not in address book");
                }
            }
            else
            {
                Console.WriteLine("Your contact list is empty");
            }
        }
    }

}