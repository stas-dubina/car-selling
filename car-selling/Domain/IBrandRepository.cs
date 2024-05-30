namespace CarDealer.Domain
{
    public interface IBrandRepository
    {
        void Add(Brand brand);
        void Save(Brand brand);
        List<Brand> GetAll();
    }
}
