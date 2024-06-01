namespace CarDealer.Presentation
{
    partial class AddCarForm
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
            priceBox = new NumericUpDown();
            priceLabel = new Label();
            brandBox = new ComboBox();
            modelBox = new ComboBox();
            label1 = new Label();
            fuelLabel = new Label();
            fuelTypeBox = new ComboBox();
            yearLabel = new Label();
            nameLabel = new Label();
            yearBox = new NumericUpDown();
            addBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yearBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(priceBox);
            panel1.Controls.Add(priceLabel);
            panel1.Controls.Add(brandBox);
            panel1.Controls.Add(modelBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(fuelLabel);
            panel1.Controls.Add(fuelTypeBox);
            panel1.Controls.Add(yearLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(yearBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 163);
            panel1.TabIndex = 5;
            // 
            // priceBox
            // 
            priceBox.Location = new Point(103, 126);
            priceBox.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(90, 23);
            priceBox.TabIndex = 14;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(58, 128);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(33, 15);
            priceLabel.TabIndex = 13;
            priceLabel.Text = "Price";
            // 
            // brandBox
            // 
            brandBox.FormattingEnabled = true;
            brandBox.Location = new Point(103, 6);
            brandBox.Name = "brandBox";
            brandBox.Size = new Size(200, 23);
            brandBox.TabIndex = 11;
            brandBox.SelectedIndexChanged += brandBox_SelectedIndexChanged;
            // 
            // modelBox
            // 
            modelBox.FormattingEnabled = true;
            modelBox.Location = new Point(103, 35);
            modelBox.Name = "modelBox";
            modelBox.Size = new Size(200, 23);
            modelBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 38);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 9;
            label1.Text = "Model";
            // 
            // fuelLabel
            // 
            fuelLabel.AutoSize = true;
            fuelLabel.Location = new Point(58, 99);
            fuelLabel.Name = "fuelLabel";
            fuelLabel.Size = new Size(29, 15);
            fuelLabel.TabIndex = 7;
            fuelLabel.Text = "Fuel";
            // 
            // fuelTypeBox
            // 
            fuelTypeBox.FormattingEnabled = true;
            fuelTypeBox.Location = new Point(102, 96);
            fuelTypeBox.Name = "fuelTypeBox";
            fuelTypeBox.Size = new Size(200, 23);
            fuelTypeBox.TabIndex = 6;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(58, 69);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(29, 15);
            yearLabel.TabIndex = 5;
            yearLabel.Text = "Year";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(58, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(38, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Brand";
            // 
            // yearBox
            // 
            yearBox.Location = new Point(103, 67);
            yearBox.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            yearBox.Minimum = new decimal(new int[] { 1970, 0, 0, 0 });
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(90, 23);
            yearBox.TabIndex = 2;
            yearBox.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // addBtn
            // 
            addBtn.Location = new Point(304, 181);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(393, 213);
            Controls.Add(panel1);
            Controls.Add(addBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddCarForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Car";
            Load += AddCarForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)yearBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox brandBox;
        private ComboBox modelBox;
        private Label label1;
        private Label fuelLabel;
        private ComboBox fuelTypeBox;
        private Label yearLabel;
        private Label nameLabel;
        private NumericUpDown yearBox;
        private Button addBtn;
        private NumericUpDown priceBox;
        private Label priceLabel;
    }
}