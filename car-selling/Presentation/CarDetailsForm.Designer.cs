﻿namespace CarDealer.Presentation
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
            nameTextBox = new TextBox();
            operationsGridView = new DataGridView();
            addOperationBtn = new Button();
            sellBtn = new Button();
            balanceValue = new Label();
            balanceLabel = new Label();
            statusValueText = new Label();
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
            idTextBox.Size = new Size(200, 23);
            idTextBox.TabIndex = 9;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(37, 10);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(14, 15);
            idLabel.TabIndex = 8;
            idLabel.Text = "#";
            // 
            // fuelLabel
            // 
            fuelLabel.AutoSize = true;
            fuelLabel.Location = new Point(15, 106);
            fuelLabel.Name = "fuelLabel";
            fuelLabel.Size = new Size(49, 15);
            fuelLabel.TabIndex = 7;
            fuelLabel.Text = "Паливо";
            // 
            // fuelTypeComboBox
            // 
            fuelTypeComboBox.Enabled = false;
            fuelTypeComboBox.FormattingEnabled = true;
            fuelTypeComboBox.Location = new Point(70, 103);
            fuelTypeComboBox.Name = "fuelTypeComboBox";
            fuelTypeComboBox.Size = new Size(200, 23);
            fuelTypeComboBox.TabIndex = 6;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(32, 76);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(23, 15);
            yearLabel.TabIndex = 5;
            yearLabel.Text = "Рік";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(14, 39);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(50, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Модель";
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(70, 74);
            yearTextBox.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            yearTextBox.Minimum = new decimal(new int[] { 1970, 0, 0, 0 });
            yearTextBox.Name = "yearTextBox";
            yearTextBox.ReadOnly = true;
            yearTextBox.Size = new Size(90, 23);
            yearTextBox.TabIndex = 2;
            yearTextBox.Value = new decimal(new int[] { 1970, 0, 0, 0 });
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(70, 36);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Type text";
            nameTextBox.ReadOnly = true;
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
            operationsGridView.ReadOnly = true;
            operationsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            operationsGridView.Size = new Size(776, 222);
            operationsGridView.TabIndex = 3;
            operationsGridView.CellClick += operationsGridView_CellClick;
            // 
            // addOperationBtn
            // 
            addOperationBtn.BackColor = Color.DarkRed;
            addOperationBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addOperationBtn.ForeColor = Color.White;
            addOperationBtn.Location = new Point(685, 157);
            addOperationBtn.Name = "addOperationBtn";
            addOperationBtn.Size = new Size(103, 40);
            addOperationBtn.TabIndex = 10;
            addOperationBtn.Text = "Витрати";
            addOperationBtn.UseVisualStyleBackColor = false;
            addOperationBtn.Click += addOperationBtn_Click;
            // 
            // sellBtn
            // 
            sellBtn.BackColor = Color.Green;
            sellBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sellBtn.ForeColor = Color.White;
            sellBtn.Location = new Point(685, 102);
            sellBtn.Name = "sellBtn";
            sellBtn.Size = new Size(103, 40);
            sellBtn.TabIndex = 11;
            sellBtn.Text = "Продано";
            sellBtn.UseVisualStyleBackColor = false;
            sellBtn.Click += sellBtn_Click;
            // 
            // balanceValue
            // 
            balanceValue.AutoSize = true;
            balanceValue.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            balanceValue.ForeColor = Color.Green;
            balanceValue.Location = new Point(342, 52);
            balanceValue.Name = "balanceValue";
            balanceValue.Size = new Size(184, 65);
            balanceValue.TabIndex = 13;
            balanceValue.Text = "10000$";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            balanceLabel.Location = new Point(342, 12);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(102, 37);
            balanceLabel.TabIndex = 12;
            balanceLabel.Text = "Баланс";
            // 
            // statusValueText
            // 
            statusValueText.AutoSize = true;
            statusValueText.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statusValueText.Location = new Point(693, 12);
            statusValueText.Name = "statusValueText";
            statusValueText.Size = new Size(95, 37);
            statusValueText.TabIndex = 15;
            statusValueText.Text = "Статус";
            // 
            // CarDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusValueText);
            Controls.Add(balanceValue);
            Controls.Add(balanceLabel);
            Controls.Add(sellBtn);
            Controls.Add(addOperationBtn);
            Controls.Add(operationsGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CarDetailsForm";
            Text = "Автомобіль";
            Load += CarDetailsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yearTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)operationsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label fuelLabel;
        private ComboBox fuelTypeComboBox;
        private Label yearLabel;
        private Label nameLabel;
        private NumericUpDown yearTextBox;
        private TextBox nameTextBox;
        private Label idLabel;
        private TextBox idTextBox;
        private DataGridView operationsGridView;
        private Button addOperationBtn;
        private Button sellBtn;
        private Label balanceValue;
        private Label balanceLabel;
        private Label statusValueText;
    }
}