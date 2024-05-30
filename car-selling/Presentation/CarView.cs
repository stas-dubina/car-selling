using CarDealer.Domain;

namespace CarDealer.Presentation
{
    public class CarView
    {
        public Car _car;

        public CarView(Car car)
        {
            this._car = car;
        }

        public int Id { get { return _car.Id; } }

        // car model properies
        public string Brand { get { return _car.Model.Brand.Name; } }
        public string Model { get { return _car.Model.Name; } }
        public FuelType FuelType { get { return _car.Model.FuelType; } }
        public int Power { get { return _car.Model.Power; } }
        public GearType GearType { get { return _car.Model.GearType; } }

        public int Year { get { return _car.Year; } }
        public string Description { get { return _car.Description; } }
        public List<Operation> Tasks { get { return _car.Tasks; } }

        public Car GetCar()
        {
            return _car;
        }
    }
}
