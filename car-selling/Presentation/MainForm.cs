﻿using System.Data;
using CarDealer.Domain;
using CarDealer.Persistence;

namespace CarDealer.Presentation
{
    public partial class MainForm : Form
    {
        private ICarRepository _carRepository;
        private IBrandRepository _brandRepository;
        private IModelRepository _modelRepository;

        public MainForm(IBrandRepository brandRepository, ICarRepository carRepository, IModelRepository modelRepository)
        {
            this._carRepository = carRepository;
            this._brandRepository = brandRepository;
            this._modelRepository = modelRepository;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var fuelTypes = new List<string>()
            {
                "All"
            };
            fuelTypes.AddRange(Enum.GetNames(typeof(FuelType)));

            fuelTypeSearchBox.DataSource = fuelTypes;

            var brands = new List<Brand>()
            {
                new Brand() { Name = "All" }
            };
            brands.AddRange(_brandRepository.GetAll());

            brandSearchBox.DataSource = brands;
            brandSearchBox.DisplayMember = "Name";

            refreshResultGridView();
        }

        private void brandSearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBrand = (Brand)brandSearchBox.SelectedValue;

            var models = new List<Model>()
            {
                new Model() { Name = "All" }
            };
            models.AddRange(_modelRepository.GetAllByBrand(selectedBrand.Id));

            modelSearchBox.DataSource = null;
            modelSearchBox.DataSource = models;
            modelSearchBox.DisplayMember = "Name";
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
            var brand = brandSearchBox.SelectedIndex == 0 ? null : (Brand)brandSearchBox.SelectedItem;
            var model = modelSearchBox.SelectedIndex == 0 ? null : (Model)modelSearchBox.SelectedItem;

            var filteredResult = this._carRepository.Search(brand?.Id, model?.Id, (int)yearStartSearchBox.Value, (int)yearEndSearchBox.Value, fuelType)
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

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Система управління автосалоном, ver 1.0",
                       "About", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
        }

        private void menuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Курсова робота студента групи ПЗПІ - 23 - 6 Дубіни Станіслава",
                                   "Help", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
        }

        private void menuItemBrands_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Ця функція не працює у демоверсії.",
                null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void menuItemModels_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Ця функція не працює у демоверсії.",
                null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var addCarForm = new AddCarForm(_brandRepository, _carRepository, _modelRepository);
            addCarForm.ShowDialog();

            refreshResultGridView();
        }
    }
}
