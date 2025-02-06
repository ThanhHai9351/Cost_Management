using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using DAL;

namespace Cost_Management
{
    public partial class frm_ViewProduct : Form
    {
        List<t_Ingredient> lst_ts = new List<t_Ingredient>(); 
        public frm_ViewProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadExcelToDataGridView(filePath);
            }
        }

        private void LoadExcelToDataGridView(string filePath)
        {
            try
            {
                // Đặt bối cảnh giấy phép trước khi sử dụng EPPlus
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                FileInfo fileInfo = new FileInfo(filePath);
                using (var package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Chọn sheet đầu tiên
                    DataTable dt = new DataTable();

                    // Lọc các cột theo tiêu đề "Mã Vật Tư" và "Tên Vật Tư"
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

                            // Chuyển giá trị ô thành đối tượng t_Ingredient
                            if (i == 0) ingredient.ingredient_id = cellValue;      // Mã nguyên liệu
                            if (i == 1) ingredient.ingredient_name = cellValue;    // Tên nguyên liệu
                            if (i == 2) ingredient.unit = cellValue;              // ĐVT
                            if (i == 3) ingredient.price_per_unit = string.IsNullOrEmpty(cellValue) ? (int?)null : int.Parse(cellValue); // Giá

                            dataRow[i] = cellValue;
                        }
                        lst_ts.Add(ingredient);
                        dt.Rows.Add(dataRow);
                    }

                    // Đưa dữ liệu vào DataGridView
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đọc file Excel: " + ex.Message);
            }
        }

        private void frm_ViewProduct_Load(object sender, EventArgs e)
        {
            
        }
    }
}
