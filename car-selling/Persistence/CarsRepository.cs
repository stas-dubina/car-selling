using CarDealer.Domain;

namespace CarDealer.Persistence;

public class CarsRepository : ICarRespository
{
    private List<Car> _cars;

    public CarsRepository()
    {
        _cars = new List<Car>();
        _cars.Add(new Car(1, "Alfa Romeo Giulia", 2016, FuelType.Gas, "", new List<Operation>()
        {
            new Operation(DateTime.Now, "Покупка авто", -15_000),
            new Operation(DateTime.Now, "Замiна прокладки ГБЦ", -300)
        }));
        _cars.Add(new Car(2, "BMW i3", 2015, FuelType.Hybrid, "", new List<Operation>()
        {
            new Operation(DateTime.Now, "Покупка авто", -25_000)
        }));
        _cars.Add(new Car(3, "Porsche Cayenne", 2017, FuelType.Gas, "", new List<Operation>()
        {
            new Operation(DateTime.Now, "Покупка авто", -35_000)
        }));
        _cars.Add(new Car(4, "Tesla Model S", 2017, FuelType.Electro, "", new List<Operation>()
        {
            new Operation(DateTime.Now, "Покупка авто", -23_000)
        }));
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

    public void Save(Car car)
    {

    }
}