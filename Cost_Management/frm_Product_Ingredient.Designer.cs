
namespace Cost_Management
{
    partial class frm_Product_Ingredient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Product_Ingredient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_ProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv_Ingredient = new System.Windows.Forms.DataGridView();
            this.btn_ReLoadIngredient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_SearchIngredient = new System.Windows.Forms.TextBox();
            this.cbo_FilterIngredient = new System.Windows.Forms.ComboBox();
            this.gb_Product = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dtgv_Product_Ingredient = new System.Windows.Forms.DataGridView();
            this.btn_ReloadIngredientProduct = new System.Windows.Forms.Button();
            this.cbo_FilterIngredientProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SearchIngredientProduct = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.txt_Quantity = new Custom_Field.TextNumber();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Ingredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Product_Ingredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_ProductName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1673, 77);
            this.panel1.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_Ingredient);
            this.groupBox1.Controls.Add(this.btn_ReLoadIngredient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txt_SearchIngredient);
            this.groupBox1.Controls.Add(this.cbo_FilterIngredient);
            this.groupBox1.Location = new System.Drawing.Point(35, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 438);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nguyên liệu";
            // 
            // dtgv_Ingredient
            // 
            this.dtgv_Ingredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Ingredient.Location = new System.Drawing.Point(6, 80);
            this.dtgv_Ingredient.Name = "dtgv_Ingredient";
            this.dtgv_Ingredient.RowHeadersWidth = 51;
            this.dtgv_Ingredient.RowTemplate.Height = 24;
            this.dtgv_Ingredient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Ingredient.Size = new System.Drawing.Size(673, 336);
            this.dtgv_Ingredient.TabIndex = 12;
            // 
            // btn_ReLoadIngredient
            // 
            this.btn_ReLoadIngredient.Location = new System.Drawing.Point(522, 24);
            this.btn_ReLoadIngredient.Name = "btn_ReLoadIngredient";
            this.btn_ReLoadIngredient.Size = new System.Drawing.Size(157, 40);
            this.btn_ReLoadIngredient.TabIndex = 11;
            this.btn_ReLoadIngredient.Text = "Reload";
            this.btn_ReLoadIngredient.UseVisualStyleBackColor = true;
            this.btn_ReLoadIngredient.Click += new System.EventHandler(this.btn_ReLoadIngredient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sắp xếp theo";
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
            // txt_SearchIngredient
            // 
            this.txt_SearchIngredient.Location = new System.Drawing.Point(42, 33);
            this.txt_SearchIngredient.Name = "txt_SearchIngredient";
            this.txt_SearchIngredient.Size = new System.Drawing.Size(148, 22);
            this.txt_SearchIngredient.TabIndex = 8;
            this.txt_SearchIngredient.TextChanged += new System.EventHandler(this.txt_SearchIngredient_TextChanged);
            // 
            // cbo_FilterIngredient
            // 
            this.cbo_FilterIngredient.FormattingEnabled = true;
            this.cbo_FilterIngredient.Location = new System.Drawing.Point(369, 32);
            this.cbo_FilterIngredient.Name = "cbo_FilterIngredient";
            this.cbo_FilterIngredient.Size = new System.Drawing.Size(121, 24);
            this.cbo_FilterIngredient.TabIndex = 7;
            this.cbo_FilterIngredient.SelectedIndexChanged += new System.EventHandler(this.cbo_FilterIngredient_SelectedIndexChanged);
            // 
            // gb_Product
            // 
            this.gb_Product.Controls.Add(this.txt_Quantity);
            this.gb_Product.Controls.Add(this.label5);
            this.gb_Product.Controls.Add(this.btn_Save);
            this.gb_Product.Controls.Add(this.dtgv_Product_Ingredient);
            this.gb_Product.Controls.Add(this.btn_ReloadIngredientProduct);
            this.gb_Product.Controls.Add(this.cbo_FilterIngredientProduct);
            this.gb_Product.Controls.Add(this.label1);
            this.gb_Product.Controls.Add(this.txt_SearchIngredientProduct);
            this.gb_Product.Controls.Add(this.pictureBox2);
            this.gb_Product.Location = new System.Drawing.Point(932, 115);
            this.gb_Product.Name = "gb_Product";
            this.gb_Product.Size = new System.Drawing.Size(701, 527);
            this.gb_Product.TabIndex = 3;
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
            this.btn_Save.Location = new System.Drawing.Point(339, 440);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(113, 55);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dtgv_Product_Ingredient
            // 
            this.dtgv_Product_Ingredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Product_Ingredient.Location = new System.Drawing.Point(6, 80);
            this.dtgv_Product_Ingredient.Name = "dtgv_Product_Ingredient";
            this.dtgv_Product_Ingredient.RowHeadersWidth = 51;
            this.dtgv_Product_Ingredient.RowTemplate.Height = 24;
            this.dtgv_Product_Ingredient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Product_Ingredient.Size = new System.Drawing.Size(673, 336);
            this.dtgv_Product_Ingredient.TabIndex = 12;
            this.dtgv_Product_Ingredient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Product_Ingredient_CellClick);
            // 
            // btn_ReloadIngredientProduct
            // 
            this.btn_ReloadIngredientProduct.Location = new System.Drawing.Point(522, 24);
            this.btn_ReloadIngredientProduct.Name = "btn_ReloadIngredientProduct";
            this.btn_ReloadIngredientProduct.Size = new System.Drawing.Size(157, 40);
            this.btn_ReloadIngredientProduct.TabIndex = 11;
            this.btn_ReloadIngredientProduct.Text = "Reload";
            this.btn_ReloadIngredientProduct.UseVisualStyleBackColor = true;
            this.btn_ReloadIngredientProduct.Click += new System.EventHandler(this.btn_ReloadIngredientProduct_Click);
            // 
            // cbo_FilterIngredientProduct
            // 
            this.cbo_FilterIngredientProduct.FormattingEnabled = true;
            this.cbo_FilterIngredientProduct.Location = new System.Drawing.Point(369, 32);
            this.cbo_FilterIngredientProduct.Name = "cbo_FilterIngredientProduct";
            this.cbo_FilterIngredientProduct.Size = new System.Drawing.Size(121, 24);
            this.cbo_FilterIngredientProduct.TabIndex = 7;
            this.cbo_FilterIngredientProduct.SelectedIndexChanged += new System.EventHandler(this.cbo_FilterIngredientProduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sắp xếp theo";
            // 
            // txt_SearchIngredientProduct
            // 
            this.txt_SearchIngredientProduct.Location = new System.Drawing.Point(42, 33);
            this.txt_SearchIngredientProduct.Name = "txt_SearchIngredientProduct";
            this.txt_SearchIngredientProduct.Size = new System.Drawing.Size(148, 22);
            this.txt_SearchIngredientProduct.TabIndex = 8;
            this.txt_SearchIngredientProduct.TextChanged += new System.EventHandler(this.txt_SearchIngredientProduct_TextChanged);
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
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(767, 275);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(135, 54);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = ">";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(767, 355);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(135, 54);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.Text = "<";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(157, 459);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(151, 22);
            this.txt_Quantity.TabIndex = 41;
            // 
            // frm_Product_Ingredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 721);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.gb_Product);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Product_Ingredient";
            this.Text = "Sản phẩm _ Nguyên liệu";
            this.Load += new System.EventHandler(this.frm_Product_Ingredient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Ingredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_Product.ResumeLayout(false);
            this.gb_Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Product_Ingredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_ProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_Product;
        private System.Windows.Forms.DataGridView dtgv_Ingredient;
        private System.Windows.Forms.Button btn_ReLoadIngredient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_SearchIngredient;
        private System.Windows.Forms.ComboBox cbo_FilterIngredient;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dtgv_Product_Ingredient;
        private System.Windows.Forms.Button btn_ReloadIngredientProduct;
        private System.Windows.Forms.ComboBox cbo_FilterIngredientProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SearchIngredientProduct;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label label5;
        private Custom_Field.TextNumber txt_Quantity;
    }
}