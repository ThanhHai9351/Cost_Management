
namespace Cost_Management
{
    partial class frm_Ingredient
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
            this.btn_CancerImportExcel = new System.Windows.Forms.Button();
            this.btn_AddIngredientData = new System.Windows.Forms.Button();
            this.btn_ImportExcel = new System.Windows.Forms.Button();
            this.dtgv_ImportExcel = new System.Windows.Forms.DataGridView();
            this.dtgv_Ingredient = new System.Windows.Forms.DataGridView();
            this.txt_Price = new Custom_Field.TextNumber();
            this.btn_CancerIngredient = new System.Windows.Forms.Button();
            this.btn_CreateIngredient = new System.Windows.Forms.Button();
            this.btn_AutoGenarateId = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NameIngredient = new System.Windows.Forms.TextBox();
            this.txt_Unit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_IdIngredient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_EditIngredient = new System.Windows.Forms.Button();
            this.btn_DeleteIngredient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ImportExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Ingredient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1633, 77);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "NGUYÊN LIỆU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_DeleteIngredient);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.btn_AutoGenarateId);
            this.groupBox1.Controls.Add(this.btn_EditIngredient);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_NameIngredient);
            this.groupBox1.Controls.Add(this.btn_CancerIngredient);
            this.groupBox1.Controls.Add(this.txt_Unit);
            this.groupBox1.Controls.Add(this.btn_CreateIngredient);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_IdIngredient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtgv_Ingredient);
            this.groupBox1.Location = new System.Drawing.Point(50, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 588);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nguyên liệu";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_CancerImportExcel);
            this.groupBox2.Controls.Add(this.btn_AddIngredientData);
            this.groupBox2.Controls.Add(this.btn_ImportExcel);
            this.groupBox2.Controls.Add(this.dtgv_ImportExcel);
            this.groupBox2.Location = new System.Drawing.Point(976, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 489);
            this.groupBox2.TabIndex = 9;
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
            // 
            // btn_AddIngredientData
            // 
            this.btn_AddIngredientData.Location = new System.Drawing.Point(269, 418);
            this.btn_AddIngredientData.Name = "btn_AddIngredientData";
            this.btn_AddIngredientData.Size = new System.Drawing.Size(125, 51);
            this.btn_AddIngredientData.TabIndex = 8;
            this.btn_AddIngredientData.Text = "Thêm dữ liệu";
            this.btn_AddIngredientData.UseVisualStyleBackColor = true;
            // 
            // btn_ImportExcel
            // 
            this.btn_ImportExcel.Location = new System.Drawing.Point(146, 418);
            this.btn_ImportExcel.Name = "btn_ImportExcel";
            this.btn_ImportExcel.Size = new System.Drawing.Size(102, 51);
            this.btn_ImportExcel.TabIndex = 7;
            this.btn_ImportExcel.Text = "Import Excel";
            this.btn_ImportExcel.UseVisualStyleBackColor = true;
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
            // dtgv_Ingredient
            // 
            this.dtgv_Ingredient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_Ingredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Ingredient.Location = new System.Drawing.Point(6, 37);
            this.dtgv_Ingredient.Name = "dtgv_Ingredient";
            this.dtgv_Ingredient.RowHeadersWidth = 51;
            this.dtgv_Ingredient.RowTemplate.Height = 24;
            this.dtgv_Ingredient.Size = new System.Drawing.Size(842, 349);
            this.dtgv_Ingredient.TabIndex = 0;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(432, 530);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(165, 22);
            this.txt_Price.TabIndex = 38;
            // 
            // btn_CancerIngredient
            // 
            this.btn_CancerIngredient.Location = new System.Drawing.Point(565, 401);
            this.btn_CancerIngredient.Name = "btn_CancerIngredient";
            this.btn_CancerIngredient.Size = new System.Drawing.Size(103, 51);
            this.btn_CancerIngredient.TabIndex = 37;
            this.btn_CancerIngredient.Text = "Hủy thao tác";
            this.btn_CancerIngredient.UseVisualStyleBackColor = true;
            // 
            // btn_CreateIngredient
            // 
            this.btn_CreateIngredient.Location = new System.Drawing.Point(160, 402);
            this.btn_CreateIngredient.Name = "btn_CreateIngredient";
            this.btn_CreateIngredient.Size = new System.Drawing.Size(105, 49);
            this.btn_CreateIngredient.TabIndex = 36;
            this.btn_CreateIngredient.Text = "Thêm";
            this.btn_CreateIngredient.UseVisualStyleBackColor = true;
            // 
            // btn_AutoGenarateId
            // 
            this.btn_AutoGenarateId.Location = new System.Drawing.Point(624, 478);
            this.btn_AutoGenarateId.Name = "btn_AutoGenarateId";
            this.btn_AutoGenarateId.Size = new System.Drawing.Size(123, 63);
            this.btn_AutoGenarateId.TabIndex = 35;
            this.btn_AutoGenarateId.Text = "Tạo mã tự động";
            this.btn_AutoGenarateId.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Giá:";
            // 
            // txt_NameIngredient
            // 
            this.txt_NameIngredient.Location = new System.Drawing.Point(141, 530);
            this.txt_NameIngredient.Name = "txt_NameIngredient";
            this.txt_NameIngredient.Size = new System.Drawing.Size(165, 22);
            this.txt_NameIngredient.TabIndex = 32;
            // 
            // txt_Unit
            // 
            this.txt_Unit.Location = new System.Drawing.Point(432, 486);
            this.txt_Unit.Name = "txt_Unit";
            this.txt_Unit.Size = new System.Drawing.Size(165, 22);
            this.txt_Unit.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tên nguyên liệu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Đơn vị tính:";
            // 
            // txt_IdIngredient
            // 
            this.txt_IdIngredient.Location = new System.Drawing.Point(140, 483);
            this.txt_IdIngredient.Name = "txt_IdIngredient";
            this.txt_IdIngredient.Size = new System.Drawing.Size(165, 22);
            this.txt_IdIngredient.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã nguyên liệu:";
            // 
            // btn_EditIngredient
            // 
            this.btn_EditIngredient.Location = new System.Drawing.Point(293, 403);
            this.btn_EditIngredient.Name = "btn_EditIngredient";
            this.btn_EditIngredient.Size = new System.Drawing.Size(105, 49);
            this.btn_EditIngredient.TabIndex = 39;
            this.btn_EditIngredient.Text = "Sửa";
            this.btn_EditIngredient.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteIngredient
            // 
            this.btn_DeleteIngredient.Location = new System.Drawing.Point(427, 403);
            this.btn_DeleteIngredient.Name = "btn_DeleteIngredient";
            this.btn_DeleteIngredient.Size = new System.Drawing.Size(105, 49);
            this.btn_DeleteIngredient.TabIndex = 40;
            this.btn_DeleteIngredient.Text = "Xóa";
            this.btn_DeleteIngredient.UseVisualStyleBackColor = true;
            // 
            // frm_Ingredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 744);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Ingredient";
            this.Text = "frm_ViewIngredient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ImportExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Ingredient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgv_Ingredient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_CancerImportExcel;
        private System.Windows.Forms.Button btn_AddIngredientData;
        private System.Windows.Forms.Button btn_ImportExcel;
        private System.Windows.Forms.DataGridView dtgv_ImportExcel;
        private System.Windows.Forms.Button btn_DeleteIngredient;
        private Custom_Field.TextNumber txt_Price;
        private System.Windows.Forms.Button btn_AutoGenarateId;
        private System.Windows.Forms.Button btn_EditIngredient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NameIngredient;
        private System.Windows.Forms.Button btn_CancerIngredient;
        private System.Windows.Forms.TextBox txt_Unit;
        private System.Windows.Forms.Button btn_CreateIngredient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_IdIngredient;
        private System.Windows.Forms.Label label2;
    }
}