using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MaterialType
    {
        QLGTDataContext qlgt = new QLGTDataContext();
        public DAL_MaterialType()
        {

        }

        public List<t_Material_Type> getMaterialTypes()
        {
            return qlgt.t_Material_Types.OrderBy(m => m.material_type_name).ToList();
        }

        public bool updateMaterialType(t_Material_Type item)
        {
            try
            {
                t_Material_Type item_editor = qlgt.t_Material_Types.Where(m => m.material_type_id == item.material_type_id).FirstOrDefault();

                if(item_editor == null)
                {
                    return false;
                }    
                item_editor.material_type_name = item.material_type_name;

                qlgt.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public string getNameMaterialType(string material_type_id)
        {
            try
            {
                t_Material_Type item = qlgt.t_Material_Types.Where(m => m.material_type_id == material_type_id).FirstOrDefault();
                if(item == null)
                {
                    return null;
                }
                return item.material_type_name;
            }
            catch
            {
                return null;
            }
        }

        public string getIdMaterialType(string material_type_name)
        {
            try
            {
                t_Material_Type item = qlgt.t_Material_Types.Where(m => m.material_type_name == material_type_name).FirstOrDefault();
                if (item == null)
                {
                    return null;
                }
                return item.material_type_id;
            }
            catch
            {
                return null;
            }
        }

        public bool deleteMaterialType(string material_type_id)
        {
            try
            {
                t_Material_Type item = qlgt.t_Material_Types.Where(m => m.material_type_id == material_type_id).FirstOrDefault();
                qlgt.t_Material_Types.DeleteOnSubmit(item);
                qlgt.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool insertMaterialType(t_Material_Type item)
        {
            try
            {
                qlgt.t_Material_Types.InsertOnSubmit(item);
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
