
namespace Cost_Management
{
    partial class frm_CreateMaterialType
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
            this.btn_CancerMaterialType = new System.Windows.Forms.Button();
            this.btn_CreateMaterialType = new System.Windows.Forms.Button();
            this.btn_AutoGenarateId = new System.Windows.Forms.Button();
            this.txt_NameMaterialType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IdMaterialType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv_MaterialType = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_CancerImportExcel = new System.Windows.Forms.Button();
            this.btn_AddMaterialTypeData = new System.Windows.Forms.Button();
            this.btn_ImportExcel = new System.Windows.Forms.Button();
            this.dtgv_ImportExcel = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MaterialType)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ImportExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1522, 77);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM LOẠI VẬT TƯ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CancerMaterialType);
            this.groupBox1.Controls.Add(this.btn_CreateMaterialType);
            this.groupBox1.Controls.Add(this.btn_AutoGenarateId);
            this.groupBox1.Controls.Add(this.txt_NameMaterialType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_IdMaterialType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtgv_MaterialType);
            this.groupBox1.Location = new System.Drawing.Point(22, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 567);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại Vật Tư";
            // 
            // btn_CancerMaterialType
            // 
            this.btn_CancerMaterialType.Location = new System.Drawing.Point(350, 499);
            this.btn_CancerMaterialType.Name = "btn_CancerMaterialType";
            this.btn_CancerMaterialType.Size = new System.Drawing.Size(103, 51);
            this.btn_CancerMaterialType.TabIndex = 19;
            this.btn_CancerMaterialType.Text = "Hủy thao tác";
            this.btn_CancerMaterialType.UseVisualStyleBackColor = true;
            this.btn_CancerMaterialType.Click += new System.EventHandler(this.btn_CancerMaterialType_Click);
            // 
            // btn_CreateMaterialType
            // 
            this.btn_CreateMaterialType.Location = new System.Drawing.Point(206, 501);
            this.btn_CreateMaterialType.Name = "btn_CreateMaterialType";
            this.btn_CreateMaterialType.Size = new System.Drawing.Size(105, 49);
            this.btn_CreateMaterialType.TabIndex = 18;
            this.btn_CreateMaterialType.Text = "Thêm dữ liệu";
            this.btn_CreateMaterialType.UseVisualStyleBackColor = true;
            this.btn_CreateMaterialType.Click += new System.EventHandler(this.btn_CreateMaterialType_Click);
            // 
            // btn_AutoGenarateId
            // 
            this.btn_AutoGenarateId.Location = new System.Drawing.Point(394, 404);
            this.btn_AutoGenarateId.Name = "btn_AutoGenarateId";
            this.btn_AutoGenarateId.Size = new System.Drawing.Size(123, 63);
            this.btn_AutoGenarateId.TabIndex = 17;
            this.btn_AutoGenarateId.Text = "Tạo mã tự động";
            this.btn_AutoGenarateId.UseVisualStyleBackColor = true;
            // 
            // txt_NameMaterialType
            // 
            this.txt_NameMaterialType.Location = new System.Drawing.Point(159, 454);
            this.txt_NameMaterialType.Name = "txt_NameMaterialType";
            this.txt_NameMaterialType.Size = new System.Drawing.Size(204, 22);
            this.txt_NameMaterialType.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên Loại Vật Tư:";
            // 
            // txt_IdMaterialType
            // 
            this.txt_IdMaterialType.Location = new System.Drawing.Point(159, 406);
            this.txt_IdMaterialType.Name = "txt_IdMaterialType";
            this.txt_IdMaterialType.Size = new System.Drawing.Size(204, 22);
            this.txt_IdMaterialType.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Loại Vật Tư:";
            // 
            // dtgv_MaterialType
            // 
            this.dtgv_MaterialType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_MaterialType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_MaterialType.Location = new System.Drawing.Point(28, 37);
            this.dtgv_MaterialType.Name = "dtgv_MaterialType";
            this.dtgv_MaterialType.RowHeadersWidth = 51;
            this.dtgv_MaterialType.RowTemplate.Height = 24;
            this.dtgv_MaterialType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_MaterialType.Size = new System.Drawing.Size(726, 305);
            this.dtgv_MaterialType.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_CancerImportExcel);
            this.groupBox2.Controls.Add(this.btn_AddMaterialTypeData);
            this.groupBox2.Controls.Add(this.btn_ImportExcel);
            this.groupBox2.Controls.Add(this.dtgv_ImportExcel);
            this.groupBox2.Location = new System.Drawing.Point(887, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 444);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm dữ liệu bằng file";
            // 
            // btn_CancerImportExcel
            // 
            this.btn_CancerImportExcel.Location = new System.Drawing.Point(380, 364);
            this.btn_CancerImportExcel.Name = "btn_CancerImportExcel";
            this.btn_CancerImportExcel.Size = new System.Drawing.Size(103, 51);
            this.btn_CancerImportExcel.TabIndex = 9;
            this.btn_CancerImportExcel.Text = "Hủy thao tác";
            this.btn_CancerImportExcel.UseVisualStyleBackColor = true;
            this.btn_CancerImportExcel.Click += new System.EventHandler(this.btn_CancerImportExcel_Click);
            // 
            // btn_AddMaterialTypeData
            // 
            this.btn_AddMaterialTypeData.Location = new System.Drawing.Point(237, 364);
            this.btn_AddMaterialTypeData.Name = "btn_AddMaterialTypeData";
            this.btn_AddMaterialTypeData.Size = new System.Drawing.Size(125, 51);
            this.btn_AddMaterialTypeData.TabIndex = 8;
            this.btn_AddMaterialTypeData.Text = "Thêm dữ liệu";
            this.btn_AddMaterialTypeData.UseVisualStyleBackColor = true;
            this.btn_AddMaterialTypeData.Click += new System.EventHandler(this.btn_AddMaterialTypeData_Click);
            // 
            // btn_ImportExcel
            // 
            this.btn_ImportExcel.Location = new System.Drawing.Point(114, 364);
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
            this.dtgv_ImportExcel.Size = new System.Drawing.Size(595, 305);
            this.dtgv_ImportExcel.TabIndex = 6;
            // 
            // frm_CreateMaterialType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 704);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_CreateMaterialType";
            this.Text = "frm_CreateMaterialType";
            this.Load += new System.EventHandler(this.frm_CreateMaterialType_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MaterialType)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ImportExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_CancerMaterialType;
        private System.Windows.Forms.Button btn_CreateMaterialType;
        private System.Windows.Forms.Button btn_AutoGenarateId;
        private System.Windows.Forms.TextBox txt_NameMaterialType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IdMaterialType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgv_MaterialType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_CancerImportExcel;
        private System.Windows.Forms.Button btn_AddMaterialTypeData;
        private System.Windows.Forms.Button btn_ImportExcel;
        private System.Windows.Forms.DataGridView dtgv_ImportExcel;
    }
}