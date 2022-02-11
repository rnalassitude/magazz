namespace magazz.Models
{
    public class order //заказ
    {
        public int id { get; set; }
        public int workerId { get; set; }
        public int productId { get; set; }
        public int customerId { get; set; }
        public int amount { get; set; }


    }
}
