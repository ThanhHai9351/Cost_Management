using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using OfficeOpenXml;

namespace Cost_Management
{
    public partial class frm_Ingredient : Form
    {
        BLL_Ingredient bll_i = new BLL_Ingredient();
        List<t_Ingredient> lst_i_data = new List<t_Ingredient>();

        int handle_status = -1; //-1 là không có gì , 0 là thêm , 1 là sửa
        public frm_Ingredient()
        {
            InitializeComponent();
        }

        private void frm_Ingredient_Load(object sender, EventArgs e)
        {
            loadIngredientGroup();
            loadIngredientImportExcelGroup();
        }

        public void loadIngredientImportExcelGroup()
        {
            btn_ImportExcel.Enabled = true;
            btn_AddIngredientData.Enabled = false;

            dtgv_ImportExcel.DataSource = null;
            lst_i_data.Clear();
        }

        public void loadIngredientGroup()
        {
            loadIngredientTable();
            resetComponentsIngredient();
        }

        public void loadIngredientTable()
        {
            List<t_Ingredient> lst_is = bll_i.getIngredients();
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

        public void resetComponentsIngredient()
        {
            txt_IdIngredient.Text = "";
            txt_NameIngredient.Text = "";
            txt_Price.Text = "";
            txt_Unit.Text = "";

            txt_IdIngredient.Enabled = false;
            txt_NameIngredient.Enabled = false;
            txt_Unit.Enabled = false;
            txt_Price.Enabled = false;

            btn_CreateIngredient.Enabled = true;
            btn_EditIngredient.Enabled = false;
            btn_DeleteIngredient.Enabled = false;
            btn_SaveChangeIngredient.Enabled = false;
        }

        private void btn_CancerIngredient_Click(object sender, EventArgs e)
        {
            loadIngredientGroup();
        }

        private void btn_CreateIngredient_Click(object sender, EventArgs e)
        {
            txt_IdIngredient.Enabled = true;
            txt_NameIngredient.Enabled = true;
            txt_Price.Enabled = true;
            txt_Unit.Enabled = true;

            btn_CreateIngredient.Enabled = false;
            btn_SaveChangeIngredient.Enabled = true;

            handle_status = 0;
        }

        private void btn_SaveChangeIngredient_Click(object sender, EventArgs e)
        {
            string ingredient_id = txt_IdIngredient.Text.Trim();
            string ingredient_name = txt_NameIngredient.Text.Trim();
            string unit = txt_Unit.Text.Trim();

            if(string.IsNullOrEmpty(ingredient_id) || string.IsNullOrEmpty(ingredient_name) || string.IsNullOrEmpty(unit) || string.IsNullOrEmpty(txt_Price.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo!");
                return;
            }
            int price = int.Parse(txt_Price.Text.Trim());
            if(price <= 0)
            {
                MessageBox.Show("Giá phải là số dương", "Thông báo!");
                return;
            }    
            //Kiểm tra hành động thêm hay sửa
            if(handle_status == 0) // hành động thêm
            {
                if(bll_i.checkIngredientId(ingredient_id))
                {
                    MessageBox.Show("Mã nguyên liệu này đã có. Vui lòng điền mã khác!", "Thông báo!");
                    return;
                }
                //Thêm nguyên liệu
                t_Ingredient item = new t_Ingredient();
                item.ingredient_id = ingredient_id;
                item.ingredient_name = ingredient_name;
                item.unit = unit;
                item.price_per_unit = price;
                if(!bll_i.insertIngredient(item))
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo!");
                    return;
                }
                MessageBox.Show("Thêm thành công!", "Thông báo!");
                loadIngredientGroup();
            }    
            if(handle_status == 1) // hành động sửa
            {
                t_Ingredient item = new t_Ingredient();
                item.ingredient_id = ingredient_id;
                item.ingredient_name = ingredient_name;
                item.unit = unit;
                item.price_per_unit = price;

                if (!bll_i.updateIngredient(item))
                {
                    MessageBox.Show("Sửa thất bại!", "Thông báo!");
                    return;
                }
                MessageBox.Show("Sửa thành công!", "Thông báo!");
                loadIngredientGroup();
            }
        }

        private void dtgv_Ingredient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dtgv_Ingredient.Rows[e.RowIndex];
                txt_IdIngredient.Text = clickedRow.Cells[0].Value.ToString().Trim();
                txt_NameIngredient.Text = clickedRow.Cells[1].Value.ToString().Trim();
                txt_Unit.Text = clickedRow.Cells[2].Value.ToString().Trim();
                txt_Price.Text = clickedRow.Cells[3].Value.ToString().Trim();

                btn_CreateIngredient.Enabled = false;
                btn_EditIngredient.Enabled = true;
                btn_DeleteIngredient.Enabled = true;
            }
        }

