using Smart_car_dealership_management_system.Models.YourNamespace.Models;

namespace Smart_car_dealership_management_system.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateOfSale { get; set; }
        public decimal PriceSold { get; set; }

        public Car Car { get; set; }
        public Customer Customer { get; set; }
    }
}

