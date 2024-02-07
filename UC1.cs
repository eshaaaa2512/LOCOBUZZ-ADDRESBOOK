using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Contacts
    {
        private string First_Name;
        private string Last_Name;
        private string Address;
        private string City;
        private string state;
        private string PostalCode;
        private string phoneNumber;
        private string Email;

    }
    class AddressBook
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
    class UC2
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome AddressBook");
            
            Console.WriteLine("Enter the First_Name: ");
            AddressBook contact = new AddressBook();
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the Last_Name: ");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter the Address: ");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter the City: ");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter the State: ");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter the PostalCode: ");
            contact.PostalCode = Console.ReadLine();

            Console.WriteLine("Enter the PhoneNumber: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter the Email: ");
            contact.Email = Console.ReadLine();
        }
        
        
        
        
    }

}
            



        
       

        
    
  




        



    
    







