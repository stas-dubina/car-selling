using CarDealer.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Persistence
{
    internal class CarDbRepository : ICarRepository
    {
        private StorageDbContext _db;

        public CarDbRepository(StorageDbContext storageDbContext)
        {
            _db = storageDbContext;
        }

        public List<Car> GetAll()
        {
            return _db.Cars
                .Include(c => c.Model)
                .Include(c => c.Tasks)
                .ToList();
        }

        public void Add(Car car)
        {
            _db.Cars.Add(car);
            _db.SaveChanges();
        }

        public void Save(Car car)
        {
            _db.SaveChanges();
        }

        public List<Car> Search(int? brandId, int? modelId, int yearStart, int yearEnd, FuelType? fuelType)
        {
            return _db.Cars
                .Where(car =>
                   (brandId == null || car.Model.Brand.Id == brandId)
                    && (modelId == null || car.Model.Id == modelId)
                    && car.Year >= yearStart && car.Year <= yearEnd
                    && (fuelType == null || car.Model.FuelType == fuelType))
                .OrderBy(car => car.Id)
                .ToList();
        }

        public int GetBalance()
        {
            return _db.Operatrions.Select(op => op.Amount).Sum();
        }

        public void RemoveOperation(Car car, Operation task)
        {
            _db.Operatrions.Remove(task);
            _db.SaveChanges();
        }

        public void AddOperation(Car car, Operation task)
        {
            _db.Operatrions.Add(task);
            car.Tasks.Add(task);
            _db.SaveChanges();
        }
    }
}
