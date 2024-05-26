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

        private ICarRespository _carRepository;

        public CarDetailsForm(ICarRespository carRepository, Car car)
        {
            this._carRepository = carRepository;
            this._car = car;
            // init form
            InitializeComponent();
            this.idTextBox.Text = car.Id.ToString();
            this.nameTextBox.Text = car.Name;
            this.yearTextBox.Text = car.Year.ToString();

            this.fuelTypeComboBox.DataSource = Enum.GetNames(typeof(FuelType));
            this.fuelTypeComboBox.SelectedIndex = (int)car.Type;

            updateOperationGridView();
            _carRepository = carRepository;
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
                _car.Tasks.RemoveAt(e.RowIndex);
                _carRepository.Save(_car);

                updateOperationGridView();
            }
        }

        private void addOperationBtn_Click(object sender, EventArgs e)
        {
            var editDialog = new EditOperationForm();
            editDialog.ShowDialog();
        }
    }
}
