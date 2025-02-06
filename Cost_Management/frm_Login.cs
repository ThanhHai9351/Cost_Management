using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


namespace Cost_Management
{
    public partial class frm_Login : Form
    {
        BLL_Account bll_ac = new BLL_Account();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_Password.Focus();
            }    
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string staffid = txt_Username.Text.Trim();
            string pass = txt_Password.Text.Trim();
            if(bll_ac.loginAccount(staffid,pass))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                frm_Main frm = new frm_Main();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo");
            }
        }
    }
}
