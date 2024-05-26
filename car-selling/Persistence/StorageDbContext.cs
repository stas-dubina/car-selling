using Microsoft.EntityFrameworkCore;
using CarDealer.Domain;

namespace CarDealer.Persistence
{
    internal class StorageDbContext : DbContext
    {
        private string _dbPath;

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Operation> Operatrions { get; set; }

        public StorageDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            _dbPath = System.IO.Path.Join(path, "car-storage-1.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={_dbPath}");
        }
    }
}
