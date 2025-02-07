using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Ingredient
    {
        QLGTDataContext qlgt = new QLGTDataContext();
        public DAL_Ingredient()
        {

        }   
        
        public List<t_Ingredient> getIngredients()
        {
            return qlgt.t_Ingredients.OrderBy(m => m.ingredient_name).ToList();
        }

        public bool insertIngredient(t_Ingredient item)
        {
            try
            {
                qlgt.t_Ingredients.InsertOnSubmit(item);
                qlgt.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateIngredient(t_Ingredient item)
        {
            try
            {
                t_Ingredient item_editor = qlgt.t_Ingredients.Where(m => m.ingredient_id == item.ingredient_id).FirstOrDefault();
                if (item_editor == null)
                    return false;
                item_editor.ingredient_name = item.ingredient_name;
                item_editor.unit = item.unit;
                item_editor.price_per_unit = item.price_per_unit;
                qlgt.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteIngredient(string ingredient_id)
        {
            try
            {
                t_Ingredient item = qlgt.t_Ingredients.Where(m => m.ingredient_id == ingredient_id).FirstOrDefault();
                qlgt.t_Ingredients.DeleteOnSubmit(item);
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
