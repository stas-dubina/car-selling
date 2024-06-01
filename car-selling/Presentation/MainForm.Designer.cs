namespace CarDealer.Presentation
{
    partial class MainForm
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
            resultGridView = new DataGridView();
            panel1 = new Panel();
            brandSearchBox = new ComboBox();
            modelSearchBox = new ComboBox();
            label1 = new Label();
            fuelLabel = new Label();
            fuelTypeSearchBox = new ComboBox();
            yearLabel = new Label();
            nameLabel = new Label();
            yearEndSearchBox = new NumericUpDown();
            yearStartSearchBox = new NumericUpDown();
            searchBtn = new Button();
            addBtn = new Button();
            menuBarManager = new ToolStripMenuItem();
            menuItemBrands = new ToolStripMenuItem();
            menuItemModels = new ToolStripMenuItem();
            menuBarHelp = new ToolStripMenuItem();
            menuItemHelp = new ToolStripMenuItem();
            menuItemAbout = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            balanceLabel = new Label();
            balanceValue = new Label();
            ((System.ComponentModel.ISupportInitialize)resultGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearEndSearchBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yearStartSearchBox).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // resultGridView
            // 
            resultGridView.AllowUserToAddRows = false;
            resultGridView.AllowUserToDeleteRows = false;
            resultGridView.AllowUserToResizeRows = false;
            resultGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultGridView.Location = new Point(0, 214);
            resultGridView.MultiSelect = false;
            resultGridView.Name = "resultGridView";
            resultGridView.ReadOnly = true;
            resultGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            resultGridView.Size = new Size(964, 351);
            resultGridView.TabIndex = 0;
            resultGridView.CellDoubleClick += resultGridView_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(brandSearchBox);
            panel1.Controls.Add(modelSearchBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(fuelLabel);
            panel1.Controls.Add(fuelTypeSearchBox);
            panel1.Controls.Add(yearLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(yearEndSearchBox);
            panel1.Controls.Add(yearStartSearchBox);
            panel1.Controls.Add(searchBtn);
            panel1.Location = new Point(12, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 161);
            panel1.TabIndex = 1;
            // 
            // brandSearchBox
            // 
            brandSearchBox.FormattingEnabled = true;
            brandSearchBox.Location = new Point(103, 6);
            brandSearchBox.Name = "brandSearchBox";
            brandSearchBox.Size = new Size(200, 23);
            brandSearchBox.TabIndex = 11;
            brandSearchBox.SelectedIndexChanged += brandSearchBox_SelectedIndexChanged;
            // 
            // modelSearchBox
            // 
            modelSearchBox.FormattingEnabled = true;
            modelSearchBox.Location = new Point(103, 35);
            modelSearchBox.Name = "modelSearchBox";
            modelSearchBox.Size = new Size(200, 23);
            modelSearchBox.TabIndex = 10;
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
            // fuelTypeSearchBox
            // 
            fuelTypeSearchBox.FormattingEnabled = true;
            fuelTypeSearchBox.Location = new Point(102, 96);
            fuelTypeSearchBox.Name = "fuelTypeSearchBox";
            fuelTypeSearchBox.Size = new Size(200, 23);
            fuelTypeSearchBox.TabIndex = 6;
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
            // yearEndSearchBox
            // 
            yearEndSearchBox.Location = new Point(212, 67);
            yearEndSearchBox.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            yearEndSearchBox.Minimum = new decimal(new int[] { 1970, 0, 0, 0 });
            yearEndSearchBox.Name = "yearEndSearchBox";
            yearEndSearchBox.Size = new Size(90, 23);
            yearEndSearchBox.TabIndex = 3;
            yearEndSearchBox.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // yearStartSearchBox
            // 
            yearStartSearchBox.Location = new Point(102, 67);
            yearStartSearchBox.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            yearStartSearchBox.Minimum = new decimal(new int[] { 1970, 0, 0, 0 });
            yearStartSearchBox.Name = "yearStartSearchBox";
            yearStartSearchBox.Size = new Size(90, 23);
            yearStartSearchBox.TabIndex = 2;
            yearStartSearchBox.Value = new decimal(new int[] { 1970, 0, 0, 0 });
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(227, 125);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(424, 154);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(184, 35);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add Car";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // menuBarManager
            // 
            menuBarManager.DropDownItems.AddRange(new ToolStripItem[] { menuItemBrands, menuItemModels });
            menuBarManager.Name = "menuBarManager";
            menuBarManager.Size = new Size(66, 20);
            menuBarManager.Text = "Manager";
            // 
            // menuItemBrands
            // 
            menuItemBrands.Name = "menuItemBrands";
            menuItemBrands.Size = new Size(113, 22);
            menuItemBrands.Text = "Brands";
            menuItemBrands.Click += menuItemBrands_Click;
            // 
            // menuItemModels
            // 
            menuItemModels.Name = "menuItemModels";
            menuItemModels.Size = new Size(113, 22);
            menuItemModels.Text = "Models";
            menuItemModels.Click += menuItemModels_Click;
            // 
            // menuBarHelp
            // 
            menuBarHelp.DropDownItems.AddRange(new ToolStripItem[] { menuItemHelp, menuItemAbout });
            menuBarHelp.Name = "menuBarHelp";
            menuBarHelp.Size = new Size(44, 20);
            menuBarHelp.Text = "Help";
            // 
            // menuItemHelp
            // 
            menuItemHelp.Name = "menuItemHelp";
            menuItemHelp.ShortcutKeys = Keys.F1;
            menuItemHelp.Size = new Size(146, 22);
            menuItemHelp.Text = "View Help";
            menuItemHelp.Click += menuItemHelp_Click;
            // 
            // menuItemAbout
            // 
            menuItemAbout.Name = "menuItemAbout";
            menuItemAbout.Size = new Size(146, 22);
            menuItemAbout.Text = "About";
            menuItemAbout.Click += menuItemAbout_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { menuBarManager, menuBarHelp, toolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(964, 24);
            menuStrip2.TabIndex = 4;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            balanceLabel.Location = new Point(424, 28);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(108, 37);
            balanceLabel.TabIndex = 5;
            balanceLabel.Text = "Balance";
            // 
            // balanceValue
            // 
            balanceValue.AutoSize = true;
            balanceValue.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            balanceValue.ForeColor = Color.Green;
            balanceValue.Location = new Point(424, 67);
            balanceValue.Name = "balanceValue";
            balanceValue.Size = new Size(184, 65);
            balanceValue.TabIndex = 6;
            balanceValue.Text = "10000$";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 565);
            Controls.Add(balanceValue);
            Controls.Add(balanceLabel);
            Controls.Add(addBtn);
            Controls.Add(panel1);
            Controls.Add(resultGridView);
            Controls.Add(menuStrip2);
            Name = "MainForm";
            Text = "My Car Dealer";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yearEndSearchBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)yearStartSearchBox).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView resultGridView;
        private Panel panel1;
        private Button searchBtn;
        private NumericUpDown yearStartSearchBox;
        private NumericUpDown yearEndSearchBox;
        private Label fuelLabel;
        private ComboBox fuelTypeSearchBox;
        private Label yearLabel;
        private Label nameLabel;
        private Button addBtn;
        private ComboBox brandSearchBox;
        private ComboBox modelSearchBox;
        private Label label1;
        private ToolStripMenuItem menuBarManager;
        private ToolStripMenuItem menuBarHelp;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem menuItemHelp;
        private ToolStripMenuItem menuItemAbout;
        private ToolStripMenuItem menuItemBrands;
        private ToolStripMenuItem menuItemModels;
        private Label balanceLabel;
        private Label balanceValue;
    }
}