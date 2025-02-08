using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cost_Management
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
            this.FormClosing += frm_Main_FormClosing;
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            thoátToolStripMenuItem_Click(sender, e);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn thoát!","Thông báo", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                frm_Login frm = new frm_Login();
                frm.Show();
                this.Hide();
            }    
        }

        public void showForm(Form frm)
        {
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void xemVậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ViewMaterial frm = new frm_ViewMaterial();
            showForm(frm);
        }

        private void thêmLoạiVậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CreateMaterialType frm = new frm_CreateMaterialType();
            showForm(frm);
        }

        private void thêmVậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CreateMaterial frm = new frm_CreateMaterial();
            showForm(frm);
        }

        private void quảnLýNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ingredient frm = new frm_Ingredient();
            showForm(frm);
        }

        private void QLSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Product frm = new frm_Product();
            showForm(frm);
        }

        private void traCứuGiáToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_PriceLookup frm = new frm_PriceLookup();
            showForm(frm);
        }
    }
}
