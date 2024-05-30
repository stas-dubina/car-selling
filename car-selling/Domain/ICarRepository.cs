namespace CarDealer.Domain
{
    public interface ICarRepository
    {
        void Add(Car car);
        void Save(Car car);
        List<Car> GetAll();
        List<Car> Search(int ?brandId, int ?modelId, int yearStart, int yearEnd, FuelType? type);
    }
}
