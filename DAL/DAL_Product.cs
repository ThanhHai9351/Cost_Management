using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Product
    {
        QLGTDataContext qlgt = new QLGTDataContext();
        public DAL_Product()
        {

        }   
        
        public List<t_Product> getProducts()
        {
            return qlgt.t_Products.OrderBy(m => m.product_name).ToList();
        }

        public bool insertProduct(t_Product item)
        {
            try
            {
                qlgt.t_Products.InsertOnSubmit(item);
                qlgt.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateProduct(t_Product item)
        {
            try
            {
                t_Product product = qlgt.t_Products.Where(m => m.product_code == item.product_code).FirstOrDefault();
                product.product_name = item.product_name;
                qlgt.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteProduct(string product_code)
        {
            try
            {
                t_Product product = qlgt.t_Products.Where(m => m.product_code == product_code).FirstOrDefault();
                qlgt.t_Products.DeleteOnSubmit(product);
                qlgt.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
