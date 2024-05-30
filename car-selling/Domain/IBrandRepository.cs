namespace CarDealer.Domain
{
    public interface IBrandRepository
    {
        void Save(CarBrand brand);
        List<CarBrand> GetAll();
        List<CarBrand> Search();
    }
}
