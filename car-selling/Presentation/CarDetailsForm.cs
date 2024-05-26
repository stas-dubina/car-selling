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
        public CarDetailsForm(Car car)
        {
            InitializeComponent();
            this.IdTextBox.Text = car.Id.ToString();
            this.nameTextBox.Text = car.Name;
            this.yearTextBox.Text = car.Year.ToString();
            
            this.fuelTypeComboBox.DataSource = Enum.GetNames(typeof(FuelType));
            this.fuelTypeComboBox.SelectedIndex = (int)car.Type;
        }
    }
}
