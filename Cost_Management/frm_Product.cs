using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DAL;
using BLL;
using OfficeOpenXml;

namespace Cost_Management
{
    public partial class frm_Product : Form
    {
        BLL_Product bll_p = new BLL_Product();
        List<t_Product> lst_p_data = new List<t_Product>();

        int handle_status = -1; //-1 là không có gì , 0 là thêm , 1 là sửa
        public frm_Product()
        {
            InitializeComponent();
        }

        private void frm_ViewProduct_Load(object sender, EventArgs e)
        {
            loadProductGroup();
        }

        public void loadProductGroup()
        {
            loadProductTable();
            loadComponentsProduct();
        }

        public void loadProductImportExcelGroup()
        {
            btn_ImportExcel.Enabled = true;
            btn_AddProductData.Enabled = false;

            dtgv_ImportExcel.DataSource = null;
            lst_p_data.Clear();
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

        public void loadComponentsProduct()
        {
            txt_IdProduct.Text = "";
            txt_NameProduct.Text = "";

            txt_IdProduct.Enabled = false;
            txt_NameProduct.Enabled = false;

            btn_CreateProduct.Enabled = true;
            btn_EditProduct.Enabled = false;
            btn_DeleteProduct.Enabled = false;
            btn_SaveChangeProduct.Enabled = false;
        }

        private void btn_CreateProduct_Click(object sender, EventArgs e)
        {
            btn_CreateProduct.Enabled = false;
            btn_SaveChangeProduct.Enabled = true;
            txt_IdProduct.Enabled = true;
            txt_NameProduct.Enabled = true;

            txt_IdProduct.Text = "";
            txt_NameProduct.Text = "";

            handle_status = 0;
        }

        private void btn_CancerProduct_Click(object sender, EventArgs e)
        {
            loadProductGroup();
        }

        private void btn_SaveChangeProduct_Click(object sender, EventArgs e)
        {
            string product_code = txt_IdProduct.Text.Trim();
            string product_name = txt_NameProduct.Text.Trim();

            if(string.IsNullOrEmpty(product_code)||string.IsNullOrEmpty(product_name))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            if(handle_status == 0)//Hành động thêm
            {
                if(bll_p.checkProductCode(product_code))
                {
                    MessageBox.Show("Mã sản phẩm này đã có. Vui lòng nhập mã khác!", "Thông báo");
                    return;
                }
                t_Product item = new t_Product();
                item.product_code = product_code;
                item.product_name = product_name;

                if(!bll_p.insertProduct(item))
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
                    return;
                }
                MessageBox.Show("Thêm thành công!", "Thông báo");
                loadProductGroup();
            }    

            if(handle_status == 1)//hành động sửa
            {
                t_Product item = new t_Product();
                item.product_code = product_code;
                item.product_name = product_name;
                if (!bll_p.updateProduct(item))
                {
                    MessageBox.Show("Sửa thất bại!", "Thông báo");
                    return;
                }
                MessageBox.Show("Sửa thành công!", "Thông báo");
                loadProductGroup();
            }    
        }

        private void dtgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dtgv_Product.Rows[e.RowIndex];
                txt_IdProduct.Text = clickedRow.Cells[0].Value.ToString().Trim();
                txt_NameProduct.Text = clickedRow.Cells[1].Value.ToString().Trim();

