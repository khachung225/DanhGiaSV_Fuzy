using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NhanXetSinhVien
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           timer1.Start();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dangnhap = new frmDangNhap();
            dangnhap.ShowDialog(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            đăngNhậpToolStripMenuItem_Click(sender, e);
            
            timer1.Dispose();
            timer1 = null;
        }
        //nhan set
        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dagia = new frmDanhGia();
            dagia.ShowDialog();
        }
    }
}
