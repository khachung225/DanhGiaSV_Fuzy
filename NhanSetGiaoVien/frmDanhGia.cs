using System;
using System.Linq;
using System.Windows.Forms;
using DatabaseDAL.DAO;
using DatabaseDAL.Entities;

namespace NhanSetGiaoVien
{
    public partial class frmDanhGia : Form
    {


        public int soluongsv = 0;
        public string username = "";

        public frmDanhGia(string _username)
        {
            InitializeComponent();
            username = _username;
            //this.Text = "Quản Lý điểm rèn luyện sinh viên-" + username;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoForm();
            chonsv_SelectedIndexChanged(sender,e);
        }
        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private SINHVIENDao sinvienDao = new SINHVIENDao();
        private TIEUCHUANDao _tieuchuanDao = new TIEUCHUANDao();
        private void KhoiTaoForm()
        {

            var tb = sinvienDao.GetAll(username);//(username);
            var tb1 = _tieuchuanDao.GetAll();

            cbochonsv.DataSource = tb.ToList();
            cbochonsv.DisplayMember = "HOTEN";
            cbochonsv.ValueMember = "MASV";
            
            tc21.DataSource = tb1.ToList();
            tc21.DisplayMember = "TENTIEUCHUAN";
            tc21.ValueMember = "MATIECHUAN";

            tc22.DataSource = tb1.ToList();
            tc22.DisplayMember = "TENTIEUCHUAN";
            tc22.ValueMember = "MATIECHUAN";

            tc23.DataSource = tb1.ToList();
            tc23.DisplayMember = "TENTIEUCHUAN";
            tc23.ValueMember = "MATIECHUAN";

            tc11.DataSource = tb1.ToList();
            tc11.DisplayMember = "TENTIEUCHUAN";
            tc11.ValueMember = "MATIECHUAN";
            
            tc12.DataSource = tb1.ToList();
            tc12.DisplayMember = "TENTIEUCHUAN";
            tc12.ValueMember = "MATIECHUAN";

            tc13.DataSource = tb1.ToList();
            tc13.DisplayMember = "TENTIEUCHUAN";
            tc13.ValueMember = "MATIECHUAN";

            //tieu chuan 3
            tc31.DataSource = tb1.ToList();
            tc31.DisplayMember = "TENTIEUCHUAN";
            tc31.ValueMember = "MATIECHUAN";

            tc32.DataSource = tb1.ToList();
            tc32.DisplayMember = "TENTIEUCHUAN";
            tc32.ValueMember = "MATIECHUAN";

            tc33.DataSource = tb1.ToList();
            tc33.DisplayMember = "TENTIEUCHUAN";
            tc33.ValueMember = "MATIECHUAN";

            tc34.DataSource = tb1.ToList();
            tc34.DisplayMember = "TENTIEUCHUAN";
            tc34.ValueMember = "MATIECHUAN";

            tc35.DataSource = tb1.ToList();
            tc35.DisplayMember = "TENTIEUCHUAN";
            tc35.ValueMember = "MATIECHUAN";

            tc36.DataSource = tb1.ToList();
            tc36.DisplayMember = "TENTIEUCHUAN";
            tc36.ValueMember = "MATIECHUAN";

            tc37.DataSource = tb1.ToList();
            tc37.DisplayMember = "TENTIEUCHUAN";
            tc37.ValueMember = "MATIECHUAN";

            tc38.DataSource = tb1.ToList();
            tc38.DisplayMember = "TENTIEUCHUAN";
            tc38.ValueMember = "MATIECHUAN";

            tc39.DataSource = tb1.ToList();
            tc39.DisplayMember = "TENTIEUCHUAN";
            tc39.ValueMember = "MATIECHUAN";

            tc310.DataSource = tb1.ToList();
            tc310.DisplayMember = "TENTIEUCHUAN";
            tc310.ValueMember = "MATIECHUAN";

            tc311.DataSource = tb1.ToList();
            tc311.DisplayMember = "TENTIEUCHUAN";
            tc311.ValueMember = "MATIECHUAN";

             
            tc41.DataSource = tb1.ToList();
            tc41.DisplayMember = "TENTIEUCHUAN";
            tc41.ValueMember = "MATIECHUAN";

            tc42.DataSource = tb1.ToList();
            tc42.DisplayMember = "TENTIEUCHUAN";
            tc42.ValueMember = "MATIECHUAN";

            tc51.DataSource = tb1.ToList();
            tc51.DisplayMember = "TENTIEUCHUAN";
            tc51.ValueMember = "MATIECHUAN";

            tc52.DataSource = tb1.ToList();
            tc52.DisplayMember = "TENTIEUCHUAN";
            tc52.ValueMember = "MATIECHUAN";

            tc53.DataSource = tb1.ToList();
            tc53.DisplayMember = "TENTIEUCHUAN";
            tc53.ValueMember = "MATIECHUAN";
        }

