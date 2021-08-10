using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Contact
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int Zip;
        public int Phone_Number;
        public string Email;
        public void ContactDetails(string FirstName, string LastName, string Address, string City, string State, int Zip, int Phone_Number, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address; ;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.Phone_Number = Phone_Number;
            this.Email = Email;
        }
        public void Display()
        {

            Console.WriteLine("First Name : " + this.FirstName);
            Console.WriteLine("Last Name : "+ this.LastName);
            Console.WriteLine("Address : "+ this.Address);
            Console.WriteLine("City : "+ this.City);
            Console.WriteLine("State : "+ this.State);
            Console.WriteLine("Zip Code : "+ this.Zip);
            Console.WriteLine("Phone Number : "+ this.Phone_Number);
            Console.WriteLine("Email Id : "+ this.Email);
        }
    }
}
