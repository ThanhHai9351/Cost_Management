using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Ingredient
    {
        DAL_Ingredient dal_i = new DAL_Ingredient();
        public BLL_Ingredient()
        {

        }

        public List<t_Ingredient> getIngredients()
        {
            return dal_i.getIngredients();
        }

        public string getIngredientName(string ingredient_id)
        {
            t_Ingredient item = getIngredients().Where(m => m.ingredient_id == ingredient_id).FirstOrDefault();
            if (item == null)
                return "";
            return item.ingredient_name;
        }    

        public bool checkIngredientId(string ingredient_id)
        {
            List<t_Ingredient> list_is = getIngredients();
            t_Ingredient item_check = list_is.Where(m => m.ingredient_id == ingredient_id).FirstOrDefault();
            if (item_check == null)
                return false;
            return true;
        }
        
        public bool insertIngredient(t_Ingredient item)
        {
            return dal_i.insertIngredient(item);
        }

        public bool updateIngredient(t_Ingredient item)
        {
            return dal_i.updateIngredient(item);
        }

        public bool deleteIngredient(string ingredient_id)
        {
            return dal_i.deleteIngredient(ingredient_id);
        }

        public List<t_Ingredient> checkContainIngredient(List<t_Ingredient> lists)
        {
            List<t_Ingredient> list_contains = new List<t_Ingredient>();
            foreach (t_Ingredient item in lists)
            {
                if (checkIngredientId(item.ingredient_id))
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

        public bool insertListIngredients(List<t_Ingredient> lists)
        {
            try
            {
                foreach (t_Ingredient item_add in lists)
                {
                    if (checkIngredientId(item_add.ingredient_id))
                    {
                        continue;
                    }
                    insertIngredient(item_add);
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
