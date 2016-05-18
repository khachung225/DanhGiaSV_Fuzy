using System;
using System.Windows.Forms;

namespace NhanSetGiaoVien
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
            if (AppGlobal.Giaovien != null)
            {
                var dagia = new frmDanhGia(AppGlobal.Giaovien.MaGv);
                dagia.Show();
                dagia.TopMost = true;
            }
            else
            {
                đăngNhậpToolStripMenuItem_Click(sender, e);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void kQRenLuyenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmKQNhanSet();
            frm.Show();
            frm.TopMost = true;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (AppGlobal.Giaovien != null)
            {
                if(!this.Text.Contains(" - GV:"))
                    this.Text += @" - GV: " + AppGlobal.Giaovien.TenGiaoVien;
            }
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gv = new ShowListData(1);
            gv.Show();
            gv.TopMost = true;
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gv = new ShowListData(2);
            gv.Show();
            gv.TopMost = true;
        }
    }
}
