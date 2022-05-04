using System.ComponentModel.DataAnnotations;

namespace VehicleCollection_Backend
{
    public class Vehicle
    {
        [Key]
        public string VIN { get; set; } 
        public string LicensePlate { get; set; }
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public string FuelType { get; set; }
        public string Color { get; set; }
    }
}
