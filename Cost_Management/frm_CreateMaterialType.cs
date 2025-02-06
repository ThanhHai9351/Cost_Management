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
    public partial class frm_CreateMaterialType : Form
    {
        BLL_MaterialType bll_mt = new BLL_MaterialType();
        List<t_Material_Type> lst_mts = null;

        List<t_Material_Type> lst_mt_data = new List<t_Material_Type>();
        public frm_CreateMaterialType()
        {
            InitializeComponent();
        }

        private void frm_CreateMaterialType_Load(object sender, EventArgs e)
        {
            loadMaterialTypeGroup();
            loadImportExcelMaterialTypeGroup();
        }

        public void loadImportExcelMaterialTypeGroup()
        {
            btn_AddMaterialTypeData.Enabled = false;
            btn_ImportExcel.Enabled = true;
            dtgv_ImportExcel.DataSource = null;
            lst_mt_data.Clear();
        }    

        public void loadMaterialTypeGroup()
        {
            loadMaterialTypeTable();
            resetComponentsMaterialType();
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

        public void resetComponentsMaterialType()
        {
            txt_IdMaterialType.Text = "";
            txt_NameMaterialType.Text = "";
        }

        private void btn_CancerMaterialType_Click(object sender, EventArgs e)
        {
            loadMaterialTypeGroup();
        }

        private void btn_CreateMaterialType_Click(object sender, EventArgs e)
        {
            string material_type_id = txt_IdMaterialType.Text.Trim();
            string material_type_name = txt_NameMaterialType.Text.Trim();

            if(string.IsNullOrEmpty(material_type_id)||string.IsNullOrEmpty(material_type_name))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!");
                return;
            }    

            if(bll_mt.checkMaterialTypeId(material_type_id))
            {
                MessageBox.Show("Mã Loại Vật Tư này đã có. Vui lòng đổi mã khác!");
                return;
            }

            t_Material_Type item_add = new t_Material_Type();
            item_add.material_type_id = material_type_id;
            item_add.material_type_name = material_type_name;

            if(bll_mt.insertMaterialType(item_add))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo");
                loadMaterialTypeGroup();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo");
            } 
        }

        private void btn_CancerImportExcel_Click(object sender, EventArgs e)
        {
            loadImportExcelMaterialTypeGroup();
        }

        private void btn_ImportExcel_Click(object sender, EventArgs e)
        {
            loadImportExcelMaterialTypeGroup();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                loadExcelToDataGridView(filePath);

                btn_AddMaterialTypeData.Enabled = true;
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

                    // Lọc các cột theo tiêu đề "Mã Loại Vật Tư" và "Tên Loại Vật Tư"
                    List<int> selectedColumns = new List<int>();

                    // Đọc tiêu đề của cột (dòng đầu tiên trong Excel)
                    for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                    {
                        string header = worksheet.Cells[1, col].Text;
                        if (header.ToLower() == "mã loại vật tư" || header.ToLower() == "tên loại vật tư")
                        {
                            dt.Columns.Add(header);
                            selectedColumns.Add(col); // Lưu vị trí cột phù hợp
                        }
                    }

                    // Đọc dữ liệu từ Excel vào DataTable chỉ cho các cột đã chọn
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        DataRow dataRow = dt.NewRow();
                        t_Material_Type material_type = new t_Material_Type(); // Khởi tạo đối tượng t_Material_Type

                        for (int i = 0; i < selectedColumns.Count; i++)
                        {
                            int col = selectedColumns[i];
                            // Đảm bảo dữ liệu được đọc dưới dạng giá trị thực tế, không phải tham chiếu ô
                            string cellValue = worksheet.Cells[row, col].Value?.ToString().Trim() ?? "";

                            // Chuyển giá trị ô thành đối tượng t_Ingredient
                            if (i == 0) material_type.material_type_id = cellValue;      // Mã loại vật tư
                            if (i == 1) material_type.material_type_name = cellValue;    // Tên loại vật tư

                            dataRow[i] = cellValue;
                        }
                        lst_mt_data.Add(material_type);
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

        private void btn_AddMaterialTypeData_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban có xác nhận thêm dữ liệu?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                List<t_Material_Type> list_contains = bll_mt.checkContainMaterialTye(lst_mt_data);
                if(list_contains != null && list_contains.Count > 0)
                {
                    string message_info = "";
                    foreach(t_Material_Type item in list_contains)
                    {
                        message_info += item.material_type_id + ",";
                    }
                    if(MessageBox.Show("Các mã loại sản phẩm sau đã tồn tại: "+message_info + ". Thêm và bỏ qua chúng?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                    {
                        if(bll_mt.insertListMaterialType(lst_mt_data))
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo!");
                            loadImportExcelMaterialTypeGroup();
                            loadMaterialTypeGroup();
                            return;
                        }
                        MessageBox.Show("Thêm thất bại!", "Thông báo");
                    }
                }
                if (bll_mt.insertListMaterialType(lst_mt_data))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo!");
                    loadImportExcelMaterialTypeGroup();
                    loadMaterialTypeGroup();
                    return;
                }
                MessageBox.Show("Thêm thất bại!", "Thông báo");
            }    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
