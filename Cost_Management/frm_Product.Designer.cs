
namespace Cost_Management
{
    partial class frm_Product
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_CancerImportExcel = new System.Windows.Forms.Button();
            this.btn_AddProductData = new System.Windows.Forms.Button();
            this.btn_ImportExcel = new System.Windows.Forms.Button();
            this.dtgv_ImportExcel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SaveChangeProduct = new System.Windows.Forms.Button();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.btn_AutoGenarateId = new System.Windows.Forms.Button();
            this.btn_EditProduct = new System.Windows.Forms.Button();
            this.txt_NameProduct = new System.Windows.Forms.TextBox();
            this.btn_CancerProduct = new System.Windows.Forms.Button();
            this.btn_CreateProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IdProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv_Product = new System.Windows.Forms.DataGridView();
            this.menu_ProductManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quảnLýNguyênLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýVậtTưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ImportExcel)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Product)).BeginInit();
            this.menu_ProductManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 77);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SẢN PHẨM";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_CancerImportExcel);
            this.groupBox2.Controls.Add(this.btn_AddProductData);
            this.groupBox2.Controls.Add(this.btn_ImportExcel);
            this.groupBox2.Controls.Add(this.dtgv_ImportExcel);
            this.groupBox2.Location = new System.Drawing.Point(874, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 489);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm dữ liệu bằng file";
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
            // btn_AddProductData
            // 
            this.btn_AddProductData.Location = new System.Drawing.Point(269, 418);
            this.btn_AddProductData.Name = "btn_AddProductData";
            this.btn_AddProductData.Size = new System.Drawing.Size(125, 51);
            this.btn_AddProductData.TabIndex = 8;
            this.btn_AddProductData.Text = "Thêm dữ liệu";
            this.btn_AddProductData.UseVisualStyleBackColor = true;
            this.btn_AddProductData.Click += new System.EventHandler(this.btn_AddProductData_Click);
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
            this.dtgv_ImportExcel.Size = new System.Drawing.Size(629, 349);
            this.dtgv_ImportExcel.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SaveChangeProduct);
            this.groupBox1.Controls.Add(this.btn_DeleteProduct);
            this.groupBox1.Controls.Add(this.btn_AutoGenarateId);
            this.groupBox1.Controls.Add(this.btn_EditProduct);
            this.groupBox1.Controls.Add(this.txt_NameProduct);
            this.groupBox1.Controls.Add(this.btn_CancerProduct);
            this.groupBox1.Controls.Add(this.btn_CreateProduct);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_IdProduct);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtgv_Product);
            this.groupBox1.Location = new System.Drawing.Point(9, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 588);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // btn_SaveChangeProduct
            // 
            this.btn_SaveChangeProduct.Location = new System.Drawing.Point(456, 406);
            this.btn_SaveChangeProduct.Name = "btn_SaveChangeProduct";
            this.btn_SaveChangeProduct.Size = new System.Drawing.Size(105, 49);
            this.btn_SaveChangeProduct.TabIndex = 40;
            this.btn_SaveChangeProduct.Text = "Lưu";
            this.btn_SaveChangeProduct.UseVisualStyleBackColor = true;
            this.btn_SaveChangeProduct.Click += new System.EventHandler(this.btn_SaveChangeProduct_Click);
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.Location = new System.Drawing.Point(334, 406);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(105, 49);
            this.btn_DeleteProduct.TabIndex = 40;
            this.btn_DeleteProduct.Text = "Xóa";
            this.btn_DeleteProduct.UseVisualStyleBackColor = true;
            this.btn_DeleteProduct.Click += new System.EventHandler(this.btn_DeleteProduct_Click);
            // 
            // btn_AutoGenarateId
            // 
            this.btn_AutoGenarateId.Location = new System.Drawing.Point(434, 483);
            this.btn_AutoGenarateId.Name = "btn_AutoGenarateId";
            this.btn_AutoGenarateId.Size = new System.Drawing.Size(123, 63);
            this.btn_AutoGenarateId.TabIndex = 35;
            this.btn_AutoGenarateId.Text = "Tạo mã tự động";
            this.btn_AutoGenarateId.UseVisualStyleBackColor = true;
            // 
            // btn_EditProduct
            // 
            this.btn_EditProduct.Location = new System.Drawing.Point(200, 406);
            this.btn_EditProduct.Name = "btn_EditProduct";
            this.btn_EditProduct.Size = new System.Drawing.Size(105, 49);
            this.btn_EditProduct.TabIndex = 39;
            this.btn_EditProduct.Text = "Sửa";
            this.btn_EditProduct.UseVisualStyleBackColor = true;
            this.btn_EditProduct.Click += new System.EventHandler(this.btn_EditProduct_Click);
            // 
            // txt_NameProduct
            // 
            this.txt_NameProduct.Location = new System.Drawing.Point(141, 530);
            this.txt_NameProduct.Name = "txt_NameProduct";
            this.txt_NameProduct.Size = new System.Drawing.Size(165, 22);
            this.txt_NameProduct.TabIndex = 32;
            // 
            // btn_CancerProduct
            // 
            this.btn_CancerProduct.Location = new System.Drawing.Point(583, 403);
            this.btn_CancerProduct.Name = "btn_CancerProduct";
            this.btn_CancerProduct.Size = new System.Drawing.Size(103, 51);
            this.btn_CancerProduct.TabIndex = 37;
            this.btn_CancerProduct.Text = "Hủy thao tác";
            this.btn_CancerProduct.UseVisualStyleBackColor = true;
            this.btn_CancerProduct.Click += new System.EventHandler(this.btn_CancerProduct_Click);
            // 
            // btn_CreateProduct
            // 
            this.btn_CreateProduct.Location = new System.Drawing.Point(67, 405);
            this.btn_CreateProduct.Name = "btn_CreateProduct";
            this.btn_CreateProduct.Size = new System.Drawing.Size(105, 49);
            this.btn_CreateProduct.TabIndex = 36;
            this.btn_CreateProduct.Text = "Thêm";
            this.btn_CreateProduct.UseVisualStyleBackColor = true;
            this.btn_CreateProduct.Click += new System.EventHandler(this.btn_CreateProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // txt_IdProduct
            // 
            this.txt_IdProduct.Location = new System.Drawing.Point(140, 483);
            this.txt_IdProduct.Name = "txt_IdProduct";
            this.txt_IdProduct.Size = new System.Drawing.Size(165, 22);
            this.txt_IdProduct.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // dtgv_Product
            // 
            this.dtgv_Product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Product.ContextMenuStrip = this.menu_ProductManagement;
            this.dtgv_Product.Location = new System.Drawing.Point(6, 37);
            this.dtgv_Product.Name = "dtgv_Product";
            this.dtgv_Product.RowHeadersWidth = 51;
            this.dtgv_Product.RowTemplate.Height = 24;
            this.dtgv_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Product.Size = new System.Drawing.Size(753, 349);
            this.dtgv_Product.TabIndex = 0;
            this.dtgv_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Product_CellClick);
            // 
            // menu_ProductManagement
            // 
            this.menu_ProductManagement.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_ProductManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNguyênLiệuToolStripMenuItem,
            this.quảnLýVậtTưToolStripMenuItem});
            this.menu_ProductManagement.Name = "menu_ProductManagement";
            this.menu_ProductManagement.Size = new System.Drawing.Size(209, 52);
            // 
            // quảnLýNguyênLiệuToolStripMenuItem
            // 
            this.quảnLýNguyênLiệuToolStripMenuItem.Name = "quảnLýNguyênLiệuToolStripMenuItem";
            this.quảnLýNguyênLiệuToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.quảnLýNguyênLiệuToolStripMenuItem.Text = "Quản lý nguyên liệu";
            // 
            // quảnLýVậtTưToolStripMenuItem
            // 
            this.quảnLýVậtTưToolStripMenuItem.Name = "quảnLýVậtTưToolStripMenuItem";
            this.quảnLýVậtTưToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.quảnLýVậtTưToolStripMenuItem.Text = "Quản lý vật tư";
            // 
            // frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 723);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Product";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frm_ViewProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ImportExcel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Product)).EndInit();
            this.menu_ProductManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_CancerImportExcel;
        private System.Windows.Forms.Button btn_AddProductData;
        private System.Windows.Forms.Button btn_ImportExcel;
        private System.Windows.Forms.DataGridView dtgv_ImportExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_DeleteProduct;
        private System.Windows.Forms.Button btn_AutoGenarateId;
        private System.Windows.Forms.Button btn_EditProduct;
        private System.Windows.Forms.TextBox txt_NameProduct;
        private System.Windows.Forms.Button btn_CancerProduct;
        private System.Windows.Forms.Button btn_CreateProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IdProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgv_Product;
        private System.Windows.Forms.Button btn_SaveChangeProduct;
        private System.Windows.Forms.ContextMenuStrip menu_ProductManagement;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNguyênLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýVậtTưToolStripMenuItem;
    }
}