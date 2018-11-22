using System;
using System.Linq;

namespace ExShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: 
            // petle
            // tworzenie instancji
            // tworzenie i wywolywanie metod
            // logika calego programu
            // troche cleancode'u i porzadkow

            //TODO:
            // scenariusz dla klienta
            // weryfikacja klienta
            // wchodzi do wybranego sklepu, albo wychodzi z menu
            // wybiera przedmioty
            // wybiera czy chce kupic czy anulowac
            // placi i dostaje info o realizacji zamowienia
            // oproznianie koszyka
            // wycofywanie elementow z koszyka

            var arek = new Customer(2, "Arek", "Klis", "arek9513@gmail.com");
            var biedak = new Customer(3, "Pan", "Zul", "brak", 5.5);
            var mracin = new Customer();

            biedak.Chodzi(biedak.LastName);
            // tworzenie przedmiotow
            var maczuga = new Item();
            maczuga.Id = 1;
            maczuga.Name = "Kolecx20";
            maczuga.Price = 50;

            using (var db = new ShopDbContext())
            {
                db.Items.Add(maczuga);
                db.SaveChanges();
            }

            using (var db = new ShopDbContext())
            {
                var item = db.Items.Where(x => x.Name == "Kolecx20");
            }


                var dildo = new Item
                {
                    Id = 2,
                    Name = "Smooth",
                    Price = 100
                };

            // dodawanie przedmiotow do listy
            var itemsList = new Item[]
            {
                maczuga,
                dildo
            };

            // utworzenie sklepu i koszyka
            var biedronka = new Shop(1, "Biedronka", itemsList);

            bool repeat = true;
            do
            {
                Console.WriteLine("Welcome in " + biedronka.Name);
                Console.WriteLine("Select your item:");
                Console.WriteLine("----------------------");
                for (int i = 0; i < biedronka.Items.Length; i++)
                {
                    Console.WriteLine( i + 1 + ". " + biedronka.Items[i].Name);
                }
                Console.WriteLine("----------------------");
                Console.WriteLine("3. Buy items");
                Console.WriteLine("4. Show items in basket");
                Console.WriteLine("5. Exit");
                string customerChoice = Console.ReadLine();

                switch (customerChoice)
                {
                    case "1":
                        Basket.AddItemToBasket(biedronka.Items[0]);
                        break;
                    case "2":
                        Basket.AddItemToBasket(biedronka.Items[1]);
                        break;
                    case "3":
                        Basket.Buy(arek.Cash);
                        break;
                    case "4":
                        Basket.ShowItemsInBasket();
                        Console.WriteLine();
                        break;
                    case "5":
                        Console.WriteLine("Good bye!");
                        repeat = false;
                        break;
                }
            } while (repeat);

        }
    }
}
