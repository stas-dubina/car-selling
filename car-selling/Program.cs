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
                initDb(brandRepository, carRepository, modelRepository);
            }


            Application.Run(new MainForm(brandRepository, carRepository, modelRepository));
        }

        private static void initDb(IBrandRepository brandRepository, ICarRepository carRepository, IModelRepository modelRepository)
        {

            int brandId = 0;

            var brandAudi = new Brand()
            {
                Id = ++brandId,
                Name = "Audi"
            };
            brandRepository.Add(brandAudi);

            var brandAlfaRomeo = new Brand()
            {
                Id = ++brandId,
                Name = "Alfa Romeo"
            };
            brandRepository.Add(brandAlfaRomeo);

            var brandBmw = new Brand()
            {
                Id = ++brandId,
                Name = "BMW"
            };
            brandRepository.Add(brandBmw);

            var brandFord = new Brand()
            {
                Id = ++brandId,
                Name = "Ford"
            };
            brandRepository.Add(brandFord);

            var brandDodge = new Brand()
            {
                Id = ++brandId,
                Name = "Dodge"
            };
            brandRepository.Add(brandDodge);

            var brandHaval = new Brand()
            {
                Id = ++brandId,
                Name = "Haval"
            };
            brandRepository.Add(brandHaval);

            var brandInfiniti = new Brand()
            {
                Id = ++brandId,
                Name = "Infiniti"
            };
            brandRepository.Add(brandInfiniti);

            var brandMazda = new Brand()
            {
                Id = ++brandId,
                Name = "Mazda"
            };
            brandRepository.Add(brandMazda);

            var brandMercedes = new Brand()
            {
                Id = ++brandId,
                Name = "Mercedes"
            };
            brandRepository.Add(brandMercedes);

            var brandNissan = new Brand()
            {
                Id = ++brandId,
                Name = "Nissan"
            };
            brandRepository.Add(brandNissan);

            var brandPorsche = new Brand()
            {
                Id = ++brandId,
                Name = "Porsche"
            };
            brandRepository.Add(brandPorsche);

            var brandSkoda = new Brand()
            {
                Id = ++brandId,
                Name = "Skoda"
            };
            brandRepository.Add(brandSkoda);

            var brandTesla = new Brand()
            {
                Id = ++brandId,
                Name = "Tesla"
            };
            brandRepository.Add(brandTesla);

            var brandToyota = new Brand()
            {
                Id = ++brandId,
                Name = "Toyota"
            };
            brandRepository.Add(brandToyota);

            var brandVolkswagen = new Brand()
            {
                Id = ++brandId,
                Name = "Volkswagen"
            };
            brandRepository.Add(brandVolkswagen);

            var brandVolvo = new Brand()
            {
                Id = ++brandId,
                Name = "Volvo"
            };
            brandRepository.Add(brandVolvo);

            var brandZaz = new Brand()
            {
                Id = ++brandId,
                Name = "ЗАЗ"
            };
            brandRepository.Add(brandZaz);

            // models

            int modelId = 0;

            var modelR8 = new Model()
            {
                Id = ++modelId,
                Brand = brandAudi,
                Name = "R8",
                Power = 610,
                FuelType = FuelType.Gas,
                GearType = GearType.Automatic
            };
            modelRepository.Add(modelR8);

            var modelI3 = new Model()
            {
                Id = ++modelId,
                Brand = brandBmw,
                Name = "i3",
                Power = 150,
                FuelType = FuelType.Electro,
                GearType = GearType.Automatic
            };
            modelRepository.Add(modelI3);

            var modelM5 = new Model()
            {
                Id = ++modelId,
                Brand = brandBmw,
                Name = "M5",
                Power = 550,
                FuelType = FuelType.Gas,
                GearType = GearType.Automatic
            };
            modelRepository.Add(modelM5);

            var model760li = new Model()
            {
                Id = ++modelId,
                Brand = brandBmw,
                Name = "760li",
                Power = 470,
                FuelType = FuelType.Electro,
                GearType = GearType.Automatic
            };
            modelRepository.Add(model760li);

            var modelCx5 = new Model()
            {
                Id = ++modelId,
                Brand = brandMazda,
                Name = "CX-5",
                Power = 194,
                FuelType = FuelType.Gas,
                GearType = GearType.Automatic
            };
            modelRepository.Add(modelCx5);

            var modelOctavia = new Model()
            {
                Id = ++modelId,
                Brand = brandSkoda,
                Name = "Octavia",
                Power = 200,
                FuelType = FuelType.Gas,
                GearType = GearType.Manual
            };
            modelRepository.Add(modelOctavia);

            var modelCorolla16 = new Model()
            {
                Id = ++modelId,
                Brand = brandToyota,
                Name = "Corolla 1.6",
                Power = 140,
                FuelType = FuelType.Gas,
                GearType = GearType.Manual
            };
            modelRepository.Add(modelCorolla16);

            var modelCorolla133 = new Model()
            {
                Id = ++modelId,
                Brand = brandToyota,
                Name = "Corolla 1.33",
                Power = 99,
                FuelType = FuelType.Gas,
                GearType = GearType.Manual
            };
            modelRepository.Add(modelCorolla133);

            var modelCamry = new Model()
            {
                Id = ++modelId,
                Brand = brandToyota,
                Name = "Camry",
                Power = 181,
                FuelType = FuelType.Hybrid,
                GearType = GearType.Automatic
            };
            modelRepository.Add(modelCamry);

            var modelArteon = new Model()
            {
                Id = ++modelId,
                Brand = brandVolkswagen,
                Name = "Arteon",
                Power = 200,
                FuelType = FuelType.Diesel,
                GearType = GearType.Automatic
            };
            modelRepository.Add(modelArteon);

            var model968 = new Model()
            {
                Id = ++modelId,
                Brand = brandZaz,
                Name = "968",
                Power = 27,
                FuelType = FuelType.Gas,
                GearType = GearType.Manual
            };
            modelRepository.Add(model968);

            var carId = 0;
            carRepository.Add(new Car(++carId, modelR8, 2024, "", CarStatus.OnSale, new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -55_000)
                }));

            carRepository.Add(new Car(++carId, modelI3, 2015, "", CarStatus.OnSale, new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -15_000)
                }));

            carRepository.Add(new Car(++carId, modelM5, 2021, "", CarStatus.OnSale, new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -75_000)
                }));

            carRepository.Add(new Car(++carId, model760li, 2023, "", CarStatus.OnSale, new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -90_000)
                }));

            carRepository.Add(new Car(++carId, modelCx5, 2024, "", CarStatus.OnSale, new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -30_000)
                }));

            carRepository.Add(new Car(++carId, modelOctavia, 2009, "", CarStatus.OnSale, new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -14_000)
                }));

            carRepository.Add(new Car(++carId, modelCorolla16, 2016, "", CarStatus.OnSale, new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -15_000),
                    new Operation(DateTime.Now, "Замiна прокладки ГБЦ", -300)
                }));

            carRepository.Add(new Car(++carId, modelCamry, 2016, "", CarStatus.OnSale, new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -30_000)
                }));

            carRepository.Add(new Car(++carId, modelCorolla133, 2017, "", CarStatus.OnSale, new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -16_000)
                }));

            carRepository.Add(new Car(++carId, modelArteon, 2024, "", CarStatus.OnSale, new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -35_000)
                }));

            carRepository.Add(new Car(++carId, model968, 1983, "", CarStatus.OnSale, new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -1_000)
                }));
        }
    }
}