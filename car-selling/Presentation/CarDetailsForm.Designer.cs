namespace CarDealer.Presentation
{
    partial class CarDetailsForm
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
            panel1 = new Panel();
            idTextBox = new TextBox();
            idLabel = new Label();
            fuelLabel = new Label();
            fuelTypeComboBox = new ComboBox();
            yearLabel = new Label();
            nameLabel = new Label();
            yearTextBox = new NumericUpDown();
            updateBtn = new Button();
            nameTextBox = new TextBox();
            operationsGridView = new DataGridView();
            addOperationBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)operationsGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(idTextBox);
            panel1.Controls.Add(idLabel);
            panel1.Controls.Add(fuelLabel);
            panel1.Controls.Add(fuelTypeComboBox);
            panel1.Controls.Add(yearLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(yearTextBox);
            panel1.Controls.Add(updateBtn);
            panel1.Controls.Add(nameTextBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 181);
            panel1.TabIndex = 2;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(70, 7);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(90, 23);
            idTextBox.TabIndex = 9;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(37, 10);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(18, 15);
            idLabel.TabIndex = 8;
            idLabel.Text = "ID";
            // 
            // fuelLabel
            // 
            fuelLabel.AutoSize = true;
            fuelLabel.Location = new Point(26, 106);
            fuelLabel.Name = "fuelLabel";
            fuelLabel.Size = new Size(29, 15);
            fuelLabel.TabIndex = 7;
            fuelLabel.Text = "Fuel";
            // 
            // fuelTypeComboBox
            // 
            fuelTypeComboBox.FormattingEnabled = true;
            fuelTypeComboBox.Location = new Point(70, 103);
            fuelTypeComboBox.Name = "fuelTypeComboBox";
            fuelTypeComboBox.Size = new Size(200, 23);
            fuelTypeComboBox.TabIndex = 6;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(26, 76);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(29, 15);
            yearLabel.TabIndex = 5;
            yearLabel.Text = "Year";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(26, 39);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(70, 74);
            yearTextBox.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            yearTextBox.Minimum = new decimal(new int[] { 1970, 0, 0, 0 });
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(90, 23);
            yearTextBox.TabIndex = 2;
            yearTextBox.Value = new decimal(new int[] { 1970, 0, 0, 0 });
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(195, 144);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 23);
            updateBtn.TabIndex = 1;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(70, 36);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Type text";
            nameTextBox.Size = new Size(200, 23);
            nameTextBox.TabIndex = 0;
            // 
            // operationsGridView
            // 
            operationsGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            operationsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            operationsGridView.Location = new Point(12, 216);
            operationsGridView.MultiSelect = false;
            operationsGridView.Name = "operationsGridView";
            operationsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            operationsGridView.Size = new Size(776, 222);
            operationsGridView.TabIndex = 3;
            operationsGridView.CellClick += operationsGridView_CellClick;
            // 
            // addOperationBtn
            // 
            addOperationBtn.Location = new Point(713, 187);
            addOperationBtn.Name = "addOperationBtn";
            addOperationBtn.Size = new Size(75, 23);
            addOperationBtn.TabIndex = 10;
            addOperationBtn.Text = "Add";
            addOperationBtn.UseVisualStyleBackColor = true;
            addOperationBtn.Click += addOperationBtn_Click;
            // 
            // CarDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addOperationBtn);
            Controls.Add(operationsGridView);
            Controls.Add(panel1);
            Name = "CarDetailsForm";
            Text = "CarDetailsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yearTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)operationsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label fuelLabel;
        private ComboBox fuelTypeComboBox;
        private Label yearLabel;
        private Label nameLabel;
        private NumericUpDown yearTextBox;
        private Button updateBtn;
        private TextBox nameTextBox;
        private Label idLabel;
        private TextBox idTextBox;
        private DataGridView operationsGridView;
        private Button addOperationBtn;
    }
}