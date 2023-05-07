using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TechSupportData;

namespace ProductMaintenanceDB_GUI
{
    public partial class frmProductMaintenance : Form
    {
        public frmProductMaintenance()
        {
            InitializeComponent();
        }
        private TechSupportContext context = new TechSupportContext();
        private Product currentProduct;

        private void frmProductMaintenance_Load(object sender, EventArgs e)
        {
            DisplayProduct();
        }

        private void DisplayProduct()
        {
            dgvProducts.Columns.Clear();// reset columns
            List<ProductDTO> product = ProductDB.GetProducts();

            dgvProducts.DataSource = product;
            using (TechSupportContext db = new TechSupportContext())

            //to remove empty coloumns and show only data 
            {
                dgvProducts.DataSource = context.Products.Select(p => new
                {
                    p.ProductCode,
                    p.Name,
                    p.Version,
                    p.ReleaseDate
                }).ToList();


                //dgvProducts.Columns.Add(deleteColumn);
                dgvProducts.Columns[0].HeaderText = "";
                dgvProducts.Columns[1].HeaderText = "";
                dgvProducts.Columns[2].HeaderText = "";
                dgvProducts.Columns[3].HeaderText = "";
                dgvProducts.Columns[0].Width = 100;
                dgvProducts.Columns[1].Width = 150;
                dgvProducts.Columns[2].Width = 100;
                dgvProducts.Columns[3].Width = 100;

                dgvProducts.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProducts.DefaultCellStyle.Font = new Font("Consolas", 10);
                dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 12, FontStyle.Bold);
                dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyProduct secondForm = new frmAddModifyProduct();
            secondForm.isAdd = true;
            secondForm.currentProduct = null;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK) // proceed with add
            {
                currentProduct = secondForm.currentProduct;
                if (currentProduct != null)
                {
                    try
                    {
                        ProductDB.AddProduct(currentProduct);
                        DisplayProduct(); // refresh grid
                    }
                    catch (DbUpdateException ex) // errors coming from SaveChanges
                    {
                        string errorMessage = "Error(s) while adding product:\n";
                        var sqlException = (SqlException)ex.InnerException;
                        foreach (SqlError error in sqlException.Errors)
                        {
                            errorMessage += "ERROR CODE:  " + error.Number +
                                            " " + error.Message + "\n";
                        }
                        MessageBox.Show(errorMessage);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Database connection lost while adding a product. Try again later");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding a product: " +
                            ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (currentProduct == null)
            {
                MessageBox.Show("Please select a product to modify.");
                return;
            }

            frmAddModifyProduct modifyProduct = new frmAddModifyProduct();
            modifyProduct.isAdd = false;
            modifyProduct.currentProduct = currentProduct;
            DialogResult result = modifyProduct.ShowDialog();

            if (result == DialogResult.OK)
            {
                currentProduct = modifyProduct.currentProduct;
                context.SaveChanges();
                DisplayProduct();
            };
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (currentProduct == null)
            {
                MessageBox.Show("Please select a product to remove.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                context.Products.Remove(currentProduct);
                context.SaveChanges();
                currentProduct = null;
                DisplayProduct();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}