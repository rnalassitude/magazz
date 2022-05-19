namespace magazz.Models
{
    public class Product //товары
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Order Order { get; set; }

        public Purchase Purchase { get; set; }
    }
}
