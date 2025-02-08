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
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;

namespace Cost_Management
{
    public partial class frm_PriceLookup : Form
    {
        BLL_Product bll_p = new BLL_Product();
        BLL_Product_Ingredient bll_p_i = new BLL_Product_Ingredient();
        BLL_Ingredient bll_i = new BLL_Ingredient();
        BLL_Product_Material bll_p_m = new BLL_Product_Material();
        BLL_Material bll_m = new BLL_Material();
        CultureInfo vietnamCulture = new CultureInfo("vi-VN");

        public frm_PriceLookup()
        {
            InitializeComponent();
        }

        private void frm_PriceLookup_Load(object sender, EventArgs e)
        {
            loadProductTable();
            lb_TotalPrice.Text = "Tổng tiền: 0đ";
            btn_ExportExcel.Enabled = false;
        }

        public void loadProductTable()
        {
            List<t_Product> lst_ps = bll_p.getProducts();
            dtgv_Product.DataSource = lst_ps;

            dtgv_Product.Columns["product_code"].HeaderText = "Mã Sản Phẩm";
            dtgv_Product.Columns["product_name"].HeaderText = "Tên Sản Phẩm";

            dtgv_Product.Columns["product_code"].Width = 150;
            dtgv_Product.Columns["product_name"].Width = 250;
        }

