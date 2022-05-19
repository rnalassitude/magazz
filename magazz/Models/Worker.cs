namespace magazz.Models
{
    public class Worker //работники
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int PostId { get; set; }

        public Post Post { get; set; }

        public Order Order { get; set; }
    }
}
