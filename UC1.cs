using System;
 UC4
using System.Collections.Generic;
 UC3
 main
namespace AddressBook
{
    internal class Program
    {
        class Book
        {
            public string FirstName;
            public string LastName;
            public string City;
            public string State;
            public long Number;
            public int Zip;
            public string Email;
            public string EditedFirstname;
            public Book(string fname, string lname, string scity, string sstate, long nnumber, int zzip, string eemail, string efirstname)
            {
                FirstName = fname;
                LastName = lname;
                City = scity;
                State = sstate;
                Number = nnumber;
                Zip = zzip;
                Email = eemail;
                EditedFirstname = efirstname;
            }
        }

        static List<Book> addressBook = new List<Book>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book");

            AddPerson();


            DisplayAddressBook();


            Console.Write("Enter the Edited First Name to delete: ");
            string deleteEditedFirstName = Console.ReadLine();
            DeletePersonByEditedFirstName(deleteEditedFirstName);


            DisplayAddressBook();

            Console.ReadLine();
        }

        static void AddPerson()
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

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
            



        
       

        
    
  



 main

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Zip Code: ");
            int zip = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Phone Number: ");
            long number = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            Console.Write("Enter State: ");
            string state = Console.ReadLine();

            Console.Write("Enter Edited first Name: ");
            string editedFirstName = Console.ReadLine();

            Book myBook = new Book(firstName, lastName, city, state, number, zip, email, editedFirstName);

            addressBook.Add(myBook);

            Console.WriteLine("\nDetails entered:");
            Console.WriteLine($"First Name: {myBook.EditedFirstname}");
            Console.WriteLine($"Last Name: {myBook.LastName}");
            Console.WriteLine($"Email: {myBook.Email}");
            Console.WriteLine($"Zip Code: {myBook.Zip}");
            Console.WriteLine($"Phone Number: {myBook.Number}");
            Console.WriteLine($"City: {myBook.City}");
            Console.WriteLine($"State: {myBook.State}");
        }

        static void DeletePersonByEditedFirstName(string editedFirstName)
        {
            Book personToDelete = addressBook.Find(person => person.EditedFirstname.Equals(editedFirstName, StringComparison.OrdinalIgnoreCase));

            if (personToDelete != null)
            {
                addressBook.Remove(personToDelete);
                Console.WriteLine($"Person with Edited First Name '{editedFirstName}' deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Person with Edited First Name '{editedFirstName}' not found in the address book.");
            }
        }

        static void DisplayAddressBook()
        {
            Console.WriteLine("\nAddress Book:");

            foreach (var person in addressBook)
            {
                Console.WriteLine($"First Name: {person.EditedFirstname}");
                Console.WriteLine($"Last Name: {person.LastName}");
                Console.WriteLine($"Email: {person.Email}");
                Console.WriteLine($"Zip Code: {person.Zip}");
                Console.WriteLine($"Phone Number: {person.Number}");
                Console.WriteLine($"City: {person.City}");
                Console.WriteLine($"State: {person.State}");
                Console.WriteLine();
            }
        }
    }
}