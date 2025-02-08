
namespace Cost_Management
{
    partial class frm_PriceLookup
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgv_Product = new System.Windows.Forms.DataGridView();
            this.dtgv_Ingredient = new System.Windows.Forms.DataGridView();
            this.dtgv_Material = new System.Windows.Forms.DataGridView();
            this.lb_TotalPrice = new System.Windows.Forms.Label();
            this.btn_ExportExcel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Ingredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Material)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 77);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRA CỨU GIÁ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ExportExcel);
            this.groupBox1.Controls.Add(this.lb_TotalPrice);
            this.groupBox1.Controls.Add(this.dtgv_Product);
            this.groupBox1.Location = new System.Drawing.Point(63, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 595);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_Ingredient);
            this.groupBox2.Location = new System.Drawing.Point(744, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 325);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nguyên liệu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgv_Material);
            this.groupBox3.Location = new System.Drawing.Point(744, 427);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 323);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vật liệu";
            // 
            // dtgv_Product
            // 
            this.dtgv_Product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Product.Location = new System.Drawing.Point(6, 42);
            this.dtgv_Product.Name = "dtgv_Product";
            this.dtgv_Product.RowHeadersWidth = 51;
            this.dtgv_Product.RowTemplate.Height = 24;
            this.dtgv_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Product.Size = new System.Drawing.Size(605, 433);
            this.dtgv_Product.TabIndex = 0;
            this.dtgv_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Product_CellClick);
            // 
            // dtgv_Ingredient
            // 
            this.dtgv_Ingredient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_Ingredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Ingredient.Location = new System.Drawing.Point(12, 42);
            this.dtgv_Ingredient.Name = "dtgv_Ingredient";
            this.dtgv_Ingredient.RowHeadersWidth = 51;
            this.dtgv_Ingredient.RowTemplate.Height = 24;
            this.dtgv_Ingredient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Ingredient.Size = new System.Drawing.Size(636, 263);
            this.dtgv_Ingredient.TabIndex = 1;
            // 
            // dtgv_Material
            // 
            this.dtgv_Material.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_Material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Material.Location = new System.Drawing.Point(18, 36);
            this.dtgv_Material.Name = "dtgv_Material";
            this.dtgv_Material.RowHeadersWidth = 51;
            this.dtgv_Material.RowTemplate.Height = 24;
            this.dtgv_Material.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Material.Size = new System.Drawing.Size(636, 263);
            this.dtgv_Material.TabIndex = 1;
            // 
            // lb_TotalPrice
            // 
            this.lb_TotalPrice.AutoSize = true;
            this.lb_TotalPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalPrice.Location = new System.Drawing.Point(26, 516);
            this.lb_TotalPrice.Name = "lb_TotalPrice";
            this.lb_TotalPrice.Size = new System.Drawing.Size(137, 19);
            this.lb_TotalPrice.TabIndex = 1;
            this.lb_TotalPrice.Text = "Tổng tiền: 3.000đ";
            // 
            // btn_ExportExcel
            // 
            this.btn_ExportExcel.Location = new System.Drawing.Point(489, 499);
            this.btn_ExportExcel.Name = "btn_ExportExcel";
            this.btn_ExportExcel.Size = new System.Drawing.Size(122, 54);
            this.btn_ExportExcel.TabIndex = 2;
            this.btn_ExportExcel.Text = "Export Excel";
            this.btn_ExportExcel.UseVisualStyleBackColor = true;
            this.btn_ExportExcel.Click += new System.EventHandler(this.btn_ExportExcel_Click);
            // 
            // frm_PriceLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1444, 760);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_PriceLookup";
            this.Text = "frm_PriceLookup";
            this.Load += new System.EventHandler(this.frm_PriceLookup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Ingredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Material)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ExportExcel;
        private System.Windows.Forms.Label lb_TotalPrice;
        private System.Windows.Forms.DataGridView dtgv_Product;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgv_Ingredient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgv_Material;
    }
}