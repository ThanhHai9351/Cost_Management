using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Product_Material
    {
        DAL_Product_Material dal_p_m = new DAL_Product_Material();
        DAL_Material dal_m = new DAL_Material();

        public BLL_Product_Material()
        {

        }

        public List<m_Product_Material> getListMaterialsFromProduct(string product_code)
        {
            return dal_p_m.getListMaterialsFromProduct(product_code);
        }

        public List<t_Material> getRemainingMaterials(string product_code)
        {
            List<m_Product_Material> lists = getListMaterialsFromProduct(product_code);
            List<t_Material> allMaterials = dal_m.getMaterials();

            List<t_Material> remainingIngredients = allMaterials
                .Where(i => !lists.Any(pi => pi.material_id == i.material_id))
                .ToList();

            return remainingIngredients;
        }

        public bool updateProductMaterial(m_Product_Material item)
        {
            t_Material i = dal_m.getMaterials().Where(m => m.material_id == item.material_id).FirstOrDefault();
            if (i == null)
                return false;
            item.price = item.quantity * i.price_per_unit;
            return dal_p_m.updateProductMaterial(item);
        }

        public bool insertProductMaterial(string product_code, string material_id)
        {
            t_Material i = dal_m.getMaterials().Where(m => m.material_id == material_id).FirstOrDefault();
            if (i == null)
                return false;
            m_Product_Material item = new m_Product_Material();
            item.product_code = product_code;
            item.material_id = material_id;
            item.quantity = 1;
            item.price = i.price_per_unit;
            return dal_p_m.insertProductMaterial(item);
        }

        public bool deleteProductMaterial(string product_code, string material_id)
        {
            return dal_p_m.deleteProductMaterial(product_code, material_id);
        }

        public int getTotalPrice(string productCode)
        {
            List<m_Product_Material> lists = getListMaterialsFromProduct(productCode) ?? new List<m_Product_Material>();
            return lists.Sum(m => m.price ?? 0);
        }
    }
}
