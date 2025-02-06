using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_MaterialType
    {
        DAL_MaterialType dal_mt = new DAL_MaterialType();
        public BLL_MaterialType()
        {

        }

        public List<t_Material_Type> getMaterialTypes()
        {
            return dal_mt.getMaterialTypes();
        }

        public bool updateMaterialType(t_Material_Type item)
        {
            return dal_mt.updateMaterialType(item);
        }

        public string getNameMaterialType(string material_type_id)
        {
            return dal_mt.getNameMaterialType(material_type_id);
        }

        public string getIdMaterialType(string material_type_name)
        {
            return dal_mt.getIdMaterialType(material_type_name);
        }

        public bool deleteMaterialType(string material_type_id)
        {
            return dal_mt.deleteMaterialType(material_type_id);
        }

        public bool checkMaterialTypeId(string material_type_id)
        {
            List<t_Material_Type> list_mt = dal_mt.getMaterialTypes();
            t_Material_Type check_item = list_mt.Where(m => m.material_type_id == material_type_id).FirstOrDefault();
            if (check_item == null)
                return false;
            return true;
        }

        public bool insertMaterialType(t_Material_Type item)
        {
            return dal_mt.insertMaterialType(item);
        }

        public List<t_Material_Type> checkContainMaterialTye(List<t_Material_Type> lists)
        {
            List<t_Material_Type> list_contains = new List<t_Material_Type>();
            foreach(t_Material_Type item in lists)
            {
                if(checkMaterialTypeId(item.material_type_id))
                {
                    list_contains.Add(item);
                }    
            }    

            if(list_contains.Count > 0)
            {
                return list_contains;
            }

            return null;
        }

        public bool insertListMaterialType(List<t_Material_Type> lists)
        {
            try
            {
                foreach(t_Material_Type item_add in lists)
                {
                    if(checkMaterialTypeId(item_add.material_type_id))
                    {
                        continue;
                    }
                    insertMaterialType(item_add);
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
