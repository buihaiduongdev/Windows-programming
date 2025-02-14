using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (this.txtDangNhap.Text == "trinh" && this.txtMatKhau.Text == "123")
                MessageBox.Show("Bạn đã đăng nhập thành công");
            else
                MessageBox.Show("Vui lòng nhập lại", "Thông báo");
            this.txtDangNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if(thongbao == DialogResult.Yes)
                Application.Exit();
        }
    }
}
