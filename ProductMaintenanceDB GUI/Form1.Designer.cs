namespace ProductMaintenanceDB_GUI
{
    partial class frmProductMaintenance
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
            dgvProducts = new DataGridView();
            btnAdd = new Button();
            btnModify = new Button();
            btnRemove = new Button();
            btnExit = new Button();
            lblProductCode = new Label();
            lblName = new Label();
            lblVersion = new Label();
            lblReleaseDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(17, 46);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(491, 217);
            dgvProducts.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(17, 283);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 24);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(118, 283);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 24);
            btnModify.TabIndex = 2;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(222, 283);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 24);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(433, 283);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 24);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(57, 28);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(80, 15);
            lblProductCode.TabIndex = 5;
            lblProductCode.Text = "Product Code";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(182, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(310, 28);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(45, 15);
            lblVersion.TabIndex = 7;
            lblVersion.Text = "Version";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Location = new Point(422, 28);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(73, 15);
            lblReleaseDate.TabIndex = 8;
            lblReleaseDate.Text = "Release Date";
            // 
            // frmProductMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 323);
            Controls.Add(lblReleaseDate);
            Controls.Add(lblVersion);
            Controls.Add(lblName);
            Controls.Add(lblProductCode);
            Controls.Add(btnExit);
            Controls.Add(btnRemove);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(dgvProducts);
            Name = "frmProductMaintenance";
            Text = "Product Maintenance";
            Load += frmProductMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnAdd;
        private Button btnModify;
        private Button btnRemove;
        private Button btnExit;
        private Label lblProductCode;
        private Label lblName;
        private Label lblVersion;
        private Label lblReleaseDate;
    }
}