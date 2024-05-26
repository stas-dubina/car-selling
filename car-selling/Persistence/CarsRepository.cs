using CarDealer.Domain;

namespace CarDealer.Persistence;

public class CarsRepository : ICarRespository
{
    private List<Car> _cars;

    public CarsRepository()
    {
        var model = new CarModel()
        {
            Id = 1,
            Brand = "Toyota",
            Model = "Corolla",
            Power = 100,
            FuelType = FuelType.Gas,
            GearType = GearType.Manual            
        };

        _cars = new List<Car>();
        _cars.Add(new Car(1, model, 2016, "", new List<Operation>()
        {
            new Operation(DateTime.Now, "Покупка авто", -15_000),
            new Operation(DateTime.Now, "Замiна прокладки ГБЦ", -300)
        }));
        _cars.Add(new Car(2, model, 2015, "", new List<Operation>()
        {
            new Operation(DateTime.Now, "Покупка авто", -25_000)
        }));
        _cars.Add(new Car(3, model, 2017, "", new List<Operation>()
        {
            new Operation(DateTime.Now, "Покупка авто", -35_000)
        }));
        _cars.Add(new Car(4, model, 2017, "", new List<Operation>()
        {
            new Operation(DateTime.Now, "Покупка авто", -23_000)
        }));
    }
    public List<Car> Search(string name, int yearStart, int yearEnd, FuelType? type)
    {
        return _cars;
           /* .FindAll(
            car => car.Name.ToLower().Contains(name.ToLower())
            && car.Year >= yearStart && car.Year <= yearEnd
            && (type == null || car.Type == type));
           */
    }

    public List<Car> GetAll()
    {
        return this._cars;
    }

    public void Save(Car car)
    {

    }
}