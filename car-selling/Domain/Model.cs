using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Domain
{
    public class Model
    {
        public int Id { get; set; }
        public Brand Brand { get; set; }
        public string Name { get; set; }
        public FuelType FuelType { get; set; }
        public int Power { get; set; }
        public GearType GearType { get; set; }
    }
}
