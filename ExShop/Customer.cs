using System;
using System.Runtime.InteropServices;

namespace ExShop
{
    public class Customer
    {
        //TODO:
        // weryfikacja uzytkownika
        // tworzenie uzytkownika z konsoli
        // omowienie tworzenia obiektu
        public Customer()
        {
            Id = 1;
            FirstName = "Mracin";
            LastName = "Mjaska";
            Email = "trzydziesci@cali.com";
            Cash = 1000;
        }

        public Customer(int id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Cash = 300;
        }

        public Customer(int id, string firstName, string lastName, string email, double cash)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Cash = cash;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double Cash { get; set; }

        public void Chodzi(string name)
        {
            Console.WriteLine($"{name} idzie do przodu");
        }
    }
}