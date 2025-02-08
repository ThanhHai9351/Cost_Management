
namespace Cost_Management
{
    partial class frm_Product_Material
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Quantity = new Custom_Field.TextNumber();
            this.gb_Product = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dtgv_Product_Material = new System.Windows.Forms.DataGridView();
            this.btn_ReloadMaterialProduct = new System.Windows.Forms.Button();
            this.txt_SearchMaterialProduct = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbo_FilterMaterialType = new System.Windows.Forms.ComboBox();
            this.dtgv_Material = new System.Windows.Forms.DataGridView();
            this.btn_ReLoadMaterial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_SearchMaterial = new System.Windows.Forms.TextBox();
            this.lb_ProductName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Product_Material)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Material)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cost_Management.Properties.Resources.transparency;
            this.pictureBox1.Location = new System.Drawing.Point(14, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(765, 351);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(135, 54);
            this.btn_Remove.TabIndex = 10;
            this.btn_Remove.Text = "<";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(765, 271);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(135, 54);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = ">";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(157, 454);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(151, 22);
            this.txt_Quantity.TabIndex = 41;
            // 
            // gb_Product
            // 
            this.gb_Product.Controls.Add(this.txt_Quantity);
            this.gb_Product.Controls.Add(this.label5);
            this.gb_Product.Controls.Add(this.btn_Save);
            this.gb_Product.Controls.Add(this.dtgv_Product_Material);
            this.gb_Product.Controls.Add(this.btn_ReloadMaterialProduct);
            this.gb_Product.Controls.Add(this.txt_SearchMaterialProduct);
            this.gb_Product.Controls.Add(this.pictureBox2);
            this.gb_Product.Location = new System.Drawing.Point(930, 111);
            this.gb_Product.Name = "gb_Product";
            this.gb_Product.Size = new System.Drawing.Size(701, 527);
            this.gb_Product.TabIndex = 7;
            this.gb_Product.TabStop = false;
            this.gb_Product.Text = "Tên sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Số lượng:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(337, 438);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(113, 55);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dtgv_Product_Material
            // 
            this.dtgv_Product_Material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Product_Material.Location = new System.Drawing.Point(6, 80);
            this.dtgv_Product_Material.Name = "dtgv_Product_Material";
            this.dtgv_Product_Material.RowHeadersWidth = 51;
            this.dtgv_Product_Material.RowTemplate.Height = 24;
            this.dtgv_Product_Material.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Product_Material.Size = new System.Drawing.Size(673, 336);
            this.dtgv_Product_Material.TabIndex = 12;
            this.dtgv_Product_Material.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Product_Material_CellClick);
            // 
            // btn_ReloadMaterialProduct
            // 
            this.btn_ReloadMaterialProduct.Location = new System.Drawing.Point(522, 24);
            this.btn_ReloadMaterialProduct.Name = "btn_ReloadMaterialProduct";
            this.btn_ReloadMaterialProduct.Size = new System.Drawing.Size(157, 40);
            this.btn_ReloadMaterialProduct.TabIndex = 11;
            this.btn_ReloadMaterialProduct.Text = "Reload";
            this.btn_ReloadMaterialProduct.UseVisualStyleBackColor = true;
            this.btn_ReloadMaterialProduct.Click += new System.EventHandler(this.btn_ReloadMaterialProduct_Click);
            // 
            // txt_SearchMaterialProduct
            // 
            this.txt_SearchMaterialProduct.Location = new System.Drawing.Point(42, 33);
            this.txt_SearchMaterialProduct.Name = "txt_SearchMaterialProduct";
            this.txt_SearchMaterialProduct.Size = new System.Drawing.Size(148, 22);
            this.txt_SearchMaterialProduct.TabIndex = 8;
            this.txt_SearchMaterialProduct.TextChanged += new System.EventHandler(this.txt_SearchMaterialProduct_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cost_Management.Properties.Resources.transparency;
            this.pictureBox2.Location = new System.Drawing.Point(14, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // cbo_FilterMaterialType
            // 
            this.cbo_FilterMaterialType.FormattingEnabled = true;
            this.cbo_FilterMaterialType.Location = new System.Drawing.Point(369, 32);
            this.cbo_FilterMaterialType.Name = "cbo_FilterMaterialType";
            this.cbo_FilterMaterialType.Size = new System.Drawing.Size(121, 24);
            this.cbo_FilterMaterialType.TabIndex = 7;
            this.cbo_FilterMaterialType.SelectedIndexChanged += new System.EventHandler(this.cbo_FilterMaterialType_SelectedIndexChanged);
            // 
            // dtgv_Material
            // 
            this.dtgv_Material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Material.Location = new System.Drawing.Point(6, 80);
            this.dtgv_Material.Name = "dtgv_Material";
            this.dtgv_Material.RowHeadersWidth = 51;
            this.dtgv_Material.RowTemplate.Height = 24;
            this.dtgv_Material.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Material.Size = new System.Drawing.Size(673, 336);
            this.dtgv_Material.TabIndex = 12;
            // 
            // btn_ReLoadMaterial
            // 
            this.btn_ReLoadMaterial.Location = new System.Drawing.Point(522, 24);
            this.btn_ReLoadMaterial.Name = "btn_ReLoadMaterial";
            this.btn_ReLoadMaterial.Size = new System.Drawing.Size(157, 40);
            this.btn_ReLoadMaterial.TabIndex = 11;
            this.btn_ReLoadMaterial.Text = "Reload";
            this.btn_ReLoadMaterial.UseVisualStyleBackColor = true;
            this.btn_ReLoadMaterial.Click += new System.EventHandler(this.btn_ReLoadMaterial_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Loại vật tư:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_Material);
            this.groupBox1.Controls.Add(this.btn_ReLoadMaterial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txt_SearchMaterial);
            this.groupBox1.Controls.Add(this.cbo_FilterMaterialType);
            this.groupBox1.Location = new System.Drawing.Point(33, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 438);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vật tư";
            // 
            // txt_SearchMaterial
            // 
            this.txt_SearchMaterial.Location = new System.Drawing.Point(42, 33);
            this.txt_SearchMaterial.Name = "txt_SearchMaterial";
            this.txt_SearchMaterial.Size = new System.Drawing.Size(148, 22);
            this.txt_SearchMaterial.TabIndex = 8;
            this.txt_SearchMaterial.TextChanged += new System.EventHandler(this.txt_SearchMaterial_TextChanged);
            // 
            // lb_ProductName
            // 
            this.lb_ProductName.AutoSize = true;
            this.lb_ProductName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProductName.Location = new System.Drawing.Point(28, 25);
            this.lb_ProductName.Name = "lb_ProductName";
            this.lb_ProductName.Size = new System.Drawing.Size(196, 29);
            this.lb_ProductName.TabIndex = 0;
            this.lb_ProductName.Text = "TÊN SẢN PHẨM";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_ProductName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1673, 77);
            this.panel1.TabIndex = 6;
            // 
            // frm_Product_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 691);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.gb_Product);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Product_Material";
            this.Text = "Sản phẩm _ Vật tư";
            this.Load += new System.EventHandler(this.frm_Product_Material_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_Product.ResumeLayout(false);
            this.gb_Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Product_Material)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Material)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        private Custom_Field.TextNumber txt_Quantity;
        private System.Windows.Forms.GroupBox gb_Product;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dtgv_Product_Material;
        private System.Windows.Forms.Button btn_ReloadMaterialProduct;
        private System.Windows.Forms.TextBox txt_SearchMaterialProduct;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbo_FilterMaterialType;
        private System.Windows.Forms.DataGridView dtgv_Material;
        private System.Windows.Forms.Button btn_ReLoadMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_SearchMaterial;
        private System.Windows.Forms.Label lb_ProductName;
        private System.Windows.Forms.Panel panel1;
    }
}