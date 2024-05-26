using CarDealer.Domain;

namespace CarDealer.Presentation
{
    public partial class EditOperationForm : Form
    {
        public Operation Result { get; set; }

        public EditOperationForm()
        {
            InitializeComponent();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;

            datePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!validateDescription())
            {
                return;
            }

            var timestamp = new DateTime(DateOnly.FromDateTime(datePicker.Value), TimeOnly.FromDateTime(timePicker.Value));
            this.Result = new Operation(timestamp, descriptionTextBox.Text, amountTextBox.Value);
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
