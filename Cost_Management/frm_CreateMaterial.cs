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
    public partial class frm_CreateMaterial : Form
    {
        BLL_MaterialType bll_mt = new BLL_MaterialType();
        BLL_Material bll_m = new BLL_Material();

        List<t_Material> lst_m_data = new List<t_Material>();
        public frm_CreateMaterial()
        {
            InitializeComponent();
        }

        private void frm_CreateMaterial_Load(object sender, EventArgs e)
        {
            loadCBOFilterMaterialType();
            loadMaterialGroup();
            loadImportExcelGroup();
        }

        public void loadImportExcelGroup()
        {
            btn_ImportExcel.Enabled = true;
            btn_AddMaterialData.Enabled = false;

            dtgv_ImportExcel.DataSource = null;
        }

        public void loadMaterialGroup()
        {
            loadMaterialTable();
            txt_IdMaterial.Text = "";
            txt_NameMaterial.Text = "";
            txt_Unit.Text = "";
            txt_Price.Text = "";
        }

        public void loadCBOFilterMaterialType()
        {
            List<t_Material_Type> list_materialtypes = bll_mt.getMaterialTypes();
            cbo_MaterialType.DataSource = list_materialtypes;
            cbo_MaterialType.DisplayMember = "material_type_name";
            cbo_MaterialType.ValueMember = "material_type_id";
        }

        public void loadMaterialTable()
        {
            List<t_Material> lst_ms = bll_m.getMaterials().OrderBy(m => m.material_name).ToList();
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

        private void btn_CancerMaterial_Click(object sender, EventArgs e)
        {
            loadMaterialGroup();
        }

        private void btn_CreateMaterial_Click(object sender, EventArgs e)
        {
            string material_type_id = cbo_MaterialType.SelectedValue.ToString();
            string material_id = txt_IdMaterial.Text.Trim();
            string material_name = txt_NameMaterial.Text.Trim();
            string unit = txt_Unit.Text.Trim();
            if(string.IsNullOrEmpty(material_id)||string.IsNullOrEmpty(material_type_id)||string.IsNullOrEmpty(material_name) || string.IsNullOrEmpty(unit) || string.IsNullOrEmpty(txt_Price.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!","Thông báo!");
                return;
            }
            int price = int.Parse(txt_Price.Text.Trim());

            if (price <= 0)
            {
                MessageBox.Show("Giá vui lòng nhập số dương!", "Thông báo!");
                return;
            }    
            
            if(bll_m.checkMaterialId(material_id))
            {
                MessageBox.Show("Mã vật tư này đã có! Vui lòng điền mã khác!", "Thông báo!");
                return;
            }

            t_Material item = new t_Material();
            item.material_id = material_id;
            item.material_name = material_name;
            item.unit = unit;
            item.price_per_unit = price;
            item.material_type_id = material_type_id;

            if(!bll_m.insertMaterial(item))
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo!");
                return;
            }
            MessageBox.Show("Thêm thành công!", "Thông báo!");
            btn_CancerMaterial_Click(sender, e);
        }

        private void cbo_MaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string material_type_id = cbo_MaterialType.SelectedValue.ToString();
            List<t_Material> list_materials = bll_m.getMaterials().Where(m => m.material_type_id == material_type_id).ToList();

            dtgv_Material.DataSource = list_materials;
        }

        private void btn_ImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                loadExcelToDataGridView(filePath);

                btn_AddMaterialData.Enabled = true;
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

                    // Lọc các cột theo tiêu đề "Mã vật tư" và "Tên Nguyên Vật Liệu" và "ĐVT" và "Giá"
                    List<int> selectedColumns = new List<int>();

                    // Đọc tiêu đề của cột (dòng đầu tiên trong Excel)
                    for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                    {
                        string header = worksheet.Cells[1, col].Text;
                        if (header.ToLower() == "mã vật tư" || header.ToLower() == "tên vật tư" || header.ToLower() == "đvt"||header.ToLower() == "giá")
                        {
                            dt.Columns.Add(header);
                            selectedColumns.Add(col); // Lưu vị trí cột phù hợp
                        }
                    }

                    // Đọc dữ liệu từ Excel vào DataTable chỉ cho các cột đã chọn
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        DataRow dataRow = dt.NewRow();
                        t_Material material = new t_Material(); // Khởi tạo đối tượng t_Material_Type

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
                                material.price_per_unit = price;
                            }
                            // Chuyển giá trị ô thành đối tượng t_Material
                            if (i == 0) material.material_id = cellValue;      // Mã vật tư
                            if (i == 1) material.material_name = cellValue;    // Tên vật tư
                            if (i == 2) material.unit = cellValue;      //  Đơn vị trí
                            //if (i == 3) material.price_per_unit = int.Parse(cellValue);    // Giá

                            dataRow[i] = cellValue;
                        }
                        lst_m_data.Add(material);
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


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_CancerImportExcel_Click(object sender, EventArgs e)
        {
            loadImportExcelGroup();
        }

        public void verifyListMaterial()
        {
            foreach(t_Material item in lst_m_data)
            {
                item.material_type_id = cbo_MaterialType.SelectedValue.ToString().Trim();
            }    
        }

        private void btn_AddMaterialData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có xác nhận thêm dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<t_Material> list_contains = bll_m.checkContainMaterial(lst_m_data);
                if (list_contains != null && list_contains.Count > 0)
                {
                    string message_info = "";
                    foreach (t_Material item in list_contains)
                    {
                        message_info += item.material_id + ",";
                    }
                    if (MessageBox.Show("Các mã loại sản phẩm sau đã tồn tại: " + message_info + ". Thêm và bỏ qua chúng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        verifyListMaterial();
                        if (bll_m.insertListMaterials(lst_m_data))
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo!");
                            loadImportExcelGroup();
                            loadMaterialGroup();
                            return;
                        }
                        MessageBox.Show("Thêm thất bại!", "Thông báo");
                    }
                }
                else
                {
                    verifyListMaterial();
                    if (bll_m.insertListMaterials(lst_m_data))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo!");
                        loadImportExcelGroup();
                        loadMaterialGroup();
                        return;
                    }
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
                }
            }
        }
    }
}
