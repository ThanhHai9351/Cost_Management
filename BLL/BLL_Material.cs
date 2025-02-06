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

        public bool updateMaterial(t_Material item)
        {
            return dal_mt.updateMaterial(item);
        }

        public bool deleleMaterial(string material_id)
        {
            return dal_mt.deleteMaterial(material_id);
        }
    }
}
