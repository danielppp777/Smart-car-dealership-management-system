namespace Smart_car_dealership_management_system.Models
{
    namespace YourNamespace.Models
    {
        public class Car
        {
            public int Id { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public decimal Price { get; set; }
            public string Condition { get; set; } // нов или употребяван
            public int Mileage { get; set; }
            public DateTime DateAdded { get; set; }
        }
    }
}
