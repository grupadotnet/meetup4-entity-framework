using System;
using System.Collections.Generic;

namespace ExShop
{
    public static class Basket
    {
        static Basket()
        {
            ItemsInBasket = 0;
            TotalPrice = 0;
            SelectedItems = new List<Item>();
        }
        // asdsafas
        public static int ItemsInBasket { get; set; }
        public static List<Item> SelectedItems { get; set; }
        public static double TotalPrice { get; set; }


        public static void AddItemToBasket(Item item)
        {
            Console.Clear();
            SelectedItems.Add(item);
            Console.WriteLine(item.Name + " dodany do koszyka");
        }

        public static void ShowItemsInBasket()
        {
            Console.Clear();
            foreach (var selectedItem in SelectedItems)
            {
                Console.WriteLine(selectedItem.Name);
            }
        }

        public static void Buy(double availableCash)
        {
            foreach (var item in SelectedItems)
            {
                TotalPrice += item.Price;
            }

            //TODO:
            // tu wiecej scenariuszy, zadania dla grup
            if (availableCash >= TotalPrice)
            {
                Console.Clear();
                Console.WriteLine("Wysylka w dordze");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Nie stac cie biedaku");
            }
        }
    }
}