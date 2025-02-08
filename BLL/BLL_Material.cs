using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Material
    {
        DAL_Material dal_mt = new DAL_Material();
        public BLL_Material()
        {

        }

        public List<t_Material> getMaterials()
        {
            return dal_mt.getMaterials();
        }

        public string getMaterialName(string material_id)
        {
            t_Material item = getMaterials().Where(m => m.material_id == material_id).FirstOrDefault();
            if (item == null)
                return "";
            return item.material_name;
        }

        public bool updateMaterial(t_Material item)
        {
            return dal_mt.updateMaterial(item);
        }

        public bool deleleMaterial(string material_id)
        {
            return dal_mt.deleteMaterial(material_id);
        }

        public bool checkMaterialId(string material_id)
        {
            List<t_Material> list_materials = getMaterials();
            t_Material check_item = list_materials.Where(m => m.material_id == material_id).FirstOrDefault();
            if (check_item == null)
                return false;
            return true;
        }

        public bool insertMaterial(t_Material item)
        {
            return dal_mt.insertMaterial(item);
        }

        public List<t_Material> checkContainMaterial(List<t_Material> lists)
        {
            List<t_Material> list_contains = new List<t_Material>();
            foreach (t_Material item in lists)
            {
                if (checkMaterialId(item.material_id))
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

        public bool insertListMaterials(List<t_Material> lists)
        {
            try
            {
                foreach (t_Material item_add in lists)
                {
                    if (checkMaterialId(item_add.material_type_id))
                    {
                        continue;
                    }
                    insertMaterial(item_add);
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
