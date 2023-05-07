namespace ProductMaintenanceDB_GUI
{
    partial class frmAddModifyProduct
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
            btnOK = new Button();
            lblProductCode = new Label();
            lblName = new Label();
            lblVersion = new Label();
            lblReleaseDate = new Label();
            button1 = new Button();
            txtProductCode = new TextBox();
            txtName = new TextBox();
            txtVersion = new TextBox();
            txtReleaseDate = new TextBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(67, 224);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 31);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(24, 43);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(83, 15);
            lblProductCode.TabIndex = 1;
            lblProductCode.Text = "Product Code:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 88);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(24, 135);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(48, 15);
            lblVersion.TabIndex = 3;
            lblVersion.Text = "Version:";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Location = new Point(24, 180);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(76, 15);
            lblReleaseDate.TabIndex = 4;
            lblReleaseDate.Text = "Release Date:";
            // 
            // button1
            // 
            button1.Location = new Point(200, 224);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 5;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtProductCode
            // 
            txtProductCode.BorderStyle = BorderStyle.FixedSingle;
            txtProductCode.Location = new Point(113, 40);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(128, 23);
            txtProductCode.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(113, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 23);
            txtName.TabIndex = 7;
            // 
            // txtVersion
            // 
            txtVersion.BorderStyle = BorderStyle.FixedSingle;
            txtVersion.Location = new Point(113, 133);
            txtVersion.Name = "txtVersion";
            txtVersion.Size = new Size(128, 23);
            txtVersion.TabIndex = 8;
            // 
            // txtReleaseDate
            // 
            txtReleaseDate.BorderStyle = BorderStyle.FixedSingle;
            txtReleaseDate.Location = new Point(113, 178);
            txtReleaseDate.Name = "txtReleaseDate";
            txtReleaseDate.Size = new Size(128, 23);
            txtReleaseDate.TabIndex = 9;
            // 
            // frmAddModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 278);
            Controls.Add(txtReleaseDate);
            Controls.Add(txtVersion);
            Controls.Add(txtName);
            Controls.Add(txtProductCode);
            Controls.Add(button1);
            Controls.Add(lblReleaseDate);
            Controls.Add(lblVersion);
            Controls.Add(lblName);
            Controls.Add(lblProductCode);
            Controls.Add(btnOK);
            Name = "frmAddModifyProduct";
            Text = "Add Product";
            Load += frmAddModifyProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Label lblProductCode;
        private Label lblName;
        private Label lblVersion;
        private Label lblReleaseDate;
        private Button button1;
        private TextBox txtProductCode;
        private TextBox txtName;
        private TextBox txtVersion;
        private TextBox txtReleaseDate;
    }
}