using Microsoft.EntityFrameworkCore;
using CarDealer.Domain;

namespace CarDealer.Persistence
{
    internal class StorageDbContext : DbContext
    {
        private string _dbPath;

        public DbSet<Car> Cars { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Operation> Operatrions { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public StorageDbContext()
        {
            _dbPath = Path.Join("./car-storage.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={_dbPath}");
        }
    }
}
