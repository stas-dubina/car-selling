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
            this.nameTextBox.Text = car.Model.Brand.Name + " " + car.Model.Name;
            this.yearTextBox.Text = car.Year.ToString();

            this.fuelTypeComboBox.DataSource = Enum.GetNames(typeof(FuelType));
            this.fuelTypeComboBox.SelectedIndex = (int)car.Model.FuelType;

            operationsGridView.AutoGenerateColumns = false;

            operationsGridView.Columns.Add("Id", "#");
            operationsGridView.Columns[0].DataPropertyName = "Id";

            operationsGridView.Columns.Add("Timestamp", "Час");
            operationsGridView.Columns[1].DataPropertyName = "Timestamp";

            operationsGridView.Columns.Add("Description", "Опис");
            operationsGridView.Columns[2].DataPropertyName = "Description";

            operationsGridView.Columns.Add("Amount", "Ціна");
            operationsGridView.Columns[3].DataPropertyName = "Amount";

            operationsGridView.Columns.Add(createDeleteBtnColumn());

            refreshBalance();
            updateOperationGridView();
            _carRepository = carRepository;
        }

        private void CarDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void updateOperationGridView()
        {
            operationsGridView.SuspendLayout();

            operationsGridView.DataSource = null;
            operationsGridView.DataSource = this._car.Tasks;
            
            operationsGridView.ResumeLayout();
            operationsGridView.Refresh();
        }

        private DataGridViewButtonColumn createDeleteBtnColumn()
        {
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = DELETE_COLUMN_NAME;
            deleteButton.HeaderText = "Дія";
            deleteButton.Text = "Видалити";
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
                var confirmResult = MessageBox.Show("Ви впевнені, що хочете видалити операцію?",
                                     "Підтвердіть видалення!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var task = _car.Tasks[e.RowIndex];
                    _carRepository.RemoveOperation(_car, task);

                    refreshBalance();
                    updateOperationGridView();
                }
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

        private void addOperatrion(bool positiveAmount)
        {
            var editDialog = new EditOperationForm(positiveAmount);
            var dialogResult = editDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var operation = editDialog.Result;
                _carRepository.AddOperation(_car, operation);

                refreshBalance();
                updateOperationGridView();
            }
        }
        private void refreshBalance()
        {
            var balance = _car.Balance;
            balanceValue.Text = balance.ToString() + "$";

            if (balance <= 0)
            {
                balanceValue.ForeColor = Color.Red;
            }
            else
            {
                balanceValue.ForeColor = Color.Green;
            }
        }
    }
}
