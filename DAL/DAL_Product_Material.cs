using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Product_Material
    {
        QLGTDataContext qlgt = new QLGTDataContext();
        public DAL_Product_Material()
        {

        }

        public List<m_Product_Material> getListMaterialsFromProduct(string product_code)
        {
            return qlgt.m_Product_Materials.Where(m => m.product_code == product_code).ToList();
        }

        public bool updateProductMaterial(m_Product_Material item)
        {
            try
            {
                m_Product_Material item_edit = qlgt.m_Product_Materials.Where(m => m.material_id == item.material_id && m.product_code == item.product_code).FirstOrDefault();
                if (item_edit == null)
                {
                    return false;
                }
                item_edit.quantity = item.quantity;
                item_edit.price = item.price;
                qlgt.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool insertProductMaterial(m_Product_Material item)
        {
            try
            {
                qlgt.m_Product_Materials.InsertOnSubmit(item);
                qlgt.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteProductMaterial(string product_code, string material_id)
        {
            try
            {
                m_Product_Material item = qlgt.m_Product_Materials.Where(m => m.material_id == material_id && m.product_code == product_code).FirstOrDefault();
                if (item == null)
                    return false;
                qlgt.m_Product_Materials.DeleteOnSubmit(item);
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
