using System.Data;
using CarDealer.Domain;

namespace CarDealer.Presentation
{
    public partial class MainForm : Form
    {
        private ICarRespository _carRepository;

        public MainForm(ICarRespository carRepository)
        {
            this._carRepository = carRepository;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var fuelTypes = new List<string>();
            fuelTypes.Add("All");
            fuelTypes.AddRange(Enum.GetNames(typeof(FuelType)));

            fuelTypeSearchBox.DataSource = fuelTypes;

            refreshResultGridView();
        }

        private void refreshResultGridView()
        {
            resultGridView.DataSource = null;
            resultGridView.DataSource = _carRepository.GetAll()
                .Select(car => new CarView(car)).ToList();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var fuelType = fuelTypeSearchBox.SelectedIndex == 0 ? null : (FuelType?)Enum.Parse(typeof(FuelType), (string)fuelTypeSearchBox.SelectedItem);

            var filteredResult = this._carRepository.Search(nameSearchBox.Text, (int)yearStartSearchBox.Value, (int)yearEndSearchBox.Value, fuelType)
                .Select(car => new CarView(car))
                .ToList();

            resultGridView.DataSource = filteredResult;
        }

        private void resultGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var allCars = (List<CarView>)resultGridView.DataSource;
            var selectedCar = allCars[e.RowIndex].GetCar();

            var carDetails = new CarDetailsForm(_carRepository, selectedCar);
            carDetails.ShowDialog();

            refreshResultGridView();
        }
    }
}
