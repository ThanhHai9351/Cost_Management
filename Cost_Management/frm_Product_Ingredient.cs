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
    public partial class frm_Product_Ingredient : Form
    {
        t_Product product = null;

        BLL_Product_Ingredient bll_p_i = new BLL_Product_Ingredient();
        BLL_Ingredient bll_i = new BLL_Ingredient();
        List<m_Product_Ingredient> lst_p_is = null;
        List<t_Ingredient> lst_is = null;

        public frm_Product_Ingredient()
        {
            InitializeComponent();
        }

        public frm_Product_Ingredient(t_Product p)
        {
            this.product = p;
            InitializeComponent();
        }

        private void frm_Product_Ingredient_Load(object sender, EventArgs e)
        {
            lb_ProductName.Text = product.product_name;
            gb_Product.Text = product.product_name;
            loadIngredientGroup();
            loadProductIngredientGroup();
        }

        public void loadProductIngredientGroup()
        {
            loadProductIngredienTable();
            loadCBOFilterProductIngredient();
            txt_SearchIngredientProduct.Text = "";
            txt_Quantity.Text = "";
        }

        public void loadIngredientGroup()
        {
            loadIngredientTable();
            loadCBOFilterIngredient();
            txt_SearchIngredient.Text = "";
        }    

        public void loadCBOFilterProductIngredient()
        {
            cbo_FilterIngredientProduct.Items.Clear();
            cbo_FilterIngredientProduct.Items.Add("Tên A -> Z");
            cbo_FilterIngredientProduct.Items.Add("Tên Z -> A");

            cbo_FilterIngredientProduct.SelectedIndex = 0;
        }

        public void loadCBOFilterIngredient()
        {
            cbo_FilterIngredient.Items.Clear();
            cbo_FilterIngredient.Items.Add("Tên A -> Z");
            cbo_FilterIngredient.Items.Add("Tên Z -> A");

            cbo_FilterIngredient.SelectedIndex = 0;
        }

        public void loadIngredientTable()
        {
            lst_is = bll_p_i.getRemainingIngredients(product.product_code);

            dtgv_Ingredient.DataSource = lst_is;

            dtgv_Ingredient.Columns["ingredient_id"].HeaderText = "Mã Nguyên Liệu";
            dtgv_Ingredient.Columns["ingredient_name"].HeaderText = "Tên Nguyên Liệu";
            dtgv_Ingredient.Columns["unit"].HeaderText = "Đơn Vị Tính";
            dtgv_Ingredient.Columns["price_per_unit"].HeaderText = "Giá / 1 Đơn Vị Tính";

            dtgv_Ingredient.Columns["ingredient_id"].Width = 150;
            dtgv_Ingredient.Columns["ingredient_name"].Width = 250;
            dtgv_Ingredient.Columns["unit"].Width = 150;
            dtgv_Ingredient.Columns["price_per_unit"].Width = 150;
        }

        public void loadProductIngredienTable()
        {
            lst_p_is = bll_p_i.getListIngredientFromProduct(product.product_code);
            dtgv_Product_Ingredient.DataSource = lst_p_is;

            // Thêm cột "Tên Nguyên Liệu" nếu chưa có
            if (!dtgv_Product_Ingredient.Columns.Contains("ingredient_name"))
            {
                dtgv_Product_Ingredient.Columns.Add("ingredient_name", "Tên Nguyên Liệu");
            }

            // Gán tên nguyên liệu thực tế cho từng dòng
            foreach (DataGridViewRow row in dtgv_Product_Ingredient.Rows)
            {
                if (row.Cells["ingredient_id"].Value != null)
                {
                    string ingredientId = row.Cells["ingredient_id"].Value.ToString();
                    row.Cells["ingredient_name"].Value = bll_i.getIngredientName(ingredientId); // Lấy tên nguyên liệu
                }
            }

            dtgv_Product_Ingredient.Columns["product_code"].Visible = false;

            dtgv_Product_Ingredient.Columns["ingredient_id"].HeaderText = "Mã Nguyên Liệu";
            dtgv_Product_Ingredient.Columns["ingredient_name"].HeaderText = "Tên Nguyên Liệu";
            dtgv_Product_Ingredient.Columns["quantity"].HeaderText = "Số Lượng";
            dtgv_Product_Ingredient.Columns["price"].HeaderText = "Giá";

            dtgv_Product_Ingredient.Columns["ingredient_id"].DisplayIndex = 0;   // Mã Nguyên Liệu
            dtgv_Product_Ingredient.Columns["ingredient_name"].DisplayIndex = 1; // Tên Nguyên Liệu
            dtgv_Product_Ingredient.Columns["quantity"].DisplayIndex = 2;        // Số Lượng
            dtgv_Product_Ingredient.Columns["price"].DisplayIndex = 3;           // Giá

            dtgv_Product_Ingredient.Columns["ingredient_id"].Width = 150;
            dtgv_Product_Ingredient.Columns["ingredient_name"].Width = 250;
            dtgv_Product_Ingredient.Columns["quantity"].Width = 150;
            dtgv_Product_Ingredient.Columns["price"].Width = 150;
        }

        private void btn_ReLoadIngredient_Click(object sender, EventArgs e)
        {
            loadIngredientGroup();
        }

        private void cbo_FilterIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_FilterIngredient.SelectedIndex.ToString() == "0")
            {
                dtgv_Ingredient.DataSource = lst_is.OrderBy(m => m.ingredient_name).ToList();
            }
            else
            {
                dtgv_Ingredient.DataSource = lst_is.OrderByDescending(m => m.ingredient_name).ToList();
            }
        }

        private void txt_SearchIngredient_TextChanged(object sender, EventArgs e)
        {
            string searchName = txt_SearchIngredient.Text.Trim();

            List<t_Ingredient> lst_mts = bll_i.getIngredients();

            if (!string.IsNullOrEmpty(searchName))
            {
                lst_mts = lst_mts.Where(mt => mt.ingredient_name.ToLower().Contains(searchName.ToLower())).ToList();
            }

            dtgv_Ingredient.DataSource = lst_mts;
        }

        private void btn_ReloadIngredientProduct_Click(object sender, EventArgs e)
        {
            loadProductIngredientGroup();
        }

        private void cbo_FilterIngredientProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<m_Product_Ingredient> lst_p_is = bll_p_i.getListIngredientFromProduct(product.product_code);

            // Kiểm tra nếu danh sách không có dữ liệu thì thoát
            if (lst_p_is == null || lst_p_is.Count == 0)
                return;

            // Sắp xếp danh sách dựa trên lựa chọn
            if (cbo_FilterIngredientProduct.SelectedIndex == 0) // A -> Z
            {
                lst_p_is = lst_p_is.OrderBy(p => bll_i.getIngredientName(p.ingredient_id)).ToList();
            }
            else if (cbo_FilterIngredientProduct.SelectedIndex == 1) // Z -> A
            {
                lst_p_is = lst_p_is.OrderByDescending(p => bll_i.getIngredientName(p.ingredient_id)).ToList();
            }

            // Gán dữ liệu đã sắp xếp vào DataGridView
            dtgv_Product_Ingredient.DataSource = null;
            dtgv_Product_Ingredient.DataSource = lst_p_is;

            // Cập nhật lại giá trị "Tên Nguyên Liệu"
            foreach (DataGridViewRow row in dtgv_Product_Ingredient.Rows)
            {
                if (row.Cells["ingredient_id"].Value != null)
                {
                    string ingredientId = row.Cells["ingredient_id"].Value.ToString();
                    row.Cells["ingredient_name"].Value = bll_i.getIngredientName(ingredientId);
                }
            }

            dtgv_Product_Ingredient.Columns["product_code"].Visible = false;

            dtgv_Product_Ingredient.Columns["ingredient_id"].HeaderText = "Mã Nguyên Liệu";
            dtgv_Product_Ingredient.Columns["ingredient_name"].HeaderText = "Tên Nguyên Liệu";
            dtgv_Product_Ingredient.Columns["quantity"].HeaderText = "Số Lượng";
            dtgv_Product_Ingredient.Columns["price"].HeaderText = "Giá";

            dtgv_Product_Ingredient.Columns["ingredient_id"].DisplayIndex = 0;   // Mã Nguyên Liệu
            dtgv_Product_Ingredient.Columns["ingredient_name"].DisplayIndex = 1; // Tên Nguyên Liệu
            dtgv_Product_Ingredient.Columns["quantity"].DisplayIndex = 2;        // Số Lượng
            dtgv_Product_Ingredient.Columns["price"].DisplayIndex = 3;           // Giá

            dtgv_Product_Ingredient.Columns["ingredient_id"].Width = 150;
            dtgv_Product_Ingredient.Columns["ingredient_name"].Width = 250;
            dtgv_Product_Ingredient.Columns["quantity"].Width = 150;
            dtgv_Product_Ingredient.Columns["price"].Width = 150;
        }

        private void txt_SearchIngredientProduct_TextChanged(object sender, EventArgs e)
        {
            string searchName = txt_SearchIngredientProduct.Text.Trim().ToLower();

            // Lấy danh sách nguyên liệu của sản phẩm
            List<m_Product_Ingredient> lst_p_is = bll_p_i.getListIngredientFromProduct(product.product_code);

            // Kiểm tra danh sách rỗng
            if (lst_p_is == null || lst_p_is.Count == 0)
                return;

            // Lọc danh sách dựa trên tên nguyên liệu
            var filteredList = lst_p_is
                .Where(p => bll_i.getIngredientName(p.ingredient_id).ToLower().Contains(searchName))
                .ToList();

            // Gán dữ liệu đã lọc vào DataGridView
            dtgv_Product_Ingredient.DataSource = null;
            dtgv_Product_Ingredient.DataSource = filteredList;

            // Cập nhật lại cột "Tên Nguyên Liệu"
            foreach (DataGridViewRow row in dtgv_Product_Ingredient.Rows)
            {
                if (row.Cells["ingredient_id"].Value != null)
                {
                    string ingredientId = row.Cells["ingredient_id"].Value.ToString();
                    row.Cells["ingredient_name"].Value = bll_i.getIngredientName(ingredientId);
                }
            }

            dtgv_Product_Ingredient.Columns["product_code"].Visible = false;

            dtgv_Product_Ingredient.Columns["ingredient_id"].HeaderText = "Mã Nguyên Liệu";
            dtgv_Product_Ingredient.Columns["ingredient_name"].HeaderText = "Tên Nguyên Liệu";
            dtgv_Product_Ingredient.Columns["quantity"].HeaderText = "Số Lượng";
            dtgv_Product_Ingredient.Columns["price"].HeaderText = "Giá";

            dtgv_Product_Ingredient.Columns["ingredient_id"].DisplayIndex = 0;   // Mã Nguyên Liệu
            dtgv_Product_Ingredient.Columns["ingredient_name"].DisplayIndex = 1; // Tên Nguyên Liệu
            dtgv_Product_Ingredient.Columns["quantity"].DisplayIndex = 2;        // Số Lượng
            dtgv_Product_Ingredient.Columns["price"].DisplayIndex = 3;           // Giá

            dtgv_Product_Ingredient.Columns["ingredient_id"].Width = 150;
            dtgv_Product_Ingredient.Columns["ingredient_name"].Width = 250;
            dtgv_Product_Ingredient.Columns["quantity"].Width = 150;
            dtgv_Product_Ingredient.Columns["price"].Width = 150;
        }

        private void dtgv_Product_Ingredient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Product_Ingredient.SelectedRows.Count > 0)
            {
                DataGridViewRow clickedRow = dtgv_Product_Ingredient.SelectedRows[0];
                txt_Quantity.Text = clickedRow.Cells[3].Value.ToString().Trim();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_Quantity.Text))
            {
                MessageBox.Show("Vui lòng nhập số > 0", "Thông báo!");
                return;
            }

            if (dtgv_Product_Ingredient.SelectedRows.Count > 0)
            {
                DataGridViewRow clickedRow = dtgv_Product_Ingredient.SelectedRows[0];
                string ingredient_id = clickedRow.Cells[1].Value.ToString().Trim();
                int quantity = int.Parse(txt_Quantity.Text.Trim());

                m_Product_Ingredient item = new m_Product_Ingredient();
                item.ingredient_id = ingredient_id;
                item.quantity = quantity;
                item.product_code = product.product_code;

                if(!bll_p_i.updateProductIngredient(item))
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                loadProductIngredientGroup();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (dtgv_Ingredient.SelectedRows.Count > 0)
            {
                DataGridViewRow clickedRow = dtgv_Ingredient.SelectedRows[0];
                string ingredient_id = clickedRow.Cells[0].Value.ToString().Trim();

                if (!bll_p_i.insertProductIngredient(product.product_code, ingredient_id))
                {
                    MessageBox.Show("Lỗi!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                loadIngredientGroup();
                loadProductIngredientGroup();
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (dtgv_Product_Ingredient.SelectedRows.Count > 0)
            {
                DataGridViewRow clickedRow = dtgv_Product_Ingredient.SelectedRows[0];
                string ingredient_id = clickedRow.Cells[1].Value.ToString().Trim();

                if (!bll_p_i.deleteProductIngredient(product.product_code, ingredient_id))
                {
                    MessageBox.Show("Lỗi!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                loadIngredientGroup();
                loadProductIngredientGroup();
            }
        }
    }
}
