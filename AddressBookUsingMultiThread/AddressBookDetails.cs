﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookUsingMultiThread
{
    class AddressBookDetails
    {
        public static List<Person> contacts = new List<Person>();

        public static void AddContact()
        {
            Person person = new Person();

            Console.WriteLine("Enter First name: ");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last name: ");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            person.address = Console.ReadLine();
            Console.WriteLine("Enter City: ");
            person.city = Console.ReadLine();
            Console.WriteLine("Enter State: ");
            person.state = Console.ReadLine();
            Console.WriteLine("Enter Zipcode: ");
            person.zip = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Enter Phone Number: ");
                string phoneNumber = Console.ReadLine();
                if (phoneNumber.Length == 10)
                {
                    person.phoneNumber = phoneNumber;
                    break;
                }
                else
                {
                    Console.WriteLine("Phone Number Invalid! Phone number should have 10 digits!");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter EmailId: ");
                string email = Console.ReadLine();
                if (email.Contains("@"))
                {
                    person.emailId = email;
                    break;
                }
                else
                {
                    Console.WriteLine("Emailid Should Contain @ ");
                }
            }
            contacts.Add(person);
            Console.WriteLine("Successfully Added!");
        }

        public static void ViewConatcts()
        {
            if (contacts.Count > 0)
            {
                Console.WriteLine("*****Yours Contact List*****");
                foreach (var member in contacts)
                {
                    PrintValues(member);
                    Console.WriteLine("==================================");
                }
            }
            else
            {
                Console.WriteLine("Your AddressBook is Empty!");
            }
        }

        public static void PrintValues(Person person)
        {
            Console.WriteLine($"First Name:   {person.firstName}");
            Console.WriteLine($"Last Name :   {person.lastName}");
            Console.WriteLine($"Address   :   {person.address}");
            Console.WriteLine($"City      :   {person.city}");
            Console.WriteLine($"State     :   {person.state}");
            Console.WriteLine($"Zip Code  :   {person.zip}");
            Console.WriteLine($"Phone Number: {person.phoneNumber}");
            Console.WriteLine($"Email Id  :   {person.emailId}");
        }
    }
}
