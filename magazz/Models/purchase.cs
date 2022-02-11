namespace magazz.Models
{
    public class purchase //закупка
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int storageId { get; set; }
        public int count { get; set; }
        public int amount { get; set; }

    }
}
