namespace Lab5.Models
{
    public class Subscription
    {
        // Foreign Keys
        public int CustomerId { get; set; }
        public string ServiceId { get; set; }

        // Navigation properties
        public Customer Customer { get; set; }
        public FoodDeliveryService FoodDeliveryService { get; set; }
    }
}