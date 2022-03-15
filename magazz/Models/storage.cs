namespace magazz.Models
{
    public class Storage //склад
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }

        public Purchase Purchase { get; set; }
    }
}
