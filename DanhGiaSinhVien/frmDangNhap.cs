using System;
using System.Windows.Forms;

namespace NhanXetSinhVien
{
    public partial class frmDangNhap : Form
    {

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                MessageBox.Show(@"Chưa nhập tên đăng nhập hoặc mật khẩu");

                this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