        private void btn_EditIngredient_Click(object sender, EventArgs e)
        {
            btn_EditIngredient.Enabled = false;
            btn_DeleteIngredient.Enabled = false;
            btn_SaveChangeIngredient.Enabled = true;

            txt_NameIngredient.Enabled = true;
            txt_Price.Enabled = true;
            txt_Unit.Enabled = true;

            handle_status = 1;
        }

        private void btn_DeleteIngredient_Click(object sender, EventArgs e)
        {
            if (dtgv_Ingredient.SelectedRows.Count > 0)
            {
                DataGridViewRow clickedRow = dtgv_Ingredient.SelectedRows[0];
                string ingredient_id = clickedRow.Cells[0].Value.ToString().Trim();
                string ingredient_name = clickedRow.Cells[1].Value.ToString().Trim();

                if (MessageBox.Show("Bạn có muốn xóa "+ingredient_name+" không?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if(!bll_i.deleteIngredient(ingredient_id))
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo!");
                        return;
                    }
                    MessageBox.Show("Xóa thành công!", "Thông báo!");
                    loadIngredientGroup();
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

                btn_AddIngredientData.Enabled = true;
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

                    // Lọc các cột theo tiêu đề "Mã nguyên liệu" và "Tên Nguyên Liệu" và "ĐVT" và "Giá"
                    List<int> selectedColumns = new List<int>();

                    // Đọc tiêu đề của cột (dòng đầu tiên trong Excel)
                    for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                    {
                        string header = worksheet.Cells[1, col].Text;
                        if (header.ToLower() == "mã nguyên liệu" || header.ToLower() == "tên nguyên vật liệu" || header.ToLower() == "đvt" || header.ToLower() == "giá")
                        {
                            dt.Columns.Add(header);
                            selectedColumns.Add(col); // Lưu vị trí cột phù hợp
                        }
                    }

                    // Đọc dữ liệu từ Excel vào DataTable chỉ cho các cột đã chọn
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        DataRow dataRow = dt.NewRow();
                        t_Ingredient ingredient = new t_Ingredient(); // Khởi tạo đối tượng t_Ingredient

                        for (int i = 0; i < selectedColumns.Count; i++)
                        {
                            int col = selectedColumns[i];
                            // Đảm bảo dữ liệu được đọc dưới dạng giá trị thực tế, không phải tham chiếu ô
                            string cellValue = worksheet.Cells[row, col].Value?.ToString().Trim() ?? "";


                            if (i == 3) // The "Giá" column
                            {
                                // Try to parse the price, default to 0 if parsing fails
                                if (!int.TryParse(cellValue, out int price))
                                {
                                    MessageBox.Show($"Invalid price format in row {row}: {cellValue}. Setting price to 0.");
                                    price = 0; // Default value for invalid price
                                }
                                ingredient.price_per_unit = price;
                            }
                            // Chuyển giá trị ô thành đối tượng t_Ingredient
                            if (i == 0) ingredient.ingredient_id = cellValue;      // Mã vật tư
                            if (i == 1) ingredient.ingredient_name = cellValue;    // Tên vật tư
                            if (i == 2) ingredient.unit = cellValue;      //  Đơn vị trí
                            //if (i == 3) material.price_per_unit = int.Parse(cellValue);    // Giá

                            dataRow[i] = cellValue;
                        }
                        lst_i_data.Add(ingredient);
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
            loadIngredientImportExcelGroup();
        }

        private void btn_AddIngredientData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có xác nhận thêm dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<t_Ingredient> list_contains = bll_i.checkContainIngredient(lst_i_data);
                if (list_contains != null && list_contains.Count > 0)
                {
                    string message_info = "";
                    foreach (t_Ingredient item in list_contains)
                    {
                        message_info += item.ingredient_id + ",";
                    }
                    if (MessageBox.Show("Các mã loại sản phẩm sau đã tồn tại: " + message_info + ". Thêm và bỏ qua chúng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (bll_i.insertListIngredients(lst_i_data))
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo!");
                            loadIngredientImportExcelGroup();
                            loadIngredientGroup();
                            return;
                        }
                        MessageBox.Show("Thêm thất bại!", "Thông báo");
                    }
                }
                else
                {
                    if (bll_i.insertListIngredients(lst_i_data))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo!");
                        loadIngredientImportExcelGroup();
                        loadIngredientGroup();
                        return;
                    }
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
                }
            }
        }
    }
}
