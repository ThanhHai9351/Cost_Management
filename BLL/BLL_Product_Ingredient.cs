using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Product_Ingredient
    {
        DAL_Product_Ingredient dal_p_i = new DAL_Product_Ingredient();
        DAL_Ingredient dal_i = new DAL_Ingredient();

        public BLL_Product_Ingredient()
        {

        }

        public List<m_Product_Ingredient> getListIngredientFromProduct(string product_code)
        {
            return dal_p_i.getListIngredientFromProduct(product_code);
        }

        public List<t_Ingredient> getRemainingIngredients(string product_code)
        {
            List<m_Product_Ingredient> lists = getListIngredientFromProduct(product_code);
            List<t_Ingredient> allIngredients = dal_i.getIngredients();

            List<t_Ingredient> remainingIngredients = allIngredients
                .Where(i => !lists.Any(pi => pi.ingredient_id == i.ingredient_id))
                .ToList();

            return remainingIngredients;
        }

        public bool updateProductIngredient(m_Product_Ingredient item)
        {
            t_Ingredient i = dal_i.getIngredients().Where(m => m.ingredient_id == item.ingredient_id).FirstOrDefault();
            if (i == null)
                return false;
            item.price = item.quantity * i.price_per_unit;
            return dal_p_i.updateProductIngredient(item);
        }    

        public bool insertProductIngredient(string product_code, string ingredient_id)
        {
            t_Ingredient i = dal_i.getIngredients().Where(m => m.ingredient_id == ingredient_id).FirstOrDefault();
            if (i == null)
                return false;
            m_Product_Ingredient item = new m_Product_Ingredient();
            item.product_code = product_code;
            item.ingredient_id = ingredient_id;
            item.quantity = 1;
            item.price = i.price_per_unit;
            return dal_p_i.insertProductIngredient(item);
        }

        public bool deleteProductIngredient(string product_code, string ingredient_id)
        {
            return dal_p_i.deleteProductIngredient(product_code, ingredient_id);
        }
    }
}
