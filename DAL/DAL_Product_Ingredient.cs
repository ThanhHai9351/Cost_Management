using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Product_Ingredient
    {
        QLGTDataContext qlgt = new QLGTDataContext();
        public DAL_Product_Ingredient()
        {
            
        }

        public List<m_Product_Ingredient> getListIngredientFromProduct(string product_code)
        {
            return qlgt.m_Product_Ingredients.Where(m => m.product_code == product_code).ToList();
        }

        public bool updateProductIngredient(m_Product_Ingredient item)
        {
            try
            {
                m_Product_Ingredient item_edit = qlgt.m_Product_Ingredients.Where(m => m.ingredient_id == item.ingredient_id && m.product_code == item.product_code).FirstOrDefault();
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

        public bool insertProductIngredient(m_Product_Ingredient item)
        {
            try
            {
                qlgt.m_Product_Ingredients.InsertOnSubmit(item);
                qlgt.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteProductIngredient(string product_code, string ingredient_id)
        {
            try
            {
                m_Product_Ingredient item = qlgt.m_Product_Ingredients.Where(m => m.ingredient_id == ingredient_id && m.product_code == product_code).FirstOrDefault();
                if (item == null)
                    return false;
                qlgt.m_Product_Ingredients.DeleteOnSubmit(item);
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