        private void dtgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Product.SelectedRows.Count > 0)
            {
                DataGridViewRow clickedRow = dtgv_Product.SelectedRows[0];
                string product_code = clickedRow.Cells[0].Value.ToString().Trim();
                loadIngredientTable(product_code);
                loadMaterialTable(product_code);
                int total = bll_p_i.getTotalPrice(product_code) + bll_p_m.getTotalPrice(product_code);
                lb_TotalPrice.Text= "Tổng tiền: "+ total.ToString("C0", vietnamCulture);
                btn_ExportExcel.Enabled = true;
            }
        }

        public void loadIngredientTable(string product_code)
        {
            List<m_Product_Ingredient> lst_p_is = bll_p_i.getListIngredientFromProduct(product_code);
            dtgv_Ingredient.DataSource = lst_p_is;

            // Thêm cột "Tên Nguyên Liệu" nếu chưa có
            if (!dtgv_Ingredient.Columns.Contains("ingredient_name"))
            {
                dtgv_Ingredient.Columns.Add("ingredient_name", "Tên Nguyên Liệu");
            }

            // Gán tên nguyên liệu thực tế cho từng dòng
            foreach (DataGridViewRow row in dtgv_Ingredient.Rows)
            {
                if (row.Cells["ingredient_id"].Value != null)
                {
                    string ingredientId = row.Cells["ingredient_id"].Value.ToString();
                    row.Cells["ingredient_name"].Value = bll_i.getIngredientName(ingredientId); // Lấy tên nguyên liệu
                }
            }

            dtgv_Ingredient.Columns["product_code"].Visible = false;
            dtgv_Ingredient.Columns["t_Ingredient"].Visible = false;
            dtgv_Ingredient.Columns["t_Product"].Visible = false;

            dtgv_Ingredient.Columns["ingredient_id"].HeaderText = "Mã Nguyên Liệu";
            dtgv_Ingredient.Columns["ingredient_name"].HeaderText = "Tên Nguyên Liệu";
            dtgv_Ingredient.Columns["quantity"].HeaderText = "Số Lượng";
            dtgv_Ingredient.Columns["price"].HeaderText = "Giá";

            dtgv_Ingredient.Columns["ingredient_id"].DisplayIndex = 0;   // Mã Nguyên Liệu
            dtgv_Ingredient.Columns["ingredient_name"].DisplayIndex = 1; // Tên Nguyên Liệu
            dtgv_Ingredient.Columns["quantity"].DisplayIndex = 2;        // Số Lượng
            dtgv_Ingredient.Columns["price"].DisplayIndex = 3;           // Giá

            dtgv_Ingredient.Columns["ingredient_id"].Width = 150;
            dtgv_Ingredient.Columns["ingredient_name"].Width = 250;
            dtgv_Ingredient.Columns["quantity"].Width = 150;
            dtgv_Ingredient.Columns["price"].Width = 150;
        }

        public void loadMaterialTable(string product_code)
        {
            List<m_Product_Material> lst_p_ms = bll_p_m.getListMaterialsFromProduct(product_code);

            dtgv_Material.DataSource = lst_p_ms;

            // Thêm cột "Tên Vật Liệu" nếu chưa có
            if (!dtgv_Material.Columns.Contains("material_name"))
            {
                dtgv_Material.Columns.Add("material_name", "Tên Vật Liệu");
            }

            // Gán tên nguyên liệu thực tế cho từng dòng
            foreach (DataGridViewRow row in dtgv_Material.Rows)
            {
                if (row.Cells["material_id"].Value != null)
                {
                    string materialId = row.Cells["material_id"].Value.ToString();
                    row.Cells["material_name"].Value = bll_m.getMaterialName(materialId); // Lấy tên vật liệu
                }
            }

            dtgv_Material.Columns["product_code"].Visible = false;
            dtgv_Material.Columns["t_Material"].Visible = false;
            dtgv_Material.Columns["t_Product"].Visible = false;

            dtgv_Material.Columns["material_id"].HeaderText = "Mã Nguyên Liệu";
            dtgv_Material.Columns["material_name"].HeaderText = "Tên Nguyên Liệu";
            dtgv_Material.Columns["quantity"].HeaderText = "Số Lượng";
            dtgv_Material.Columns["price"].HeaderText = "Giá";

            dtgv_Material.Columns["material_id"].DisplayIndex = 0;   // Mã Vật Liệu
            dtgv_Material.Columns["material_name"].DisplayIndex = 1; // Tên Vật Liệu
            dtgv_Material.Columns["quantity"].DisplayIndex = 2;        // Số Lượng
            dtgv_Material.Columns["price"].DisplayIndex = 3;           // Giá

            dtgv_Material.Columns["material_id"].Width = 150;
            dtgv_Material.Columns["material_name"].Width = 250;
            dtgv_Material.Columns["quantity"].Width = 150;
            dtgv_Material.Columns["price"].Width = 150;
        }

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            if (dtgv_Product.SelectedRows.Count > 0)
            {
                DataGridViewRow clickedRow = dtgv_Product.SelectedRows[0];
                string product_code = clickedRow.Cells["product_code"].Value.ToString().Trim();
                string product_name = clickedRow.Cells["product_name"].Value.ToString().Trim();
                t_Product item_product = new t_Product();
                item_product.product_code = product_code;
                item_product.product_name = product_name;
                // Tạo ứng dụng Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;  // Không hiển thị Excel trong lúc xử lý

                // Tạo Workbook mới
                Excel.Workbook workbook = excelApp.Workbooks.Add();

                // Xuất từng bảng vào từng Sheet
                exportListIngredientsToSheet(workbook, bll_p_i.getListIngredientFromProduct(product_code), "Nguyên liệu");
                exportListMaterialsToSheet(workbook, bll_p_m.getListMaterialsFromProduct(product_code), "Vật liệu");
                exportProductToSheet(workbook, item_product, "Sản phẩm");

                // Hiển thị Excel sau khi hoàn thành
                excelApp.Visible = true;
            }
        }

        private void exportListMaterialsToSheet(Excel.Workbook workbook, List<m_Product_Material> lists, string sheetName)
        {
            Excel.Worksheet worksheet = workbook.Sheets.Add();
            worksheet.Name = sheetName;

            // Danh sách tiêu đề hiển thị
            var headers = new[] { "Mã vật liệu", "Tên vật liệu", "Số lượng", "Giá" };
            var properties = new[] { "material_id", "quantity", "price" };

            // Ghi tiêu đề cột
            for (int i = 0; i < headers.Length; i++)
            {
                worksheet.Cells[1, i + 1] = headers[i];  // Hiển thị tiêu đề tiếng Việt
            }

            // Ghi dữ liệu từ danh sách vào Excel (bắt đầu từ hàng 2)
            for (int i = 0; i < lists.Count; i++)
            {
                object[] rowData = {
                lists[i].material_id,                       // Cột 1: Mã vật liệu
                bll_m.getMaterialName(lists[i].material_id), // Cột 2: Tên vật liệu
                lists[i].quantity,                            // Cột 3: Số lượng
                lists[i].price                                // Cột 4: Giá
            };

                // Ghi vào từng ô trên cùng một hàng
                for (int j = 0; j < rowData.Length; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = rowData[j]?.ToString();
                }
            }

            // Định dạng tiêu đề
            Excel.Range headerRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, headers.Length]];
            headerRange.Font.Bold = true;
            headerRange.Interior.Color = Excel.XlRgbColor.rgbLightBlue;

            // Tự động căn chỉnh độ rộng cột
            worksheet.Columns.AutoFit();
        }

        private void exportListIngredientsToSheet(Excel.Workbook workbook, List<m_Product_Ingredient> lists, string sheetName)
        {
            Excel.Worksheet worksheet = workbook.Sheets.Add();
            worksheet.Name = sheetName;

            // Danh sách tiêu đề hiển thị
            var headers = new[] { "Mã nguyên liệu", "Tên nguyên liệu", "Số lượng", "Giá" };
            var properties = new[] { "ingredient_id", "quantity", "price" }; 

            // Ghi tiêu đề cột
            for (int i = 0; i < headers.Length; i++)
            {
                worksheet.Cells[1, i + 1] = headers[i];  // Hiển thị tiêu đề tiếng Việt
            }

            // Ghi dữ liệu từ danh sách vào Excel (bắt đầu từ hàng 2)
            for (int i = 0; i < lists.Count; i++)
            {
                    object[] rowData = {
                lists[i].ingredient_id,                       // Cột 1: Mã nguyên liệu
                bll_i.getIngredientName(lists[i].ingredient_id), // Cột 2: Tên nguyên liệu
                lists[i].quantity,                            // Cột 3: Số lượng
                lists[i].price                                // Cột 4: Giá
            };

                // Ghi vào từng ô trên cùng một hàng
                for (int j = 0; j < rowData.Length; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = rowData[j]?.ToString();
                }
            }

            // Định dạng tiêu đề
            Excel.Range headerRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, headers.Length]];
            headerRange.Font.Bold = true;
            headerRange.Interior.Color = Excel.XlRgbColor.rgbLightBlue;

            // Tự động căn chỉnh độ rộng cột
            worksheet.Columns.AutoFit();
        }


        private void exportProductToSheet(Excel.Workbook workbook, t_Product product, string sheetName)
        {
            Excel.Worksheet worksheet = workbook.Sheets.Add();
            worksheet.Name = sheetName;

            // Danh sách tiêu đề hiển thị
            var headers = new[] { "Mã sản phẩm", "Tên sản phẩm" };
            var properties = new[] { "product_code", "product_name" };

            // Ghi tiêu đề cột
            for (int i = 0; i < headers.Length; i++)
            {
                worksheet.Cells[1, i + 1] = headers[i];  // Hiển thị tiêu đề tiếng Việt
            }

            // Ghi dữ liệu của product vào hàng thứ 2
            for (int j = 0; j < properties.Length; j++)
            {
                var value = typeof(t_Product).GetProperty(properties[j]).GetValue(product, null);
                worksheet.Cells[2, j + 1] = value != null ? value.ToString() : "";
            }

            // Định dạng tiêu đề
            Excel.Range headerRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, properties.Length]];
            headerRange.Font.Bold = true;
            headerRange.Interior.Color = Excel.XlRgbColor.rgbLightBlue;

            // Tự động căn chỉnh độ rộng cột
            worksheet.Columns.AutoFit();
        }

    }
}