                btn_CreateProduct.Enabled = false;
                btn_EditProduct.Enabled = true;
                btn_DeleteProduct.Enabled = true;
            }
        }

        private void btn_EditProduct_Click(object sender, EventArgs e)
        {
            btn_EditProduct.Enabled = false;
            btn_DeleteProduct.Enabled = false;
            btn_SaveChangeProduct.Enabled = true;

            txt_NameProduct.Enabled = true;

            handle_status = 1;
        }

        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            if (dtgv_Product.SelectedRows.Count > 0)
            {
                DataGridViewRow clickedRow = dtgv_Product.SelectedRows[0];
                string product_code = clickedRow.Cells[0].Value.ToString().Trim();
                string product_name = clickedRow.Cells[1].Value.ToString().Trim();

                if (MessageBox.Show("Bạn có muốn xóa " + product_name + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!bll_p.deleleProduct(product_code))
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo!");
                        return;
                    }
                    MessageBox.Show("Xóa thành công!", "Thông báo!");
                    loadProductGroup();
                }
            }
        }

        private void btn_ImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                loadExcelToDataGridView(filePath);

                btn_AddProductData.Enabled = true;
                btn_ImportExcel.Enabled = false;
            }
        }

        public void loadExcelToDataGridView(string filePath)
        {
            try
            {
                // Đặt bối cảnh giấy phép trước khi sử dụng EPPlus
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                FileInfo fileInfo = new FileInfo(filePath);
                using (var package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Chọn sheet đầu tiên
                    DataTable dt = new DataTable();

                    // Lọc các cột theo tiêu đề "Mã Sản Phẩm" và "Tên Sản Phẩm"
                    List<int> selectedColumns = new List<int>();

                    // Đọc tiêu đề của cột (dòng đầu tiên trong Excel)
                    for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                    {
                        string header = worksheet.Cells[1, col].Text;
                        if (header.ToLower() == "mã sản phẩm" || header.ToLower() == "tên sản phẩm")
                        {
                            dt.Columns.Add(header);
                            selectedColumns.Add(col); // Lưu vị trí cột phù hợp
                        }
                    }

                    // Đọc dữ liệu từ Excel vào DataTable chỉ cho các cột đã chọn
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        DataRow dataRow = dt.NewRow();
                        t_Product product = new t_Product(); // Khởi tạo đối tượng t_Product

                        for (int i = 0; i < selectedColumns.Count; i++)
                        {
                            int col = selectedColumns[i];
                            // Đảm bảo dữ liệu được đọc dưới dạng giá trị thực tế, không phải tham chiếu ô
                            string cellValue = worksheet.Cells[row, col].Value?.ToString().Trim() ?? "";

                            // Chuyển giá trị ô thành đối tượng t_Ingredient
                            if (i == 0) product.product_code = cellValue;      // Mã loại vật tư
                            if (i == 1) product.product_name = cellValue;    // Tên loại vật tư

                            dataRow[i] = cellValue;
                        }
                        lst_p_data.Add(product);
                        dt.Rows.Add(dataRow);
                    }

                    // Đưa dữ liệu vào DataGridView
                    dtgv_ImportExcel.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đọc file Excel: " + ex.Message);
            }
        }

        private void btn_CancerImportExcel_Click(object sender, EventArgs e)
        {
            loadProductImportExcelGroup();
        }

        private void btn_AddProductData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có xác nhận thêm dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<t_Product> list_contains = bll_p.checkContainProducts(lst_p_data);
                if (list_contains != null && list_contains.Count > 0)
                {
                    string message_info = "";
                    foreach (t_Product item in list_contains)
                    {
                        message_info += item.product_code + ",";
                    }
                    if (MessageBox.Show("Các mã loại sản phẩm sau đã tồn tại: " + message_info + ". Thêm và bỏ qua chúng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (bll_p.insertListProducts(lst_p_data))
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo!");
                            loadProductImportExcelGroup();
                            loadProductGroup();
                            return;
                        }
                        MessageBox.Show("Thêm thất bại!", "Thông báo");
                    }
                }
                else
                {
                    if (bll_p.insertListProducts(lst_p_data))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo!");
                        loadProductImportExcelGroup();
                        loadProductGroup();
                        return;
                    }
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
                }
            }
        }

        private void quảnLýNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgv_Product.SelectedRows.Count > 0)
            {
                DataGridViewRow clickedRow = dtgv_Product.SelectedRows[0];
                string product_code = clickedRow.Cells[0].Value.ToString().Trim();
                string product_name = clickedRow.Cells[1].Value.ToString().Trim();

                t_Product p = new t_Product();
                p.product_code = product_code;
                p.product_name = product_name;

                frm_Product_Ingredient frm = new frm_Product_Ingredient(p);
                frm.ShowDialog();
            }
        }
    }
}
