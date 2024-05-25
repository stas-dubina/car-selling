namespace CarDealer.Domain
{
    public interface ICarRespository
    {
        List<Car> GetAll();
        List<Car> Search(string name, int yearStart, int yearEnd, FuelType? type);
    }
}
