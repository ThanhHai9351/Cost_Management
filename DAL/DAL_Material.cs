using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Material
    {
        QLGTDataContext qlgt = new QLGTDataContext();
        public DAL_Material()
        {

        }

        public List<t_Material> getMaterials()
        {
            return qlgt.t_Materials.OrderBy(m => m.material_name).ToList();
        }

        public string getNameMaterial(string material_id)
        {
            try
            {
                t_Material item = qlgt.t_Materials.Where(m => m.material_id == material_id).FirstOrDefault();
                if(item == null)
                {
                    return null;
                }
                return item.material_name;
            }
            catch
            {
                return null;
            }
        }

        public bool updateMaterial(t_Material item)
        {
            try
            {
                t_Material item_edit = qlgt.t_Materials.Where(m => m.material_id == item.material_id).FirstOrDefault();
                item_edit.material_name = item.material_name;
                item_edit.unit = item.unit;
                item_edit.price_per_unit = item.price_per_unit;
                item_edit.material_type_id = item.material_type_id;

                qlgt.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteMaterial(string material_id)
        {
            try
            {
                t_Material item = qlgt.t_Materials.Where(m => m.material_id == material_id).FirstOrDefault();
                qlgt.t_Materials.DeleteOnSubmit(item);
                qlgt.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool insertMaterial(t_Material item)
        {
            try
            {
                qlgt.t_Materials.InsertOnSubmit(item);
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
