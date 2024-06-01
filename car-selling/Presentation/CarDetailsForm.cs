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
    public partial class CarDetailsForm : Form
    {
        private const string DELETE_COLUMN_NAME = "deleteBtnColumn";

        private Car _car;

        private ICarRepository _carRepository;

        public CarDetailsForm(ICarRepository carRepository, Car car)
        {
            this._carRepository = carRepository;
            this._car = car;
            // init form
            InitializeComponent();
            this.idTextBox.Text = car.Id.ToString();
            this.nameTextBox.Text = car.Model.Brand + " " + car.Model.Name;
            this.yearTextBox.Text = car.Year.ToString();

            this.fuelTypeComboBox.DataSource = Enum.GetNames(typeof(FuelType));
            this.fuelTypeComboBox.SelectedIndex = (int)car.Model.FuelType;

            updateOperationGridView();
            _carRepository = carRepository;
        }

        private void CarDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void updateOperationGridView()
        {
            operationsGridView.DataSource = null;
            operationsGridView.Columns.Clear();

            operationsGridView.DataSource = this._car.Tasks;
            operationsGridView.Columns.Add(createDeleteBtnColumn());
        }

        private DataGridViewButtonColumn createDeleteBtnColumn()
        {
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = DELETE_COLUMN_NAME;
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            return deleteButton;
        }

        private void operationsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == operationsGridView.NewRowIndex || e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == operationsGridView.Columns[DELETE_COLUMN_NAME].Index)
            {
                var task = _car.Tasks[e.RowIndex];
                _carRepository.RemoveOperation(_car, task);

                updateOperationGridView();
            }
        }

        private void addOperationBtn_Click(object sender, EventArgs e)
        {
            addOperatrion(false);
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            addOperatrion(true);
        }

        private void addOperatrion(bool positiveAmount) {
            var editDialog = new EditOperationForm(positiveAmount);
            var dialogResult = editDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var operation = editDialog.Result;
                _carRepository.AddOperation(_car, operation);
                updateOperationGridView();
            }
        }
    }
}
