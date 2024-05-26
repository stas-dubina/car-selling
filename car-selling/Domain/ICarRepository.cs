namespace CarDealer.Domain
{
    public interface ICarRespository
    {
        void Save(Car car);
        List<Car> GetAll();
        List<Car> Search(string name, int yearStart, int yearEnd, FuelType? type);
    }
}
