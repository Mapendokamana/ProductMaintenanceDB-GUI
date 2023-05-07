using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportData
{
    /// <summary>
    /// repository of methods to work  with Products table
    /// </summary>
    public static class ProductDB
    {
        /// <summary>
        /// retrieves products data
        /// </summary>
        /// <returns>list of lightweight product objects</returns>
        public static List<ProductDTO> GetProducts()
        {
            List<ProductDTO> products = new List<ProductDTO>();// empty list
            using (TechSupportContext db = new TechSupportContext())
            {
                products = db.Products.
                    OrderBy(p => p.ProductCode).
                    Select(p => new ProductDTO()
                    {
                        ProductCode = p.ProductCode,
                        Name = p.Name,
                        Version = p.Version,
                        ReleaseDate = p.ReleaseDate
                    }).ToList();
            }
            return products;
        }

        /// <summary>
        /// find product by primary key value
        /// </summary>
        /// <param name="productCode">code of the product to find</param>
        /// <returns>found product or null</returns>
        public static Product FindProduct(string productCode)
        {
            Product product = null;
            using (TechSupportContext db = new TechSupportContext())
            {
                product = db.Products.Find(productCode);
            }
            return product;
        }

        /// <summary>
        /// get list of product codes
        /// </summary>
        /// <returns> list of product codes</returns>
        public static List<string> GetProductCodes()
        {
            List<string> codes = new List<string>();
            using (TechSupportContext db = new TechSupportContext())
            {
                codes = db.Products.Select(p => p.ProductCode).ToList();
            }
            return codes;
        }

        /// <summary>
        /// adds new product
        /// </summary>
        /// <param name="newProd">product to add</param>
        public static void AddProduct(Product newProd)
        {
            if (newProd != null)
            {
                using (TechSupportContext db = new TechSupportContext())
                {
                    db.Products.Add(newProd);
                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        ///  update existing product with new data 
        /// </summary>
        /// <param name="newProdData">new product data</param>
        public static void UpdateProduct(Product newProdData)
        {
            if (newProdData != null)
            {
                using (TechSupportContext db = new TechSupportContext())
                {
                    // find the product to update in this context
                    Product prod = db.Products.Find(newProdData.ProductCode);
                    if (prod != null) // it still exists
                    {
                        // code does not  change
                        prod.Name = newProdData.Name;
                        prod.Version = newProdData.Version;
                        prod.ReleaseDate = newProdData.ReleaseDate;
                        db.SaveChanges();
                    }
                }
            }
        }

        /// <summary>
        /// delete product
        /// </summary>
        /// <param name="productCode">code of the product to delete</param>
        public static void DeleteProduct(string productCode)
        {
            using (TechSupportContext db = new TechSupportContext())
            {
                Product prod = db.Products.Find(productCode);
                if (prod != null)
                {
                    db.Products.Remove(prod);
                    db.SaveChanges();

                }
            }
        }
    }
}
