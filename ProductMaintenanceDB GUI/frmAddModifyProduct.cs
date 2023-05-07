using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupportData;

namespace ProductMaintenanceDB_GUI
{
    public partial class frmAddModifyProduct : Form
    {
        // public because main form needs to set it

        public Product currentProduct;
        public bool isAdd;

        public frmAddModifyProduct()
        {
            InitializeComponent();
        }

        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
            if (isAdd) // it is Add
            {
                this.Text = "Add Product";
                txtProductCode.Enabled = true;
            }
            else //it is Modify
            {
                this.Text = "Modify Product";
                DisplayProduct();
                txtProductCode.Enabled = false;
            }
        }

        private void DisplayProduct()
        {
            if (currentProduct != null)
            {
                txtProductCode.Text = currentProduct.ProductCode;
                txtName.Text = currentProduct.Name;
                txtVersion.Text = currentProduct.Version.ToString();
                txtReleaseDate.Text = currentProduct.ReleaseDate.ToString();
            }
        }

        private TextBox GetTxtReleaseDate()
        {
            return txtReleaseDate;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (isAdd) // validate code
            {
                if (Validator.IsPresent(txtProductCode))
                {
                    // check if unique
                    string code = txtProductCode.Text;
                    List<string> codes = ProductDB.GetProductCodes();
                    foreach (string c in codes)
                    {
                        if (c.Trim() == code.Trim())
                        {
                            MessageBox.Show($"Duplicate product code: {code}");
                            valid = false; // found duplicate
                        }
                    }

                }
                else // empty string
                {
                    valid = false;
                }
            }

            // for both Add and Modify
            if (valid &&
                Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtVersion) &&
                Validator.IsNonNegativeDecimal(txtVersion) &&
                Validator.IsPresent(txtReleaseDate) &&
                Validator.IsDate(txtReleaseDate) 
                //Validator.IsPresentDate(txtReleaseDate)
                )
                // code execute if all data is valid
            {
                if (isAdd) // need to create the product

                {
                    currentProduct = new Product();
                }

                // input data 
                currentProduct.ProductCode = txtProductCode.Text;
                currentProduct.Name = txtName.Text;
                currentProduct.Version = Convert.ToInt32(txtVersion.Text);
                currentProduct.ReleaseDate = DateTime.Parse(txtReleaseDate.Text);
                currentProduct.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
                DialogResult = DialogResult.OK;
            }
    }
}
}
