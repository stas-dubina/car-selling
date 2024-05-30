using CarDealer.Domain;

namespace CarDealer.Persistence
{
    internal class BrandDbRepository : IBrandRepository
    {
        private StorageDbContext _db;

        public BrandDbRepository(StorageDbContext storageDbContext)
        {
            _db = storageDbContext;
        }

        public List<Brand> GetAll()
        {
            return _db.Brands.ToList();
        }

        public void Add(Brand brand)
        {
            _db.Brands.Add(brand);
            _db.SaveChanges();
        }

        public void Save(Brand brand)
        {
            _db.SaveChanges();
        }
    }
}
