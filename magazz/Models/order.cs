namespace magazz.Models
{
    public class Order //заказ
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int Amount { get; set; }

        public Worker Worker { get; set; }

        public Customer Customer { get; set; }

        public Product Product { get; set; }


    }
}
