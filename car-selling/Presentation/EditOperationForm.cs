using CarDealer.Domain;

namespace CarDealer.Presentation
{
    public partial class EditOperationForm : Form
    {

        bool _positiveAmount;
        
        public Operation Result { get; set; }

        public EditOperationForm(bool positiveAmount)
        {
            InitializeComponent();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;

            datePicker.CustomFormat = "dd-MM-yyyy";
            
            _positiveAmount = positiveAmount;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!validateDescription())
            {
                return;
            }

            var timestamp = new DateTime(DateOnly.FromDateTime(datePicker.Value), TimeOnly.FromDateTime(timePicker.Value));
            var amount = (int)amountTextBox.Value;
            this.Result = new Operation(timestamp, descriptionTextBox.Text, _positiveAmount ? amount : -1 * amount);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void descriptionTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validateDescription();
        }

        private bool validateDescription()
        {
            if (descriptionTextBox.Text == "")
            {
                errorProvider.SetError(descriptionTextBox, "Please input description.");
                return false;
            }
            else
            {
                errorProvider.SetError(descriptionTextBox, "");
                return true;
            }
        }
    }
}
