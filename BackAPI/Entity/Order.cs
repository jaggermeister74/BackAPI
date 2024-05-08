namespace BackAPI.Entity
{
    public class Order
    {
        public Order()
        {
            Products = [];
        }
        public Guid OrderId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public string Departure { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Delivery { get; set; }
        public DateTime DeliveryTime { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