        KETQUADANHGIADao KETQUADANHGIA = new KETQUADANHGIADao();
        private void thuchien_Click(object sender, EventArgs e)
        {
            //kiem tra tồn tại thì update cập nhật
            //else thì insert thêm mới
            int flag = 0;
            flag = KETQUADANHGIA.SelectByMasv(username, cbochonsv.SelectedValue.ToString());

            KETQUADANHGIA kq1 = new KETQUADANHGIA
                {
                    MASV = cbochonsv.SelectedValue.ToString(),
                    MASVDANHGIA = username,

                    Tc11 = (int) tc11.SelectedValue,
                    Tc12 = (int)tc12.SelectedValue,
                    Tc13 = (int)tc13.SelectedValue,
                    Tc21 = (int)tc21.SelectedValue,
                    Tc22 = (int)tc22.SelectedValue,
                    Tc23 = (int)tc23.SelectedValue,
                    Tc31 = (int)tc31.SelectedValue,
                    Tc32 = (int)tc32.SelectedValue,
                    Tc33 = (int)tc33.SelectedValue,
                    Tc34 = (int)tc34.SelectedValue,
                    Tc35 = (int)tc35.SelectedValue,
                    Tc36 = (int)tc36.SelectedValue,
                    Tc37 = (int)tc37.SelectedValue,
                    Tc38 = (int)tc38.SelectedValue,
                    Tc39 = (int)tc39.SelectedValue,
                    Tc310 = (int)tc310.SelectedValue,
                    Tc311 = (int)tc311.SelectedValue,

                    Tc41 = (int)tc41.SelectedValue,
                    Tc42 = (int)tc42.SelectedValue,
                  
                    Tc51 = (int)tc51.SelectedValue,
                    Tc52 = (int)tc52.SelectedValue,
                    Tc53 = (int)tc53.SelectedValue

                };
            int k = -1;
            if (flag > 0)
            {
                KETQUADANHGIA.Update(kq1);
            }
            else
                KETQUADANHGIA.Insert(kq1);

        }

        private void chonsv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listketqia = KETQUADANHGIA.SelectByMasvMaGv(username, cbochonsv.SelectedValue.ToString());
            if (listketqia != null && listketqia.Count > 0)
            {
                var kqsv = listketqia[0];
                tc11.SelectedValue = kqsv.Tc11;
                tc12.SelectedValue = kqsv.Tc12;
                tc13.SelectedValue = kqsv.Tc13;

                tc21.SelectedValue = kqsv.Tc21;
                tc22.SelectedValue = kqsv.Tc22;
                tc23.SelectedValue = kqsv.Tc23;

                tc31.SelectedValue = kqsv.Tc31;
                tc32.SelectedValue = kqsv.Tc32;
                tc33.SelectedValue = kqsv.Tc33;
                tc34.SelectedValue = kqsv.Tc34;
                tc35.SelectedValue = kqsv.Tc35;
                tc36.SelectedValue = kqsv.Tc36;
                tc37.SelectedValue = kqsv.Tc37;
                tc38.SelectedValue = kqsv.Tc38;
                tc39.SelectedValue = kqsv.Tc39;
                tc310.SelectedValue = kqsv.Tc310;
                tc311.SelectedValue = kqsv.Tc311;


                tc41.SelectedValue = kqsv.Tc41;
                tc42.SelectedValue = kqsv.Tc42;

                tc51.SelectedValue = kqsv.Tc51;
                tc52.SelectedValue = kqsv.Tc52;
                tc53.SelectedValue = kqsv.Tc53;
               
            }
        }
        
        private void xemds_Click(object sender, EventArgs e)
        {
            frmKQNhanSet frm = new frmKQNhanSet();
            frm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thoat_Click(sender, e);
        }

    }

}
