namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtManufacturer = new TextBox();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(25, 32);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(36, 15);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "CarID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(25, 70);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(25, 104);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(308, 32);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(308, 72);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(68, 15);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "ReleaseYear";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(117, 139);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(78, 23);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(261, 139);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(80, 23);
            btnNew.TabIndex = 6;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(418, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(74, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(114, 26);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(180, 23);
            txtCarID.TabIndex = 8;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(114, 64);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(180, 23);
            txtCarName.TabIndex = 9;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(114, 98);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(180, 23);
            txtManufacturer.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(385, 26);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(180, 23);
            txtPrice.TabIndex = 11;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(385, 64);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(180, 23);
            txtReleaseYear.TabIndex = 12;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(12, 172);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowTemplate.Height = 25;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(572, 164);
            dgvCarList.TabIndex = 13;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(261, 351);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(80, 23);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 386);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagemant_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private TextBox txtManufacturer;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}