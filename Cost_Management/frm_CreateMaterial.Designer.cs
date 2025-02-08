
namespace Cost_Management
{
    partial class frm_CreateMaterial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Price = new Custom_Field.TextNumber();
            this.btn_CancerMaterial = new System.Windows.Forms.Button();
            this.btn_CreateMaterial = new System.Windows.Forms.Button();
            this.btn_AutoGenarateId = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NameMaterial = new System.Windows.Forms.TextBox();
            this.txt_Unit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_IdMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv_Material = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_CancerImportExcel = new System.Windows.Forms.Button();
            this.btn_AddMaterialData = new System.Windows.Forms.Button();
            this.btn_ImportExcel = new System.Windows.Forms.Button();
            this.dtgv_ImportExcel = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbo_MaterialType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Material)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ImportExcel)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1431, 77);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM VẬT TƯ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.btn_CancerMaterial);
            this.groupBox1.Controls.Add(this.btn_CreateMaterial);
            this.groupBox1.Controls.Add(this.btn_AutoGenarateId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_NameMaterial);
            this.groupBox1.Controls.Add(this.txt_Unit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_IdMaterial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtgv_Material);
            this.groupBox1.Location = new System.Drawing.Point(33, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 609);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vật tư";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(391, 476);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(165, 22);
            this.txt_Price.TabIndex = 27;
            // 
            // btn_CancerMaterial
            // 
            this.btn_CancerMaterial.Location = new System.Drawing.Point(365, 538);
            this.btn_CancerMaterial.Name = "btn_CancerMaterial";
            this.btn_CancerMaterial.Size = new System.Drawing.Size(103, 51);
            this.btn_CancerMaterial.TabIndex = 26;
            this.btn_CancerMaterial.Text = "Hủy thao tác";
            this.btn_CancerMaterial.UseVisualStyleBackColor = true;
            this.btn_CancerMaterial.Click += new System.EventHandler(this.btn_CancerMaterial_Click);
            // 
            // btn_CreateMaterial
            // 
            this.btn_CreateMaterial.Location = new System.Drawing.Point(221, 540);
            this.btn_CreateMaterial.Name = "btn_CreateMaterial";
            this.btn_CreateMaterial.Size = new System.Drawing.Size(105, 49);
            this.btn_CreateMaterial.TabIndex = 25;
            this.btn_CreateMaterial.Text = "Thêm dữ liệu";
            this.btn_CreateMaterial.UseVisualStyleBackColor = true;
            this.btn_CreateMaterial.Click += new System.EventHandler(this.btn_CreateMaterial_Click);
            // 
            // btn_AutoGenarateId
            // 
            this.btn_AutoGenarateId.Location = new System.Drawing.Point(573, 426);
            this.btn_AutoGenarateId.Name = "btn_AutoGenarateId";
            this.btn_AutoGenarateId.Size = new System.Drawing.Size(123, 63);
            this.btn_AutoGenarateId.TabIndex = 24;
            this.btn_AutoGenarateId.Text = "Tạo mã tự động";
            this.btn_AutoGenarateId.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Giá:";
            // 
            // txt_NameMaterial
            // 
            this.txt_NameMaterial.Location = new System.Drawing.Point(116, 477);
            this.txt_NameMaterial.Name = "txt_NameMaterial";
            this.txt_NameMaterial.Size = new System.Drawing.Size(165, 22);
            this.txt_NameMaterial.TabIndex = 22;
            // 
            // txt_Unit
            // 
            this.txt_Unit.Location = new System.Drawing.Point(391, 432);
            this.txt_Unit.Name = "txt_Unit";
            this.txt_Unit.Size = new System.Drawing.Size(165, 22);
            this.txt_Unit.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên Vật Tư:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Đơn vị tính:";
            // 
            // txt_IdMaterial
            // 
            this.txt_IdMaterial.Location = new System.Drawing.Point(116, 430);
            this.txt_IdMaterial.Name = "txt_IdMaterial";
            this.txt_IdMaterial.Size = new System.Drawing.Size(165, 22);
            this.txt_IdMaterial.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã Vật Tư:";
            // 
            // dtgv_Material
            // 
            this.dtgv_Material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Material.Location = new System.Drawing.Point(6, 36);
            this.dtgv_Material.Name = "dtgv_Material";
            this.dtgv_Material.RowHeadersWidth = 51;
            this.dtgv_Material.RowTemplate.Height = 24;
            this.dtgv_Material.Size = new System.Drawing.Size(690, 350);
            this.dtgv_Material.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_CancerImportExcel);
            this.groupBox2.Controls.Add(this.btn_AddMaterialData);
            this.groupBox2.Controls.Add(this.btn_ImportExcel);
            this.groupBox2.Controls.Add(this.dtgv_ImportExcel);
            this.groupBox2.Location = new System.Drawing.Point(711, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 489);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm dữ liệu bằng file";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_CancerImportExcel
            // 
            this.btn_CancerImportExcel.Location = new System.Drawing.Point(412, 418);
            this.btn_CancerImportExcel.Name = "btn_CancerImportExcel";
            this.btn_CancerImportExcel.Size = new System.Drawing.Size(103, 51);
            this.btn_CancerImportExcel.TabIndex = 9;
            this.btn_CancerImportExcel.Text = "Hủy thao tác";
            this.btn_CancerImportExcel.UseVisualStyleBackColor = true;
            this.btn_CancerImportExcel.Click += new System.EventHandler(this.btn_CancerImportExcel_Click);
            // 
            // btn_AddMaterialData
            // 
            this.btn_AddMaterialData.Location = new System.Drawing.Point(269, 418);
            this.btn_AddMaterialData.Name = "btn_AddMaterialData";
            this.btn_AddMaterialData.Size = new System.Drawing.Size(125, 51);
            this.btn_AddMaterialData.TabIndex = 8;
            this.btn_AddMaterialData.Text = "Thêm dữ liệu";
            this.btn_AddMaterialData.UseVisualStyleBackColor = true;
            this.btn_AddMaterialData.Click += new System.EventHandler(this.btn_AddMaterialData_Click);
            // 
            // btn_ImportExcel
            // 
            this.btn_ImportExcel.Location = new System.Drawing.Point(146, 418);
            this.btn_ImportExcel.Name = "btn_ImportExcel";
            this.btn_ImportExcel.Size = new System.Drawing.Size(102, 51);
            this.btn_ImportExcel.TabIndex = 7;
            this.btn_ImportExcel.Text = "Import Excel";
            this.btn_ImportExcel.UseVisualStyleBackColor = true;
            this.btn_ImportExcel.Click += new System.EventHandler(this.btn_ImportExcel_Click);
            // 
            // dtgv_ImportExcel
            // 
            this.dtgv_ImportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_ImportExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ImportExcel.Location = new System.Drawing.Point(17, 37);
            this.dtgv_ImportExcel.Name = "dtgv_ImportExcel";
            this.dtgv_ImportExcel.RowHeadersWidth = 51;
            this.dtgv_ImportExcel.RowTemplate.Height = 24;
            this.dtgv_ImportExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ImportExcel.Size = new System.Drawing.Size(617, 349);
            this.dtgv_ImportExcel.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbo_MaterialType);
            this.groupBox3.Location = new System.Drawing.Point(34, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 81);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại vật tư";
            // 
            // cbo_MaterialType
            // 
            this.cbo_MaterialType.FormattingEnabled = true;
            this.cbo_MaterialType.Location = new System.Drawing.Point(36, 31);
            this.cbo_MaterialType.Name = "cbo_MaterialType";
            this.cbo_MaterialType.Size = new System.Drawing.Size(208, 24);
            this.cbo_MaterialType.TabIndex = 10;
            this.cbo_MaterialType.SelectedIndexChanged += new System.EventHandler(this.cbo_MaterialType_SelectedIndexChanged);
            // 
            // frm_CreateMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1452, 748);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_CreateMaterial";
            this.Text = "frm_CreateMaterial";
            this.Load += new System.EventHandler(this.frm_CreateMaterial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Material)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ImportExcel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgv_Material;
        private System.Windows.Forms.Button btn_CancerMaterial;
        private System.Windows.Forms.Button btn_CreateMaterial;
        private System.Windows.Forms.Button btn_AutoGenarateId;
        private System.Windows.Forms.TextBox txt_NameMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IdMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_CancerImportExcel;
        private System.Windows.Forms.Button btn_AddMaterialData;
        private System.Windows.Forms.Button btn_ImportExcel;
        private System.Windows.Forms.DataGridView dtgv_ImportExcel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Unit;
        private System.Windows.Forms.Label label4;
        private Custom_Field.TextNumber txt_Price;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbo_MaterialType;
    }
}