using CarDealer.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Persistence
{
    internal class CarDbRepository : ICarRespository
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

        public List<Car> Search(string name, int yearStart, int yearEnd, FuelType? fuelType)
        {
            return _db.Cars.Where(car =>
                car.Model.Model.ToLower().Contains(name.ToLower())
                && car.Year >= yearStart && car.Year <= yearEnd
                && (fuelType == null || car.Model.FuelType == fuelType)
            ).ToList();
        }
    }
}
