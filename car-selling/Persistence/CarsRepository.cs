using CarDealer.Domain;

namespace CarDealer.Persistence;

public class CarsRepository : ICarRespository
{
    private List<Car> _cars;

    public CarsRepository()
    {
        _cars = new List<Car>();
        _cars.Add(new Car(1, "Alfa Romeo Giulia", 2016, FuelType.Gas, ""));
        _cars.Add(new Car(2, "BMW i3", 2015, FuelType.Hybrid, ""));
        _cars.Add(new Car(3, "Porsche Cayenne", 2017, FuelType.Gas, ""));
        _cars.Add(new Car(4, "Tesla Model S", 2017, FuelType.Electro, ""));
    }
    public List<Car> Search(string name, int yearStart, int yearEnd, FuelType? type)
    {
        return _cars.FindAll(
            car => car.Name.ToLower().Contains(name.ToLower())
            && car.Year >= yearStart && car.Year <= yearEnd
            && (type == null || car.Type == type));
    }

    public List<Car> GetAll()
    {
        return this._cars;
    }
}