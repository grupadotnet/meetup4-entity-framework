namespace ExShop
{
    public class Shop
    {
        public Shop(int id, string name, Item[] items)
        {
            Id = id;
            Name = name;
            Items = items;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Item[] Items { get; set; }
    }
}