using System;
using System.Windows.Forms;
using DatabaseDAL.DAO;
using DatabaseDAL.Entities;

namespace NhanXetSinhVien
{
    public partial class frmDangNhap : Form
    {
        private GIAOVIENDao _giaovienDao = new GIAOVIENDao();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(@"Chưa nhập tên đăng nhập hoặc mật khẩu");
                return;
            }

            var giaovienlohin = _giaovienDao.GetAllBy(GIAOVIEN.GIAOVIENFields.UserLogin, username);
            if (giaovienlohin == null || giaovienlohin.Count == 0)
            {
                MessageBox.Show(@"Không tồn tại tài khoản");
                return;
            }

            if (giaovienlohin[0].Password == password)
            {
                this.Hide();
                AppGlobal.Giaovien = giaovienlohin[0];
            }
            else
            {
                MessageBox.Show(@"Mật khẩu không hợp lệ!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnDangNhap_Click(sender, e);
            }
            if (e.KeyChar == 27)
            {
                btnThoat_Click(sender, e);
            }
        }
    }
}
