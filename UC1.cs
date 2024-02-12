 UC5
﻿using Address_Book_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Address_Book_System

﻿using System;
 UC4
using System.Collections.Generic;
 UC3
 main
namespace AddressBook
 main
{
    class Contact
    {
 UC5
        public string firstname;
        public string lastname;
        public long phonenumber;
        public string email;
    }
    class AddressBook : Contact
    {
        public string address;
        public string cityname;
        public string state;
        public long zipcode;

        public void Add_details()

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
 main
        {
            Console.Write("Enter First Name: ");
            this.firstname = Console.ReadLine();

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
            this.lastname = Console.ReadLine();

            Console.Write("Enter Address: ");
            this.address = Console.ReadLine();

            Console.Write("Enter City: ");
            this.cityname = Console.ReadLine();

            Console.Write("Enter State: ");
            this.state = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            this.phonenumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter Zip Code: ");
            this.zipcode = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter Email: ");
            this.email = Console.ReadLine();
        }

 UC5
        public void Display_details()
        {
            Console.WriteLine($"First Name : {this.firstname}");
            Console.WriteLine($"Last Name : {this.lastname}");
            Console.WriteLine($"Phone Number : {this.phonenumber}");
            Console.WriteLine($"Email : {this.email}");
            Console.WriteLine($"Address : {this.address}");
            Console.WriteLine($"City : {this.cityname}");
            Console.WriteLine($"State : {this.state}");
            Console.WriteLine($"ZipCode : {this.zipcode}");
        }
        public void Editted_Contact(List<AddressBook> contact, string name)
        {
            int flag = 0, n, found = 0;
            for (int i = 0; i < contact.Count; i++)
            {
                if (contact[i].firstname == name)
                {
                    found = 1;
                    contact[i].Display_details();
                    Console.WriteLine();
                    do
                    {
                        Console.WriteLine("Enter the option to edit : ");
                        Console.WriteLine("1. First Name\n2. Last Name\n3. Phone Number\n4. Email\n5. Address\n6. City\n7. State\n8. ZipCode\n9. Done\n");
                        n = Convert.ToInt32(Console.ReadLine());
                        switch (n)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Enter the New First Name : ");
                                contact[i].firstname = Console.ReadLine();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Enter the New Last Name : ");
                                contact[i].lastname = Console.ReadLine();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Enter the New Phone Number : ");
                                contact[i].phonenumber = Convert.ToInt64(Console.ReadLine());
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Enter the New Email : ");
                                contact[i].email = Console.ReadLine();
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Enter the New Address : ");
                                contact[i].address = Console.ReadLine();
                                break;
                            case 6:
                                Console.Clear();
                                Console.WriteLine("Enter the New City : ");
                                contact[i].cityname = Console.ReadLine();
                                break;
                            case 7:
                                Console.Clear();
                                Console.WriteLine("Enter the New State : ");
                                contact[i].state = Console.ReadLine();
                                break;
                            case 8:
                                Console.Clear();
                                Console.WriteLine("Enter the New ZipCode : ");
                                contact[i].zipcode = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 9:
                                Console.WriteLine("Edited..");
                                flag = 1;
                                break;
                        }
                        Console.Clear();
                        Console.WriteLine();
                    } while (flag == 0);

                }
            }
            if (found == 0)
            {
                Console.WriteLine("The Given Name is not there in the contact list");
                Thread.Sleep(2000);
            }
        }



        public void Delete(List<AddressBook> contact, string name)
        {
            int found = 0;
            for (int i = 0; i < contact.Count; i++)
            {
                if (contact[i].firstname == name)
                {
                    found = 1;
                    Console.WriteLine($"Are you sure of deleteing {name}\'s contact (Y/N)");
                    char ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'Y' || ch == 'y')
                    {
                        contact.Remove(contact[i]);
                        Console.WriteLine("Contact is Deleted ...");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("Contact Not Deleted");
                        Thread.Sleep(2000);
                    }
                }
                if (found == 0)
                {
                    Console.WriteLine($"The contact with the name '{name}' is not found in the contact list.");
                    Thread.Sleep(2000);
                }
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            List<AddressBook> list = new List<AddressBook>();
            AddressBook obj1 = new AddressBook();
            int flag = 0;
            do
            {
                Console.WriteLine("Enter an Option to perform : ");
                Console.WriteLine("1. Add Details\n2. Display Details\n3. Edit a Contact\n4. Delete a Contact\n5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Add details:\n");
                        AddressBook address = new AddressBook();
                        address.Add_details();
                        list.Add(address);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Display Details\n");
                        for (int i = 0; i < list.Count; i++)
                        {
                            list[i].Display_details();
                            Console.WriteLine();
                        }
                        Thread.Sleep(2000);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter name for edit the details\n");
                        string name = Console.ReadLine();
                        obj1.Editted_Contact(list, name);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Enter name for deleting the contact\n");
                        string deleteName = Console.ReadLine();
                        obj1.Delete(list, deleteName);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Exited");
                        flag = 1;
                        break;
                }
                Console.Clear();
            } while (flag == 0);

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
main
        }
    }
}