using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace Cost_Management
{
    public partial class frm_ViewMaterial : Form
    {
        BLL_MaterialType bll_mt = new BLL_MaterialType();
        BLL_Material bll_m = new BLL_Material();
        List<t_Material_Type> lst_mts = null;
        List<t_Material> lst_ms = null;

        public frm_ViewMaterial()
        {
            InitializeComponent();
        }

        private void frm_ViewMaterial_Load(object sender, EventArgs e)
        {
            loadMaterialTypeTable();
            loadMaterialsTable();
            loadCBOFilterMaterialType();
            loadCBOFilterMaterial();
            resetComponentsMaterialType();
            resetComponentsMaterial();
            LoadCBOMaterialType();
        }

        public void resetComponentsMaterialType()
        {
            txt_NameMaterialType.Enabled = false;
            btn_EditMaterialType.Enabled = false;
            btn_DeleteMaterialType.Enabled = false;
            btn_SaveChangeMaterialType.Enabled = false;

            txt_SearchMaterialType.Text = "";
        }

        public void resetComponentsMaterial()
        {
            txt_NameMaterial.Enabled = false;
            txt_UnitMaterial.Enabled = false;
            txt_PriceMaterial.Enabled = false;
            cbo_MaterialType.Enabled = false;
            btn_EditMaterial.Enabled = false;
            btn_DeleteMaterial.Enabled = false;
            btn_SaveChangeMaterial.Enabled = false;

            txt_NameMaterial.Text = "";
            txt_UnitMaterial.Text = "";
            txt_PriceMaterial.Text = "";
            txt_SearchNameMaterial.Text = "";
        }

        public void LoadCBOMaterialType()
        {
            List<t_Material_Type> list_materialtypes = bll_mt.getMaterialTypes();
            cbo_MaterialType.DataSource = list_materialtypes;
            cbo_MaterialType.DisplayMember = "material_type_name"; 
            cbo_MaterialType.ValueMember = "material_type_id"; 
        }


        public void loadCBOFilterMaterial()
        {
            cbo_FilterMaterial.Items.Clear();
            cbo_FilterMaterial.Items.Add("Tên A -> Z");
            cbo_FilterMaterial.Items.Add("Tên Z -> A");

            cbo_FilterMaterial.SelectedIndex = 0;
        }

        public void loadMaterialTypeTable()
        {
            lst_mts = bll_mt.getMaterialTypes();
            dtgv_MaterialType.DataSource = lst_mts;

            dtgv_MaterialType.Columns["material_type_id"].HeaderText = "Mã Loại Vật Tư";
            dtgv_MaterialType.Columns["material_type_name"].HeaderText = "Tên Loại Vật Tư";

            dtgv_MaterialType.Columns["material_type_id"].Width = 150;
            dtgv_MaterialType.Columns["material_type_name"].Width = 250;
        }

        public void loadCBOFilterMaterialType()
        {
            cbo_FilterMaterialType.Items.Clear();  
            cbo_FilterMaterialType.Items.Add("Tên A -> Z");
            cbo_FilterMaterialType.Items.Add("Tên Z -> A");

            cbo_FilterMaterialType.SelectedIndex = 0;
        }

        public void loadMaterialsTable()
        {
            lst_ms = bll_m.getMaterials().OrderBy(m => m.material_name).ToList();
            dtgv_Material.DataSource = lst_ms;

            dtgv_Material.Columns["material_id"].HeaderText = "Mã Vật Tư";
            dtgv_Material.Columns["material_name"].HeaderText = "Tên Vật Tư";
            dtgv_Material.Columns["unit"].HeaderText = "Đơn Vị Tính";
            dtgv_Material.Columns["price_per_unit"].HeaderText = "Giá / 1 Đơn Vị Tính";
            dtgv_Material.Columns["material_type_id"].HeaderText = "Mã Loại Vật Tư";

            dtgv_Material.Columns["material_id"].Width = 150;
            dtgv_Material.Columns["material_name"].Width = 250;
            dtgv_Material.Columns["unit"].Width = 150;
            dtgv_Material.Columns["price_per_unit"].Width = 150;
            dtgv_Material.Columns["material_type_id"].Width = 150;
        }

        private void cbo_FilterMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_FilterMaterialType.SelectedIndex.ToString()=="0")
            {
                dtgv_MaterialType.DataSource = lst_mts.OrderBy(m => m.material_type_name).ToList();
            }
            else
            {
                dtgv_MaterialType.DataSource = lst_mts.OrderByDescending(m => m.material_type_name).ToList();
            }
        }

        private void btn_ReLoadMaterialType_Click(object sender, EventArgs e)
        {
            loadMaterialTypeTable();
            loadCBOFilterMaterialType();
            resetComponentsMaterialType();
        }

        private void txt_SearchMaterialType_TextChanged(object sender, EventArgs e)
        {
            string searchName = txt_SearchMaterialType.Text.Trim();

            List<t_Material_Type> lst_mts = bll_mt.getMaterialTypes();

            if (!string.IsNullOrEmpty(searchName))
            {
                lst_mts = lst_mts.Where(mt => mt.material_type_name.ToLower().Contains(searchName.ToLower())).ToList();
            }

            dtgv_MaterialType.DataSource = lst_mts;
        }

        private void txt_SearchNameMaterial_TextChanged(object sender, EventArgs e)
        {
            string searchName = txt_SearchNameMaterial.Text.Trim();

            List<t_Material> lst_ms = bll_m.getMaterials();

            if (!string.IsNullOrEmpty(searchName))
            {
                lst_ms = lst_ms.Where(mt => mt.material_name.ToLower().Contains(searchName.ToLower())).ToList();
            }

            dtgv_Material.DataSource = lst_ms;
        }

        private void btn_ReloadMaterial_Click(object sender, EventArgs e)
        {
            loadMaterialsTable();
            loadCBOFilterMaterial();
            resetComponentsMaterial();
        }

        private void cbo_FilterMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_FilterMaterial.SelectedIndex.ToString() == "0")
            {
                dtgv_Material.DataSource = lst_ms.OrderBy(m => m.material_name).ToList();
            }
            else
            {
                dtgv_Material.DataSource = lst_ms.OrderByDescending(m => m.material_name).ToList();
            }
        }

        private void dtgv_MaterialType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Truyền data từ tb1 -> tb2
                DataGridViewRow clickedRow = dtgv_MaterialType.Rows[e.RowIndex];
                string material_type_id = clickedRow.Cells[0].Value.ToString().Trim();
                lst_ms = bll_m.getMaterials().Where(m => m.material_type_id == material_type_id).ToList();
                dtgv_Material.DataSource = lst_ms;

                //Truyền data xuống text input và khai mở nút sửa và xóa
                txt_NameMaterialType.Text = clickedRow.Cells[1].Value.ToString().Trim();
                btn_EditMaterialType.Enabled = true;
                btn_DeleteMaterialType.Enabled = true;
            }
        }

        private void btn_EditMaterialType_Click(object sender, EventArgs e)
        {
            txt_NameMaterialType.Enabled = true;
            btn_DeleteMaterialType.Enabled = false;
            btn_EditMaterialType.Enabled = false;
            btn_SaveChangeMaterialType.Enabled = true;
        }

        private void btn_SaveChangeMaterialType_Click(object sender, EventArgs e)
        {
            string name_material_type = txt_NameMaterialType.Text.Trim();

            if(!string.IsNullOrEmpty(name_material_type))
            {
                if (dtgv_MaterialType.SelectedRows.Count > 0)
                {
                    DataGridViewRow clickedRow = dtgv_MaterialType.SelectedRows[0];
                    string material_type_id = clickedRow.Cells[0].Value.ToString().Trim();

                    t_Material_Type item_edit = new t_Material_Type();
                    item_edit.material_type_id = material_type_id;
                    item_edit.material_type_name = name_material_type;

                    if (bll_mt.updateMaterialType(item_edit))
                    {
                        MessageBox.Show("Sửa thành công!");
                        resetComponentsMaterialType();
                        loadMaterialTypeTable();
                    }
                }
            }    
        }

        private void dtgv_Material_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Truyền data xuống form
                DataGridViewRow clickedRow = dtgv_Material.Rows[e.RowIndex];
                txt_NameMaterial.Text = clickedRow.Cells[1].Value.ToString().Trim();
                txt_UnitMaterial.Text = clickedRow.Cells[2].Value.ToString().Trim();
                txt_PriceMaterial.Text = clickedRow.Cells[3].Value.ToString().Trim();
                cbo_MaterialType.Text = bll_mt.getNameMaterialType(clickedRow .Cells[4].Value.ToString()).Trim();

                btn_EditMaterial.Enabled = true;
                btn_DeleteMaterial.Enabled = true;
            }
        }

        private void btn_EditMaterial_Click(object sender, EventArgs e)
        {
            btn_DeleteMaterial.Enabled = false;
            btn_EditMaterial.Enabled = false;
            btn_SaveChangeMaterial.Enabled = true;

            txt_NameMaterial.Enabled = true;
            txt_PriceMaterial.Enabled = true;
            txt_UnitMaterial.Enabled = true;
            cbo_MaterialType.Enabled = true;
        }

        private void btn_SaveChangeMaterial_Click(object sender, EventArgs e)
        {
            string name_material = txt_NameMaterial.Text.Trim();
            string unit_material = txt_UnitMaterial.Text.Trim();
            int price_material = int.Parse(txt_PriceMaterial.Text.Trim());
            string material_type_id = cbo_MaterialType.SelectedValue.ToString();

            if(!string.IsNullOrEmpty(material_type_id)&& !string.IsNullOrEmpty(name_material)&& !string.IsNullOrEmpty(unit_material))
            {
                if (dtgv_Material.SelectedRows.Count > 0)
                {
                    DataGridViewRow clickedRow = dtgv_Material.SelectedRows[0];
                    string material_id = clickedRow.Cells[0].Value.ToString().Trim();

                    t_Material item_edit = new t_Material();
                    item_edit.material_id = material_id;
                    item_edit.material_name = name_material;
                    item_edit.unit = unit_material;
                    item_edit.price_per_unit = price_material;
                    item_edit.material_type_id = material_type_id;


                    if (bll_m.updateMaterial(item_edit))
                    {
                        MessageBox.Show("Sửa thành công!");
                        resetComponentsMaterial();
                        loadMaterialsTable();
                    }
                }
            }    
        }

        private void btn_DeleteMaterialType_Click(object sender, EventArgs e)
        {
            if (dtgv_MaterialType.SelectedRows.Count > 0)
            {
                DataGridViewRow clickedRow = dtgv_MaterialType.SelectedRows[0];
                string material_type_id = clickedRow.Cells[0].Value.ToString().Trim();
                
                if(MessageBox.Show("Bạn có muốn xóa "+ clickedRow.Cells[1].Value.ToString().Trim()+" không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if(bll_mt.deleteMaterialType(material_type_id))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo!");
                        resetComponentsMaterialType();
                        loadMaterialTypeTable();
                    }    
                }    
            }
        }

        private void btn_DeleteMaterial_Click(object sender, EventArgs e)
        {
            if (dtgv_Material.SelectedRows.Count > 0)
            {
                DataGridViewRow clickedRow = dtgv_Material.SelectedRows[0];
                string material_id = clickedRow.Cells[0].Value.ToString().Trim();

                if (MessageBox.Show("Bạn có muốn xóa " + clickedRow.Cells[1].Value.ToString().Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bll_m.deleleMaterial(material_id))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo!");
                        resetComponentsMaterial();
                        loadMaterialsTable();
                    }
                }
            }
        }

    }
}
