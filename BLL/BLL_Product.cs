using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Product
    {
        DAL_Product dal_p = new DAL_Product();
        public BLL_Product()
        {

        }    

        public List<t_Product> getProducts()
        {
            return dal_p.getProducts();
        }    

        public bool insertProduct(t_Product item)
        {
            return dal_p.insertProduct(item);
        }

        public bool updateProduct(t_Product item)
        {
            return dal_p.updateProduct(item);
        }    

        public bool deleleProduct(string product_code)
        {
            return dal_p.deleteProduct(product_code);
        }

        public bool checkProductCode(string product_code)
        {
            t_Product product = getProducts().Where(m => m.product_code == product_code).FirstOrDefault();
            if (product == null)
                return false;
            return true;
        }

        public List<t_Product> checkContainProducts(List<t_Product> lists)
        {
            List<t_Product> list_contains = new List<t_Product>();
            foreach (t_Product item in lists)
            {
                if (checkProductCode(item.product_code))
                {
                    list_contains.Add(item);
                }
            }

            if (list_contains.Count > 0)
            {
                return list_contains;
            }

            return null;
        }

        public bool insertListProducts(List<t_Product> lists)
        {
            try
            {
                foreach (t_Product item_add in lists)
                {
                    if (checkProductCode(item_add.product_code))
                    {
                        continue;
                    }
                    insertProduct(item_add);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
