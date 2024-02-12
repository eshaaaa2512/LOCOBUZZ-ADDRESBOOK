 UC7
﻿using Address_Book_System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Address_Book_System
{
    class Contact
    {
        private string firstname;
        private string lastname;
        private string address;
        private string city;
        private string state;
        private string phonenumber;
        private string zipcode;
        private string email;

        public string Firstname
        {
            get;
            set;
        }
        public string Lastname
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public string State
        {
            get;
            set;
        }
        public string Phonenumber
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Zipcode
        {
            get;
            set;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Contact other = (Contact)obj;
            return Firstname.Equals(other.Firstname, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return Firstname.GetHashCode();
        }
    }
    class AddressBook
    {
        List<Contact> contacts = new List<Contact>();
        public void Add_details()
        {
            Console.WriteLine("Enter the first name: ");
            string firstname = Console.ReadLine();
            if (contacts.Any(c => c.Equals(new Contact { Firstname = firstname })))
            {
                Console.WriteLine($"Duplicate entry for {firstname}. Person already exists in the Address Book.");
                Thread.Sleep(4000);
                Console.Clear();
                return;

 UC6

 UC5
 main
﻿using Address_Book_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Address_Book_System
 UC6
{

    class AddressBook
    {


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
 main
        public string firstname;
        public string lastname;
        public long phonenumber;
        public string email;
 UC6

    }
    class AddressBook : Contact
    {
 main
        public string address;
        public string cityname;
        public string state;
        public long zipcode;

 UC6
        public void Add_details(Dictionary<string, List<AddressBook>> names)
        public void Add_details()

        class Book
 main
        {
            string name;
            do
            {
 UC6
                Console.Write("Enter First Name: ");
                this.firstname = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                this.lastname = Console.ReadLine();

                name = this.firstname + this.lastname;
                if (!names.ContainsKey(name))
                {
                    names.Add(name, new List<AddressBook>());
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("The Name already exist in the Address Book");
                    Thread.Sleep(1000);
                }
            } while (names.ContainsKey(name));

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
                                Console.WriteLine("Enter New First Name : ");
                                contact[i].firstname = Console.ReadLine();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Enter New Last Name : ");
                                contact[i].lastname = Console.ReadLine();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Enter New Phone Number : ");
                                contact[i].phonenumber = Convert.ToInt64(Console.ReadLine());
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Enter New Email : ");
                                contact[i].email = Console.ReadLine();
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Enter New Address : ");
                                contact[i].address = Console.ReadLine();
                                break;
                            case 6:
                                Console.Clear();
                                Console.WriteLine("Enter New City : ");
                                contact[i].cityname = Console.ReadLine();
                                break;
                            case 7:
                                Console.Clear();
                                Console.WriteLine("Enter New State : ");
                                contact[i].state = Console.ReadLine();
                                break;
                            case 8:
                                Console.Clear();
                                Console.WriteLine("Enter New ZipCode : ");
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
                    contact[i].Display_details();
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
                /*if (found == 0)
                {
                    Console.WriteLine($"The contact with the name '{name}' is not found in the contact list.");
                    Thread.Sleep(2000);
                }*/
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            List<AddressBook> list = new List<AddressBook>();
            Dictionary<string, List<AddressBook>> names = new Dictionary<string, List<AddressBook>>();
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
                        address.Add_details(names);
                        list.Add(address);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Display Details\n");
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine(names);
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

                FirstName = fname;
                LastName = lname;
                City = scity;
                State = sstate;
                Number = nnumber;
                Zip = zzip;
                Email = eemail;
                EditedFirstname = efirstname;
main
            }
            Console.WriteLine("Enter the last name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter the address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the city: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the state: ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter the Phone: ");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter the email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter the Zipcode: ");
            string zipcode = Console.ReadLine();

            Contact newCon = new Contact
            {
                Firstname = firstname,
                Lastname = lastname,
                Address = address,
                City = city,
                State = state,
                Phonenumber = phone,
                Email = email,
                Zipcode = zipcode
            };
            contacts.Add(newCon);
            Console.WriteLine("Contact added successfully");
            Thread.Sleep(4000);
            Console.Clear();
        }
 UC7

        public void Display_details()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"First Name: {contact.Firstname}");
                Console.WriteLine($"Last Name: {contact.Lastname}");
                Console.WriteLine($"Address: {contact.Address}");
                Console.WriteLine($"City: {contact.City}");
                Console.WriteLine($"State: {contact.State}");
                Console.WriteLine($"Phone: {contact.Phonenumber}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine($"Zipcode: {contact.Zipcode}");
                Console.WriteLine();
            }
        }
        public void Editted_Contact(string name)
        {
            Contact editContact = contacts.Find(contact => contact.Firstname == name);

            if (editContact != null)
            {
                Console.WriteLine();

                int flag = 0, n;
                do
                {
                    Console.WriteLine("Enter the option to edit : ");
                    Console.WriteLine("1. First Name\n2. Last Name\n3. Phone Number\n4. Email\n5. Address\n6. City\n7. State\n8. ZipCode\n9. Done\n");
                    n = Convert.ToInt32(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Enter New First Name : ");
                            editContact.Firstname = Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Enter New Last Name : ");
                            editContact.Lastname = Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Enter New Phone Number : ");
                            editContact.Phonenumber = Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Enter New Email : ");
                            editContact.Email = Console.ReadLine();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Enter New Address : ");
                            editContact.Address = Console.ReadLine();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("Enter New City : ");
                            editContact.City = Console.ReadLine();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("Enter New State : ");
                            editContact.State = Console.ReadLine();
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("Enter New ZipCode : ");
                            editContact.Zipcode = Console.ReadLine();
                            break;
                        case 9:
                            Console.WriteLine("Edited..");
                            flag = 1;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }

                    Console.Clear();
                    Console.WriteLine();
                } while (flag == 0);
            }
            else
            {
                Console.WriteLine($"The contact with the name '{name}' is not found in the contact list.");
                Thread.Sleep(2000);
            }

        }



        public void Delete(string name)
        {
            Contact deladdbook = contacts.Find(contact => contact.Firstname == name);
            if (deladdbook != null)
            {
                Console.WriteLine($"Are you sure of deleting {name}'s contact (Y/N)");
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'Y' || ch == 'y')
                {
                    contacts.Remove(deladdbook);
                    Console.WriteLine("Contact is Deleted ...");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Contact Not Deleted");
                    Thread.Sleep(2000);
                }
            }
            else
            {
                Console.WriteLine($"The contact with the name '{name}' is not found in the contact list.");
                Thread.Sleep(2000);
            }
        }
    }

    class User
    {
        Dictionary<string, AddressBook> dict = new Dictionary<string, AddressBook>();
        public void AddPerson(string name)
        {
            AddressBook book = new AddressBook();
            if (!dict.ContainsKey(name))
            {
                dict.Add(name, book);
                Console.WriteLine("Person added successfully");
            }
            else
            {
                Console.WriteLine($"{name} already exist");
            }
        }

        public void DisplayPerson()
        {
            foreach (var entry in dict)
            {
                Console.WriteLine(entry.Key);
            }
        }
        public AddressBook getAddressBook(string name)
        {
            return dict[name];
        }
        public Dictionary<string, AddressBook> GetPersons()
        {
            return dict;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            User user = new User();
            int f = 0;
            do
            {
                Console.WriteLine("Enter an Option to perform : ");
                Console.WriteLine("1. Add a person\n2. DisplayPerson\n3. Add person details in address book\n4. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Add the person name");
                        string name = Console.ReadLine();
                        user.AddPerson(name);

                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Display the person name");
                        user.DisplayPerson();
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter the name of the person: ");
                        string personname = Console.ReadLine();
                        int flag = 0;
                        do
                        {
                            if (user.GetPersons().ContainsKey(personname))
                            {
                                AddressBook address = user.getAddressBook(personname);
                                Console.WriteLine("Enter an Option to perform : ");
                                Console.WriteLine("1. Add Details\n2. Display Details\n3. Edit a Contact\n4. Delete a Contact\n5. Exit");
                                int option = Convert.ToInt32(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("Add details:\n");
                                        address.Add_details();
                                        Console.Clear();
                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("Display Details\n");
                                        address.Display_details();
                                        Thread.Sleep(2000);
                                        break;
                                    case 3:
                                        Console.Clear();
                                        Console.WriteLine("Enter name for edit the details\n");
                                        string name1 = Console.ReadLine();
                                        address.Editted_Contact(name1);
                                        break;
                                    case 4:
                                        Console.Clear();
                                        Console.WriteLine("Enter name for deleting the contact\n");
                                        string deleteName = Console.ReadLine();
                                        address.Delete(deleteName);
                                        break;
                                    case 5:
                                        Console.Clear();
                                        Console.WriteLine("Exited");
                                        flag = 1;
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("person is not listed");
                                Thread.Sleep(4000);
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                        } while (flag == 0);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Exited");
                        f = 1;
                        break;
                }
            } while (f == 0);


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
 main
 main
        }
    }
}