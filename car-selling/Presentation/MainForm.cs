using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            resultGridView.DataSource = _carRepository.GetAll();

            var fuelTypes = new List<string>();
            fuelTypes.Add("All");
            fuelTypes.AddRange(Enum.GetNames(typeof(FuelType)));

            fuelTypeSearchBox.DataSource = fuelTypes;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var fuelType = fuelTypeSearchBox.SelectedIndex == 0 ? null : (FuelType?)Enum.Parse(typeof(FuelType), (string)fuelTypeSearchBox.SelectedItem);
            var filteredResult = this._carRepository.Search(nameSearchBox.Text, (int)yearStartSearchBox.Value, (int)yearEndSearchBox.Value, fuelType);
            resultGridView.DataSource = filteredResult;
        }

        private void resultGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var allCars = (List<Car>)resultGridView.DataSource;
            var selectedCar = allCars[e.RowIndex];

            var carDetails = new CarDetailsForm(_carRepository, selectedCar);
            carDetails.ShowDialog();
        }
    }
}
