namespace CarDealer.Domain
{
    public interface ICarRepository
    {
        void Add(Car car);
        void Save(Car car);
        void RemoveOperation(Car car, Operation task);
        void AddOperation(Car car, Operation task);
        List<Car> GetAll();
        List<Car> Search(int? brandId, int? modelId, int yearStart, int yearEnd, FuelType? type);
        int GetBalance();
    }
}
