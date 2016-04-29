using System;
using System.Linq;
using System.Windows.Forms;
using DatabaseDAL.DAO;
using DatabaseDAL.Entities;

namespace NhanXetSinhVien
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


            tchi21.DataSource = tb1.ToList();
            tchi21.DisplayMember = "TENTIEUCHUAN";
            tchi21.ValueMember = "MATIECHUAN";

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
            
        }

        KETQUADANHGIADao KETQUADANHGIA = new KETQUADANHGIADao();
        private void thuchien_Click(object sender, EventArgs e)
        {
            //kiem tra tồn tại thì update cập nhật
            //else thì insert thêm mới
            int flag = 0;
            flag = KETQUADANHGIA.SelectByMasv(username, cbochonsv.SelectedValue.ToString());

            KETQUADANHGIA kq1 = new KETQUADANHGIA(cbochonsv.SelectedValue.ToString(), username,
                  (int)tc11.SelectedValue, (int)tc12.SelectedValue,
                (int)tchi21.SelectedValue, (int)tc22.SelectedValue, (int)tc23.SelectedValue,0,0,0,0,0,0,0,0,0);
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

                tchi21.SelectedValue = kqsv.Tc13;
                tc22.SelectedValue = kqsv.Tc21;
                tc23.SelectedValue = kqsv.Tc22;
            }
        }

        //private void btnThuchien_Click(object sender, EventArgs e)
        //{
        //    float tc11a = 0;
        //    float tc11b = 0;
        //    float tc11c = 0;
        //    float tc12a = 0;
        //    float tc12b = 0;
        //    float tc12c = 0;
        //    float tc13a = 0;
        //    float tc13b = 0;
        //    float tc13c = 0;

        //    float tc21a = 0;
        //    float tc21b = 0;
        //    float tc21c = 0;
        //    float tc22a = 0;
        //    float tc22b = 0;
        //    float tc22c = 0;

        //    float tc31a = 0;
        //    float tc31b = 0;
        //    float tc31c = 0;
        //    float tc32a = 0;
        //    float tc32b = 0;
        //    float tc32c = 0;
        //    float tc33a = 0;
        //    float tc33b = 0;
        //    float tc33c = 0;

        //    float tc41a = 0;
        //    float tc41b = 0;
        //    float tc41c = 0;
        //    float tc42a = 0;
        //    float tc42b = 0;
        //    float tc42c = 0;
        //    float tc43a = 0;
        //    float tc43b = 0;
        //    float tc43c = 0;

        //    float tc51a = 0;
        //    float tc51b = 0;
        //    float tc51c = 0;
        //    float tc52a = 0;
        //    float tc52b = 0;
        //    float tc52c = 0;
        //    float tc53a = 0;
        //    float tc53b = 0;
        //    float tc53c = 0;


        //    List<KETQUANDANHGIA> lstKQ = KetQuaDanhGiaDAO.Instance.GetAllKetQuaDanhGiaByMaSV();

        //    foreach( KETQUANDANHGIA k in lstKQ)
        //    {
        //        DataTable dt = KetQuaDanhGiaDAO.Instance.GetByMaTieuChuan(k.Tc11);
        //        tc11a +=float.Parse(dt.Rows[0]["P1"].ToString());
        //        tc11b += float.Parse(dt.Rows[0]["P2"].ToString());
        //        tc11c += float.Parse(dt.Rows[0]["P3"].ToString());

        //        dt = KetQuaDanhGiaDAO.Instance.GetByMaTieuChuan(k.Tc12);
        //        tc12a += float.Parse(dt.Rows[0]["P1"].ToString());
        //        tc12b += float.Parse(dt.Rows[0]["P2"].ToString());
        //        tc12c += float.Parse(dt.Rows[0]["P3"].ToString());

        //        dt = KetQuaDanhGiaDAO.Instance.GetByMaTieuChuan(k.Tc13);
        //        tc13a += float.Parse(dt.Rows[0]["P1"].ToString());
        //        tc13b += float.Parse(dt.Rows[0]["P2"].ToString());
        //        tc13c += float.Parse(dt.Rows[0]["P3"].ToString());

        //        dt = KetQuaDanhGiaDAO.Instance.GetByMaTieuChuan(k.Tc21);
        //        tc21a += float.Parse(dt.Rows[0]["P1"].ToString());
        //        tc21b += float.Parse(dt.Rows[0]["P2"].ToString());
        //        tc21c += float.Parse(dt.Rows[0]["P3"].ToString());

        //        dt = KetQuaDanhGiaDAO.Instance.GetByMaTieuChuan(k.Tc22);
        //        tc22a += float.Parse(dt.Rows[0]["P1"].ToString());
        //        tc22b += float.Parse(dt.Rows[0]["P2"].ToString());
        //        tc22c += float.Parse(dt.Rows[0]["P3"].ToString());


        //        //tc31,32,33
        //        dt = KetQuaDanhGiaDAO.Instance.GetByMaTieuChuan(k.Tc31);
        //        tc31a += float.Parse(dt.Rows[0]["P1"].ToString());
        //        tc31b += float.Parse(dt.Rows[0]["P2"].ToString());
        //        tc31c += float.Parse(dt.Rows[0]["P3"].ToString());

        //        dt = KetQuaDanhGiaDAO.Instance.GetByMaTieuChuan(k.Tc32);
        //        tc32a += float.Parse(dt.Rows[0]["P1"].ToString());
        //        tc32b += float.Parse(dt.Rows[0]["P2"].ToString());
        //        tc32c += float.Parse(dt.Rows[0]["P3"].ToString());

        //        dt = KetQuaDanhGiaDAO.Instance.GetByMaTieuChuan(k.Tc32);
        //        tc33a += float.Parse(dt.Rows[0]["P1"].ToString());
        //        tc33b += float.Parse(dt.Rows[0]["P2"].ToString());
        //        tc33c += float.Parse(dt.Rows[0]["P3"].ToString());

        //        //tc41.42.43

        //        dt = KetQuaDanhGiaDAO.Instance.GetByMaTieuChuan(k.Tc41);
        //        tc41a += float.Parse(dt.Rows[0]["P1"].ToString());
        //        tc41b += float.Parse(dt.Rows[0]["P2"].ToString());
        //        tc41c += float.Parse(dt.Rows[0]["P3"].ToString());

        //        dt = KetQuaDanhGiaDAO.Instance.GetByMaTieuChuan(k.Tc42);
        //        tc42a += float.Parse(dt.Rows[0]["P1"].ToString());
        //        tc42b += float.Parse(dt.Rows[0]["P2"].ToString());
        //        tc42c += float.Parse(dt.Rows[0]["P3"].ToString());

        //        dt = KetQuaDanhGiaDAO.Instance.GetByMaTieuChuan(k.Tc43);
        //        tc43a += float.Parse(dt.Rows[0]["P1"].ToString());
        //        tc43b += float.Parse(dt.Rows[0]["P2"].ToString());
        //        tc43c += float.Parse(dt.Rows[0]["P3"].ToString());

        //        //tc 51,52,53

        //        dt = KetQuaDanhGiaDAO.Instance.GetByMaTieuChuan(k.Tc51);
        //        tc51a += float.Parse(dt.Rows[0]["P1"].ToString());
        //        tc51b += float.Parse(dt.Rows[0]["P2"].ToString());
        //        tc51c += float.Parse(dt.Rows[0]["P3"].ToString());

        //        dt = KetQuaDanhGiaDAO.Instance.GetByMaTieuChuan(k.Tc52);
        //        tc52a += float.Parse(dt.Rows[0]["P1"].ToString());
        //        tc52b += float.Parse(dt.Rows[0]["P2"].ToString());
        //        tc52c += float.Parse(dt.Rows[0]["P3"].ToString());

        //        dt = KetQuaDanhGiaDAO.Instance.GetByMaTieuChuan(k.Tc53);
        //        tc53a += float.Parse(dt.Rows[0]["P1"].ToString());
        //        tc53b += float.Parse(dt.Rows[0]["P2"].ToString());
        //        tc53c += float.Parse(dt.Rows[0]["P3"].ToString());







        //    }
        //    int totalsv=lstKQ.Count;
        //    tc11a = tc11a / totalsv; tc11b = tc11b / totalsv; tc11c = tc11c/totalsv;
        //    tc12a = tc12a / totalsv; tc12b = tc12b / totalsv; tc12c = tc12c/totalsv;
        //    tc13a = tc13a / totalsv; tc13b = tc13b / totalsv; tc13c = tc13c /totalsv;
        //   //21 va 22
        //    tc21a = tc21a / totalsv; tc21b = tc21b / totalsv; tc21c = tc21c / totalsv;
        //    tc22a = tc22a / totalsv; tc22b = tc22b / totalsv; tc22c = tc22c / totalsv;
        //    //31,32,33
        //    tc31a = tc31a / totalsv; tc31b = tc31b / totalsv; tc31c = tc31c / totalsv;
        //    tc32a = tc32a / totalsv; tc32b = tc32b / totalsv; tc32c = tc32c / totalsv;
        //    tc33a = tc33a / totalsv; tc33b = tc33b / totalsv; tc33c = tc33c / totalsv;
        //    //41,42,43
        //    tc41a = tc41a / totalsv; tc41b = tc41b / totalsv; tc41c = tc41c / totalsv;
        //    tc42a = tc42a / totalsv; tc42b = tc42b / totalsv; tc42c = tc42c / totalsv;
        //    tc43a = tc43a / totalsv; tc43b = tc43b / totalsv; tc43c = tc43c / totalsv;
        //    //51,52,53
        //    tc51a = tc51a / totalsv; tc51b = tc51b / totalsv; tc51c = tc51c / totalsv;
        //    tc52a = tc52a / totalsv; tc52b = tc52b / totalsv; tc52c = tc52c / totalsv;
        //    tc53a = tc53a / totalsv; tc53b = tc53b / totalsv; tc53c = tc53c / totalsv;
        //    //ket thuc for
        //    float tchuan1a, tchuan1b, tchuan1c;
        //    float tchuan2a, tchuan2b, tchuan2c;
        //    float tchuan3a, tchuan3b, tchuan3c;
        //    float tchuan4a, tchuan4b, tchuan4c;
        //    float tchuan5a, tchuan5b, tchuan5c;

        //    string s;
        //    s="  "+"TC11"+"("+ tc11a +","+tc11b+"," + tc11c+ ")";

        //    s += "  " + "TC12(" + tc12a + "," + tc12b + "," + tc12c + ")";
        //    s += "  " + "TC13(" + tc13a + "," + tc13b + "," + tc13c + ")";
        //    s += "\r\n";
        //    s += "  " + "TC21(" + tc21a + "," + tc21b + "," + tc21c + ")";
        //    s += "  " + "TC22(" + tc22a + "," + tc22b + "," + tc22c + ")";
        //    s += "\r\n";
        //    s += "  " + "TC31(" + tc31a + "," + tc31b + "," + tc31c + ")";
        //    s += "  " + "TC32(" + tc32a + "," + tc32b + "," + tc32c + ")";
        //    s += "  " + "TC33(" + tc33a + "," + tc33b + "," + tc33c + ")";
        //    s += "\r\n";
        //    s += "  " + "TC41(" + tc41a + "," + tc41b + "," + tc41c + ")";
        //    s += "  " + "TC42(" + tc42a + "," + tc42b + "," + tc42c + ")";
        //    s += "  " + "TC43(" + tc43a + "," + tc43b + "," + tc43c + ")";
        //    s += "\r\n";
        //    s += "  " + "TC51(" + tc51a + "," + tc51b + "," + tc51c + ")";
        //    s += "  " + "TC52(" + tc52a + "," + tc52b + "," + tc52c + ")";
        //    s += "  " + "TC53(" + tc53a + "," + tc53b + "," + tc53c + ")";

        //    txtTieuchi.Text = s;


        //    //tinh tieu chuan
        //    //11,12,13
        //    tchuan1a = (tc11a + tc12a + tc13a) / 3;
        //    tchuan1b = (tc11b + tc12b + tc13b) / 3;
        //    tchuan1c = (tc11c + tc12c + tc13c) / 3;
        //    //21,22
        //    tchuan2a = (tc21a + tc22a) / 2;
        //    tchuan2b = (tc21b + tc22b) / 2;
        //    tchuan2c = (tc21c + tc22c) / 2;
        //    //31,32,33
        //    tchuan3a = (tc31a + tc32a + tc33a) / 3;
        //    tchuan3b = (tc31b + tc32b + tc33b) / 3;
        //    tchuan3c = (tc31c + tc32c + tc33c) / 3;
        //    //41,42,43
        //    tchuan4a = (tc41a + tc42a + tc43a) / 3;
        //    tchuan4b = (tc41b + tc42b + tc43b) / 3;
        //    tchuan4c = (tc41c + tc42c + tc43c) / 3;
        //    //51,52,53
        //    tchuan5a = (tc51a + tc52a + tc53a) / 3;
        //    tchuan5b = (tc51b + tc52b + tc53b) / 3;
        //    tchuan5c = (tc51c + tc52c + tc53c) / 3;

        //    string s1;
        //    s1 = "  " + "TIEUCHUAN1" + "(" + tchuan1a + "," + tchuan1b + "," + tchuan1c + ")";
        //    s1 += "\r\n";
        //    s1 += "  " + "TIEUCHUAN2"+ "(" + tchuan2a + "," + tchuan2b + "," + tchuan2c + ")";
        //    s1 += "\r\n";
        //    s1 += "  " + "TIEUCHUAN3" + "(" + tchuan3a + "," + tchuan3b + "," + tchuan3c + ")";
        //    s1 += "\r\n";
        //    s1 += "  " + "TIEUCHUAN4" + "(" + tchuan4a + "," + tchuan4b + "," + tchuan4c + ")";
        //    s1 += "\r\n";
        //    s1 += "  " + "TIEUCHUAN5" + "(" + tchuan5a + "," + tchuan5b + "," + tchuan5c + ")";
        //    txtTieuchuan.Text = s1;

        //    //ket qua ren luyen

        //    float kqa, kqb, kqc;
        //    string s3="";
        //    kqa = (tchuan1a + tchuan2a + tchuan3a + tchuan4a + tchuan5a) / 5;
        //    kqb = (tchuan1b + tchuan2b + tchuan3b + tchuan4b + tchuan5b) / 5;
        //    kqc = (tchuan1c + tchuan2c + tchuan3c + tchuan4c + tchuan5c) / 5;

        //    s3 = "KETQUA" + "(" + kqa + "," + kqb + "," + kqc + ")";
        //    s3+="\r\n" +"Kết quả rèn luyện  ";

        //        if (kqb <= 3)
        //        {
        //            s3 += "Kém";
        //        }

        //         if (kqb > 3 && kqb < 4)
        //            {
        //                s3 += "Yếu";
        //            }
        //         if(kqb>=4&&kqb<5)

        //              {
        //                    if (kqb - 4 < 5 - kqb)

        //                        s3 += "Yếu";

        //                    else
        //                        s3 += "Trung Bình";

        //              }

        //         if (kqb >= 5 && kqb < 6)
        //         {
        //             if (kqb - 5 < 6 - kqb)

        //                 s3 += "Trung bình";

        //             else
        //                 s3 += "Trung Bình-Khá";

        //         }

        //         if (kqb >= 6 && kqb < 7)
        //         {
        //             if (kqb - 6 < 7 - kqb)

        //                 s3 += "Trung bình-Khá";

        //             else
        //                 s3 += "Khá";

        //         }

        //         if (kqb >= 7 && kqb < 8)
        //         {
        //             if (kqb - 7 < 8 - kqb)

        //                 s3 += "Khá";

        //             else
        //                 s3 += "Tốt";

        //         }
        //         if (kqb >= 8 && kqb < 9)
        //         {
        //             if (kqb - 8 < 9 - kqb)

        //                 s3 += "Tốt";

        //             else
        //                 s3 += "Xuất sắc";

        //         }

        //         if (kqb > 9)
        //         {
        //             s3 += "Xuất sắc";
        //         }


        //         txtKetQua.Text =s3;

        //    }

        private void xemds_Click(object sender, EventArgs e)
        {
            frmKQRenLuyen frm = new frmKQRenLuyen();
            frm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thoat_Click(sender, e);
        }

    }

}
