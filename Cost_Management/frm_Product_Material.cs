using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace Cost_Management
{
    public partial class frm_Product_Material : Form
    {
        t_Product product = null;
        BLL_Product_Material bll_p_m = new BLL_Product_Material();
        BLL_Material bll_m = new BLL_Material();
        BLL_MaterialType bll_mt = new BLL_MaterialType();

        List<t_Material> lst_ms = null;
        List<m_Product_Material> lst_p_ms = null;
        public frm_Product_Material()
        {
            InitializeComponent();
        }

        public frm_Product_Material(t_Product p)
        {
            this.product = p;
            InitializeComponent();
        }

        private void frm_Product_Material_Load(object sender, EventArgs e)
        {
            lb_ProductName.Text = product.product_name;
            gb_Product.Text = product.product_name;
            loadMaterialGroup();
            loadProductMaterialGroup();
        }

        public void loadMaterialGroup()
        {
            loadMaterialTable();
            loadCBOFilerMaterial();
            txt_SearchMaterial.Text = "";
        }   

        public void loadMaterialTable()
        {
            lst_ms = bll_p_m.getRemainingMaterials(product.product_code);

            dtgv_Material.DataSource = lst_ms;

            dtgv_Material.Columns["material_id"].HeaderText = "Mã Vật Tư";
            dtgv_Material.Columns["material_name"].HeaderText = "Tên Vật Tư";
            dtgv_Material.Columns["unit"].HeaderText = "Đơn Vị Tính";
            dtgv_Material.Columns["price_per_unit"].HeaderText = "Giá / 1 Đơn Vị Tính";

            dtgv_Material.Columns["material_id"].Width = 150;
            dtgv_Material.Columns["material_name"].Width = 250;
            dtgv_Material.Columns["unit"].Width = 150;
            dtgv_Material.Columns["price_per_unit"].Width = 150;
        }

        public void loadCBOFilerMaterial()
        {
            List<t_Material_Type> list_materialtypes = bll_mt.getMaterialTypes();
            cbo_FilterMaterialType.DataSource = list_materialtypes;
            cbo_FilterMaterialType.DisplayMember = "material_type_name";
            cbo_FilterMaterialType.ValueMember = "material_type_id";
        }
        
        public void loadProductMaterialGroup()
        {
            loadProductMaterialTable();
            txt_SearchMaterialProduct.Text = "";
            txt_Quantity.Text = "";
        }    

        public void loadProductMaterialTable()
        {
            lst_p_ms = bll_p_m.getListMaterialsFromProduct(product.product_code);

            dtgv_Product_Material.DataSource = lst_p_ms;

            // Thêm cột "Tên Vật Liệu" nếu chưa có
            if (!dtgv_Product_Material.Columns.Contains("material_name"))
            {
                dtgv_Product_Material.Columns.Add("material_name", "Tên Vật Liệu");
            }

            // Gán tên nguyên liệu thực tế cho từng dòng
            foreach (DataGridViewRow row in dtgv_Product_Material.Rows)
            {
                if (row.Cells["material_id"].Value != null)
                {
                    string materialId = row.Cells["material_id"].Value.ToString();
                    row.Cells["material_name"].Value = bll_m.getMaterialName(materialId); // Lấy tên vật liệu
                }
            }

            dtgv_Product_Material.Columns["product_code"].Visible = false;

            dtgv_Product_Material.Columns["material_id"].HeaderText = "Mã Nguyên Liệu";
            dtgv_Product_Material.Columns["material_name"].HeaderText = "Tên Nguyên Liệu";
            dtgv_Product_Material.Columns["quantity"].HeaderText = "Số Lượng";
            dtgv_Product_Material.Columns["price"].HeaderText = "Giá";

            dtgv_Product_Material.Columns["material_id"].DisplayIndex = 0;   // Mã Vật Liệu
            dtgv_Product_Material.Columns["material_name"].DisplayIndex = 1; // Tên Vật Liệu
            dtgv_Product_Material.Columns["quantity"].DisplayIndex = 2;        // Số Lượng
            dtgv_Product_Material.Columns["price"].DisplayIndex = 3;           // Giá

            dtgv_Product_Material.Columns["material_id"].Width = 150;
            dtgv_Product_Material.Columns["material_name"].Width = 250;
            dtgv_Product_Material.Columns["quantity"].Width = 150;
            dtgv_Product_Material.Columns["price"].Width = 150;
        }

        private void btn_ReLoadMaterial_Click(object sender, EventArgs e)
        {
            loadMaterialGroup();
        }

        private void btn_ReloadMaterialProduct_Click(object sender, EventArgs e)
        {
            loadProductMaterialGroup();
        }

        private void cbo_FilterMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string material_type_id = cbo_FilterMaterialType.SelectedValue.ToString();
            lst_ms = bll_p_m.getRemainingMaterials(product.product_code).Where(m => m.material_type_id == material_type_id).ToList();

            dtgv_Material.DataSource = lst_ms;
        }

        private void txt_SearchMaterialProduct_TextChanged(object sender, EventArgs e)
        {
            string searchName = txt_SearchMaterialProduct.Text.Trim().ToLower();

            // Lấy danh sách nguyên liệu của sản phẩm
            List<m_Product_Material> lst_p_ms = bll_p_m.getListMaterialsFromProduct(product.product_code);

            // Kiểm tra danh sách rỗng
            if (lst_p_ms == null || lst_p_ms.Count == 0)
                return;

            // Lọc danh sách dựa trên tên nguyên liệu
            var filteredList = lst_p_ms
                .Where(p => bll_m.getMaterialName(p.material_id).ToLower().Contains(searchName))
                .ToList();

            // Gán dữ liệu đã lọc vào DataGridView
            dtgv_Product_Material.DataSource = null;
            dtgv_Product_Material.DataSource = filteredList;

            // Cập nhật lại cột "Tên Nguyên Liệu"
            foreach (DataGridViewRow row in dtgv_Product_Material.Rows)
            {
                if (row.Cells["material_id"].Value != null)
                {
                    string materialId = row.Cells["material_id"].Value.ToString();
                    row.Cells["material_name"].Value = bll_m.getMaterialName(materialId);
                }
            }

            dtgv_Product_Material.Columns["product_code"].Visible = false;

            dtgv_Product_Material.Columns["material_id"].HeaderText = "Mã Nguyên Liệu";
            dtgv_Product_Material.Columns["material_name"].HeaderText = "Tên Nguyên Liệu";
            dtgv_Product_Material.Columns["quantity"].HeaderText = "Số Lượng";
            dtgv_Product_Material.Columns["price"].HeaderText = "Giá";

            dtgv_Product_Material.Columns["material_id"].DisplayIndex = 0;   // Mã Vật Liệu
            dtgv_Product_Material.Columns["material_name"].DisplayIndex = 1; // Tên Vật Liệu
            dtgv_Product_Material.Columns["quantity"].DisplayIndex = 2;        // Số Lượng
            dtgv_Product_Material.Columns["price"].DisplayIndex = 3;           // Giá

            dtgv_Product_Material.Columns["material_id"].Width = 150;
            dtgv_Product_Material.Columns["material_name"].Width = 250;
            dtgv_Product_Material.Columns["quantity"].Width = 150;
            dtgv_Product_Material.Columns["price"].Width = 150;
        }

        private void txt_SearchMaterial_TextChanged(object sender, EventArgs e)
        {
            string searchName = txt_SearchMaterial.Text.Trim();

            if (!string.IsNullOrEmpty(searchName))
            {
                lst_ms = bll_p_m.getRemainingMaterials(product.product_code).Where(m => m.material_name.ToLower().Contains(searchName.ToLower())).ToList();
            }

            dtgv_Material.DataSource = lst_ms;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (dtgv_Material.SelectedRows.Count > 0)
            {
                DataGridViewRow clickedRow = dtgv_Material.SelectedRows[0];
                string material_id = clickedRow.Cells[0].Value.ToString().Trim();

                if (!bll_p_m.insertProductMaterial(product.product_code, material_id))
                {
                    MessageBox.Show("Lỗi!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                loadMaterialGroup();
                loadProductMaterialGroup();
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (dtgv_Product_Material.SelectedRows.Count > 0)
            {
                DataGridViewRow clickedRow = dtgv_Product_Material.SelectedRows[0];
                string material_id = clickedRow.Cells[0].Value.ToString().Trim();

                if (!bll_p_m.deleteProductMaterial(product.product_code, material_id))
                {
                    MessageBox.Show("Lỗi!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                loadMaterialGroup();
                loadProductMaterialGroup();
            }
        }

        private void dtgv_Product_Material_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Product_Material.SelectedRows.Count > 0)
            {
                DataGridViewRow clickedRow = dtgv_Product_Material.SelectedRows[0];
                txt_Quantity.Text = clickedRow.Cells[2].Value.ToString().Trim();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Quantity.Text))
            {
                MessageBox.Show("Vui lòng nhập số > 0", "Thông báo!");
                return;
            }

            if (dtgv_Product_Material.SelectedRows.Count > 0)
            {
                DataGridViewRow clickedRow = dtgv_Product_Material.SelectedRows[0];
                string material_id = clickedRow.Cells[0].Value.ToString().Trim();
                int quantity = int.Parse(txt_Quantity.Text.Trim());

                m_Product_Material item = new m_Product_Material();
                item.material_id = material_id;
                item.quantity = quantity;
                item.product_code = product.product_code;

                if (!bll_p_m.updateProductMaterial(item))
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                loadProductMaterialGroup();
            }
        }
    }
}
