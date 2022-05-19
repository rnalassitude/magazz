namespace magazz.Models
{
    public class Purchase //закупка
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int StorageId { get; set; }
        public int Count { get; set; }
        public int Amount { get; set; }

        public Product Product { get; set; }

        public Storage Storage { get; set; }

    }
}
