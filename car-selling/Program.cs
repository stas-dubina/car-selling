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
            //test data

            if (db.Cars.Count() == 0)
            {
                var model = new CarModel()
                {
                    Id = 1,
                    Brand = "Toyota",
                    Model = "Corolla",
                    Power = 100,
                    FuelType = FuelType.Gas,
                    GearType = GearType.Manual
                };

                carRepository.Add(new Car(1, model, 2016, "", new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -15_000),
                    new Operation(DateTime.Now, "Замiна прокладки ГБЦ", -300)
                }));
                
                carRepository.Add(new Car(2, model, 2015, "", new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -25_000)
                }));
                
                carRepository.Add(new Car(3, model, 2017, "", new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -35_000)
                }));
                
                carRepository.Add(new Car(4, model, 2017, "", new List<Operation>()
                {
                    new Operation(DateTime.Now, "Покупка авто", -23_000)
                }));
            }


            Application.Run(new MainForm(carRepository));
        }
    }
}