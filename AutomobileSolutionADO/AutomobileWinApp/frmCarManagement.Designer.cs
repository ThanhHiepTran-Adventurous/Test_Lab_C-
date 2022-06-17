namespace AutomobileWinApp
{
    partial class frmCarManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCarID = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.lbCarName = new System.Windows.Forms.Label();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbReleasedYear = new System.Windows.Forms.Label();
            this.txtReleasedYear = new System.Windows.Forms.TextBox();
            this.dgvCarList = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(80, 42);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(50, 20);
            this.lbCarID.TabIndex = 0;
            this.lbCarID.Text = "Car ID";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(183, 42);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(220, 27);
            this.txtCarID.TabIndex = 1;
            // 
            // lbCarName
            // 
            this.lbCarName.AutoSize = true;
            this.lbCarName.Location = new System.Drawing.Point(80, 119);
            this.lbCarName.Name = "lbCarName";
            this.lbCarName.Size = new System.Drawing.Size(75, 20);
            this.lbCarName.TabIndex = 2;
            this.lbCarName.Text = "Car Name";
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(183, 116);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(220, 27);
            this.txtCarName.TabIndex = 3;
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(80, 189);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(97, 20);
            this.lbManufacturer.TabIndex = 4;
            this.lbManufacturer.Text = "Manufacturer";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(183, 186);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(220, 27);
            this.txtManufacturer.TabIndex = 5;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(464, 49);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(41, 20);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(571, 49);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(220, 27);
            this.txtPrice.TabIndex = 7;
            // 
            // lbReleasedYear
            // 
            this.lbReleasedYear.AutoSize = true;
            this.lbReleasedYear.Location = new System.Drawing.Point(464, 126);
            this.lbReleasedYear.Name = "lbReleasedYear";
            this.lbReleasedYear.Size = new System.Drawing.Size(101, 20);
            this.lbReleasedYear.TabIndex = 8;
            this.lbReleasedYear.Text = "Released Year";
            // 
            // txtReleasedYear
            // 
            this.txtReleasedYear.Location = new System.Drawing.Point(571, 123);
            this.txtReleasedYear.Name = "txtReleasedYear";
            this.txtReleasedYear.Size = new System.Drawing.Size(220, 27);
            this.txtReleasedYear.TabIndex = 9;
            // 
            // dgvCarList
            // 
            this.dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarList.Location = new System.Drawing.Point(-2, 304);
            this.dgvCarList.Name = "dgvCarList";
            this.dgvCarList.ReadOnly = true;
            this.dgvCarList.RowHeadersWidth = 51;
            this.dgvCarList.RowTemplate.Height = 29;
            this.dgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarList.Size = new System.Drawing.Size(962, 188);
            this.dgvCarList.TabIndex = 10;
            this.dgvCarList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCarList_CellDoubleClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(170, 242);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(383, 242);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(594, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(383, 517);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 587);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvCarList);
            this.Controls.Add(this.txtReleasedYear);
            this.Controls.Add(this.lbReleasedYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.lbManufacturer);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.lbCarName);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.lbCarID);
            this.Name = "frmCarManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Management";
            this.Load += new System.EventHandler(this.frmCarManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbCarID;
        private TextBox txtCarID;
        private Label lbCarName;
        private TextBox txtCarName;
        private Label lbManufacturer;
        private TextBox txtManufacturer;
        private Label lbPrice;
        private TextBox txtPrice;
        private Label lbReleasedYear;
        private TextBox txtReleasedYear;
        private DataGridView dgvCarList;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
    }
}