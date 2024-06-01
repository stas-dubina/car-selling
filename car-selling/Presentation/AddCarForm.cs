using CarDealer.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer.Presentation
{
    public partial class AddCarForm : Form
    {

        private ICarRepository _carRepository;
        private IBrandRepository _brandRepository;
        private IModelRepository _modelRepository;

        public AddCarForm(IBrandRepository brandRepository, ICarRepository carRepository, IModelRepository modelRepository)
        {
            this._carRepository = carRepository;
            this._brandRepository = brandRepository;
            this._modelRepository = modelRepository;
            InitializeComponent();
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {
            fuelTypeBox.DataSource = Enum.GetNames(typeof(FuelType));

            brandBox.DataSource = _brandRepository.GetAll();
            brandBox.DisplayMember = "Name";
        }

        private void brandBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBrand = (Brand)brandBox.SelectedValue;

            modelBox.DataSource = null;
            modelBox.DataSource = _modelRepository.GetAllByBrand(selectedBrand!.Id);
            modelBox.DisplayMember = "Name";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var selectedModel = (Model)modelBox.SelectedValue;

            var car = new Car()
            {
                Model = selectedModel!,
                Year = (int)yearBox.Value,
                Description = "",
                Tasks = new List<Operation>()
                {
                    new Operation()
                    {
                        Timestamp = DateTime.Now,
                        Description = "Покупка автомобіля",
                        Amount = -1 * priceBox.Value,
                    }
                }
            };

            _carRepository.Add(car);

            Close();
        }
    }
}
