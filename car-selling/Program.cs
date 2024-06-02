using CarDealer.Domain;
using CarDealer.Persistence;
using CarDealer.Presentation;

namespace CarDealer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var db = new StorageDbContext();
            var carRepository = new CarDbRepository(db);
            var brandRepository = new BrandDbRepository(db);
            var modelRepository = new ModelDbRepository(db);
            //test data

            if (db.Cars.Count() == 0)
            {
                initDb(carRepository);
            }


            Application.Run(new MainForm(brandRepository, carRepository, modelRepository));
        }

        private static void initDb(ICarRepository carRepository)
        {
            var brandToyota = new Brand()
            {
                Id = 1,
                Name = "Toyota"
            };

            var brandBmw = new Brand()
            {
                Id = 2,
                Name = "BMW"
            };


            var modelCorolla16 = new Model()
            {
                Id = 1,
                Brand = brandToyota,
                Name = "Corolla 1.6",
                Power = 100,
                FuelType = FuelType.Gas,
                GearType = GearType.Manual
            };

            var modelCorolla133 = new Model()
            {
                Id = 2,
                Brand = brandToyota,
                Name = "Corolla 1.33",
                Power = 75,
                FuelType = FuelType.Gas,
                GearType = GearType.Manual
            };

            var modelCamry = new Model()
            {
                Id = 3,
                Brand = brandToyota,
                Name = "Camry",
                Power = 181,
                FuelType = FuelType.Gas,
                GearType = GearType.Automatic
            };

            var modelI3 = new Model()
            {
                Id = 4,
                Brand = brandBmw,
                Name = "i3",
                Power = 150,
                FuelType = FuelType.Electro,
                GearType = GearType.Automatic
            };

            carRepository.Add(new Car(1, modelCorolla16, 2016, "", CarStatus.OnSale, new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -15_000),
                    new Operation(DateTime.Now, "Замiна прокладки ГБЦ", -300)
                }));

            carRepository.Add(new Car(2, modelI3, 2015, "", CarStatus.OnSale, new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -15_000)
                }));

            carRepository.Add(new Car(3, modelCamry, 2016, "", CarStatus.OnSale, new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -30_000)
                }));

            carRepository.Add(new Car(4, modelCorolla133, 2017, "", CarStatus.OnSale, new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -16_000)
                }));
        }
    }
}