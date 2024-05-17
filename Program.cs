using System;
using Microsoft.EntityFrameworkCore;
using MyContactApp.Data;
using MyContactApp.Models;
using MyContactApp.Services;

namespace MyContactApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Contact App!");
            Console.WriteLine();


            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Add a new contact");
                Console.WriteLine("2. Retrieve saved contacts");
                Console.WriteLine("3. Exit");
                Console.WriteLine();

                string choice = Console.ReadLine() ?? string.Empty;

                switch (choice)
                {
                    case "1":
                        AddNewContact();
                        break;
                    case "2":
                        RetrieveContacts();
                        break;
                    case "3":
                        Console.WriteLine("Thank you for using My Contact App. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddNewContact()
        {
            Console.WriteLine();

            Console.WriteLine("Enter the contact's name:");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty. Please enter a valid name.");
                return;
            }

            Console.WriteLine("Enter the contact's email (optional):");
            string email = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter the contact's phone number (optional):");
            string phone = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter the contact's cell phone number (optional):");
            string cellPhone = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter the contact's type (e.g. Personal, Professional):");
            string type = Console.ReadLine();

            if (type != "Personal" && type != "Professional")
            {
                Console.WriteLine("Type must be either 'Personal' or 'Professional'. Please enter a valid type.");
                return;
            }

            Contact newContact = new()
            {
                Name = name,
                Email = email,
                Phone = phone,
                CellPhone = cellPhone,
                Type = type
            };

            ContactContext contactContext = new();
            ContactService contactService = new(contactContext);
            contactService.AddContact(newContact);

            Console.WriteLine();
            Console.WriteLine("Contact added successfully! {0}\n\n", newContact.ToString());
        }

        static void RetrieveContacts()
        {
            Console.WriteLine();
            ContactContext contactContext = new();
            ContactService contactService = new(contactContext);
            var contacts = contactService.GetContacts();

            foreach (var contact in contacts)
            {
                Console.WriteLine($"ID: {contact.Id}");
                Console.WriteLine($"Name: {contact.Name}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine($"Phone: {contact.Phone}");
                Console.WriteLine($"CellPhone: {contact.CellPhone}");
                Console.WriteLine($"Type: {contact.Type}");
                Console.WriteLine();
            }
        }
    }
}