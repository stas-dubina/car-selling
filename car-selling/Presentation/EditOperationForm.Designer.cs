namespace CarDealer.Presentation
{
    partial class EditOperationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            descriptionTextBox = new TextBox();
            editBtn = new Button();
            descriptionLabel = new Label();
            timestampLabel = new Label();
            amountlLabel = new Label();
            datePicker = new DateTimePicker();
            amountTextBox = new NumericUpDown();
            cancelBtn = new Button();
            errorProvider = new ErrorProvider(components);
            timePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)amountTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(103, 73);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "Type text";
            descriptionTextBox.Size = new Size(200, 23);
            descriptionTextBox.TabIndex = 1;
            descriptionTextBox.Validating += descriptionTextBox_Validating;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(147, 154);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 23);
            editBtn.TabIndex = 3;
            editBtn.Text = "Save";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(30, 76);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(67, 15);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description";
            // 
            // timestampLabel
            // 
            timestampLabel.AutoSize = true;
            timestampLabel.Location = new Point(31, 37);
            timestampLabel.Name = "timestampLabel";
            timestampLabel.Size = new Size(66, 15);
            timestampLabel.TabIndex = 5;
            timestampLabel.Text = "Timestamp";
            // 
            // amountlLabel
            // 
            amountlLabel.AutoSize = true;
            amountlLabel.Location = new Point(46, 112);
            amountlLabel.Name = "amountlLabel";
            amountlLabel.Size = new Size(51, 15);
            amountlLabel.TabIndex = 7;
            amountlLabel.Text = "Amount";
            // 
            // datePicker
            // 
            datePicker.CustomFormat = "";
            datePicker.Location = new Point(103, 31);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(119, 23);
            datePicker.TabIndex = 5;
            // 
            // amountTextBox
            // 
            amountTextBox.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            amountTextBox.Location = new Point(103, 110);
            amountTextBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(90, 23);
            amountTextBox.TabIndex = 2;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(228, 154);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // timePicker
            // 
            timePicker.CustomFormat = "";
            timePicker.Location = new Point(228, 31);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(75, 23);
            timePicker.TabIndex = 6;
            // 
            // EditOperationForm
            // 
            AcceptButton = editBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 191);
            Controls.Add(timePicker);
            Controls.Add(cancelBtn);
            Controls.Add(amountTextBox);
            Controls.Add(editBtn);
            Controls.Add(datePicker);
            Controls.Add(descriptionTextBox);
            Controls.Add(amountlLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(timestampLabel);
            Name = "EditOperationForm";
            Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)amountTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descriptionTextBox;
        private Button editBtn;
        private Label descriptionLabel;
        private Label timestampLabel;
        private Label amountlLabel;
        private DateTimePicker datePicker;
        private NumericUpDown amountTextBox;
        private Button cancelBtn;
        private ComboBox fuelTypeComboBox;
        private ErrorProvider errorProvider;
        private DateTimePicker timePicker;
    }
}