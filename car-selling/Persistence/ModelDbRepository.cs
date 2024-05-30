using CarDealer.Domain;

namespace CarDealer.Persistence
{
    internal class ModelDbRepository : IModelRepository
    {
        private StorageDbContext _db;
        public ModelDbRepository(StorageDbContext storageDbContext)
        {
            _db = storageDbContext;
        }

        public List<Model> GetAll()
        {
            return _db.Models.ToList();
        }

        public List<Model> GetAllByBrand(int brandId)
        {
            return _db.Models.Where(model => model.Brand.Id == brandId).ToList();
        }
    }
}
