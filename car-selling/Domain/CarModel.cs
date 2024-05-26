using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Domain
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public FuelType FuelType { get; set; }
        public int Power { get; set; }
        public GearType GearType { get; set; }
    }
}
