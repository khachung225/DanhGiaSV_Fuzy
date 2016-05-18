using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DatabaseDAL.DAO;
using DatabaseDAL.Entities;

namespace NhanSetGiaoVien
{
    public partial class frmKQNhanSet : Form
    {
        private SINHVIENDao privatSihvien = new SINHVIENDao();
        private KETQUADANHGIADao KETQUADANHGIADao = new KETQUADANHGIADao();
        private TIEUCHUANDao TIEUCHUANDao = new TIEUCHUANDao();
        private KETQUATOTNGHIEPDao KETQUATOTNGHIEPDao = new KETQUATOTNGHIEPDao();
        private Dictionary<int, TIEUCHUAN> _dicTieuchuan = new Dictionary<int, TIEUCHUAN>();
        public frmKQNhanSet()
        {
            InitializeComponent();




        }
        private void frmKQRenLuyen_Load(object sender, EventArgs e)
        {
            var tb = privatSihvien.GetAll("1");
            cbochonsv.DataSource = tb;
            cbochonsv.DisplayMember = "HOTEN";
            cbochonsv.ValueMember = "MASV";

            var listtieuchuan = TIEUCHUANDao.GetAll();
            foreach (var tieuchuan in listtieuchuan)
            {
                _dicTieuchuan[tieuchuan.MATIECHUAN] = tieuchuan;
            }
        }

        float kqa, kqb, kqc;
        string xeploai = "";

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbochonsv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = KETQUADANHGIADao.GetAllKetQuaByMaSV(cbochonsv.SelectedValue.ToString());
            dataGridView1.DataSource = dt;
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            float tc11a = 0;
            float tc11b = 0;
            float tc11c = 0;
            float tc12a = 0;
            float tc12b = 0;
            float tc12c = 0;
            float tc13a = 0;
            float tc13b = 0;
            float tc13c = 0;

            float tc21a = 0;
            float tc21b = 0;
            float tc21c = 0;
            float tc22a = 0;
            float tc22b = 0;
            float tc22c = 0;
            float tc23a = 0;
            float tc23b = 0;
            float tc23c = 0;

            float tc31a = 0;
            float tc31b = 0;
            float tc31c = 0;
            float tc32a = 0;
            float tc32b = 0;
            float tc32c = 0;
            float tc33a = 0;
            float tc33b = 0;
            float tc33c = 0;
            float tc34a = 0;
            float tc34b = 0;
            float tc34c = 0;
            float tc35a = 0;
            float tc35b = 0;
            float tc35c = 0;
            float tc36a = 0;
            float tc36b = 0;
            float tc36c = 0;
            float tc37a = 0;
            float tc37b = 0;
            float tc37c = 0;
            float tc38a = 0;
            float tc38b = 0;
            float tc38c = 0;
            float tc39a = 0;
            float tc39b = 0;
            float tc39c = 0;
            float tc310a = 0;
            float tc310b = 0;
            float tc310c = 0;
            float tc311a = 0;
            float tc311b = 0;
            float tc311c = 0;

            float tc41a = 0;
            float tc41b = 0;
            float tc41c = 0;
            float tc42a = 0;
            float tc42b = 0;
            float tc42c = 0;


            float tc51a = 0;
            float tc51b = 0;
            float tc51c = 0;
            float tc52a = 0;
            float tc52b = 0;
            float tc52c = 0;
            float tc53a = 0;
            float tc53b = 0;
            float tc53c = 0;


            List<KETQUADANHGIA> lstKQ = KETQUADANHGIADao.GetAllKetQuaByMaSVDanhGia(cbochonsv.SelectedValue.ToString());

            foreach (var k in lstKQ)
            {
                var dt = _dicTieuchuan[k.Tc11];
                tc11a += (float)(dt.P1 ?? 0);
                tc11b += (float)(dt.P2 ?? 0);
                tc11c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc12];
                tc12a += (float)(dt.P1 ?? 0);
                tc12b += (float)(dt.P2 ?? 0);
                tc12c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc13];
                tc13a += (float)(dt.P1 ?? 0);
                tc13b += (float)(dt.P2 ?? 0);
                tc13c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc21];
                tc21a += (float)(dt.P1 ?? 0);
                tc21b += (float)(dt.P2 ?? 0);
                tc21c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc22];
                tc22a += (float)(dt.P1 ?? 0);
                tc22b += (float)(dt.P2 ?? 0);
                tc22c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc23];
                tc23a += (float)(dt.P1 ?? 0);
                tc23b += (float)(dt.P2 ?? 0);
                tc23c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc31];
                tc31a += (float)(dt.P1 ?? 0);
                tc31b += (float)(dt.P2 ?? 0);
                tc31c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc32];
                tc32a += (float)(dt.P1 ?? 0);
                tc32b += (float)(dt.P2 ?? 0);
                tc32c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc33];
                tc33a += (float)(dt.P1 ?? 0);
                tc33b += (float)(dt.P2 ?? 0);
                tc33c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc34];
                tc34a += (float)(dt.P1 ?? 0);
                tc34b += (float)(dt.P2 ?? 0);
                tc34c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc35];
                tc35a += (float)(dt.P1 ?? 0);
                tc35b += (float)(dt.P2 ?? 0);
                tc35c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc36];
                tc36a += (float)(dt.P1 ?? 0);
                tc36b += (float)(dt.P2 ?? 0);
                tc36c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc37];
                tc37a += (float)(dt.P1 ?? 0);
                tc37b += (float)(dt.P2 ?? 0);
                tc37c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc38];
                tc38a += (float)(dt.P1 ?? 0);
                tc38b += (float)(dt.P2 ?? 0);
                tc38c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc39];
                tc39a += (float)(dt.P1 ?? 0);
                tc39b += (float)(dt.P2 ?? 0);
                tc39c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc310];
                tc310a += (float)(dt.P1 ?? 0);
                tc310b += (float)(dt.P2 ?? 0);
                tc310c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc311];
                tc311a += (float)(dt.P1 ?? 0);
                tc311b += (float)(dt.P2 ?? 0);
                tc311c += (float)(dt.P3 ?? 0);


                dt = _dicTieuchuan[k.Tc41];
                tc41a += (float)(dt.P1 ?? 0);
                tc41b += (float)(dt.P2 ?? 0);
                tc41c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc42];
                tc42a += (float)(dt.P1 ?? 0);
                tc42b += (float)(dt.P2 ?? 0);
                tc42c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc51];
                tc51a += (float)(dt.P1 ?? 0);
                tc51b += (float)(dt.P2 ?? 0);
                tc51c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc52];
                tc52a += (float)(dt.P1 ?? 0);
                tc52b += (float)(dt.P2 ?? 0);
                tc52c += (float)(dt.P3 ?? 0);

                dt = _dicTieuchuan[k.Tc53];
                tc53a += (float)(dt.P1 ?? 0);
                tc53b += (float)(dt.P2 ?? 0);
                tc53c += (float)(dt.P3 ?? 0);
            }
            int totalsv = lstKQ.Count;
            tc11a = tc11a / totalsv; tc11b = tc11b / totalsv; tc11c = tc11c / totalsv;
            tc12a = tc12a / totalsv; tc12b = tc12b / totalsv; tc12c = tc12c / totalsv;
            tc13a = tc13a / totalsv; tc13b = tc13b / totalsv; tc13c = tc13c / totalsv;
            //21 va 22
            tc21a = tc21a / totalsv; tc21b = tc21b / totalsv; tc21c = tc21c / totalsv;
            tc22a = tc22a / totalsv; tc22b = tc22b / totalsv; tc22c = tc22c / totalsv;
            tc23a = tc23a / totalsv; tc23b = tc23b / totalsv; tc23c = tc23c / totalsv;
            //31,32,33
            tc31a = tc31a / totalsv; tc31b = tc31b / totalsv; tc31c = tc31c / totalsv;
            tc32a = tc32a / totalsv; tc32b = tc32b / totalsv; tc32c = tc32c / totalsv;
            tc33a = tc33a / totalsv; tc33b = tc33b / totalsv; tc33c = tc33c / totalsv;
            tc34a = tc34a / totalsv; tc34b = tc34b / totalsv; tc34c = tc34c / totalsv;
            tc35a = tc35a / totalsv; tc35b = tc35b / totalsv; tc35c = tc35c / totalsv;
            tc36a = tc36a / totalsv; tc36b = tc36b / totalsv; tc36c = tc36c / totalsv;
            tc37a = tc37a / totalsv; tc37b = tc37b / totalsv; tc37c = tc37c / totalsv;
            tc38a = tc38a / totalsv; tc38b = tc38b / totalsv; tc38c = tc38c / totalsv;
            tc39a = tc39a / totalsv; tc39b = tc39b / totalsv; tc39c = tc39c / totalsv;
            tc310a = tc310a / totalsv; tc310b = tc310b / totalsv; tc310c = tc310c / totalsv;
            tc311a = tc311a / totalsv; tc311b = tc311b / totalsv; tc311c = tc311c / totalsv;

            //41,42,43
            tc41a = tc41a / totalsv; tc41b = tc41b / totalsv; tc41c = tc41c / totalsv;
            tc42a = tc42a / totalsv; tc42b = tc42b / totalsv; tc42c = tc42c / totalsv;

            //51,52,53
            tc51a = tc51a / totalsv; tc51b = tc51b / totalsv; tc51c = tc51c / totalsv;
            tc52a = tc52a / totalsv; tc52b = tc52b / totalsv; tc52c = tc52c / totalsv;
            tc53a = tc53a / totalsv; tc53b = tc53b / totalsv; tc53c = tc53c / totalsv;
            //ket thuc for
            float tchuan1a, tchuan1b, tchuan1c;
            float tchuan2a, tchuan2b, tchuan2c;
            float tchuan3a, tchuan3b, tchuan3c;
            float tchuan4a, tchuan4b, tchuan4c;
            float tchuan5a, tchuan5b, tchuan5c;

            string s;
            s = "  " + "TC11" + "(" + tc11a + " | " + tc11b + " | " + tc11c + ")";

            s += "  " + "TC12(" + tc12a + " | " + tc12b + " | " + tc12c + ")";
            s += "  " + "TC13(" + tc13a + " | " + tc13b + " | " + tc13c + ")";
            s += "\r\n";
            s += "  " + "TC21(" + tc21a + " | " + tc21b + " | " + tc21c + ")";
            s += "  " + "TC22(" + tc22a + " | " + tc22b + " | " + tc22c + ")";
            s += "  " + "TC23(" + tc23a + " | " + tc23b + " | " + tc23c + ")";
            s += "\r\n";
            s += "  " + "TC31(" + tc31a + " | " + tc31b + " | " + tc31c + ")";
            s += "  " + "TC32(" + tc32a + " | " + tc32b + " | " + tc32c + ")";
            s += "  " + "TC33(" + tc33a + " | " + tc33b + " | " + tc33c + ")";
            s += "  " + "TC33(" + tc34a + " | " + tc34b + " | " + tc34c + ")";
            s += "  " + "TC33(" + tc35a + " | " + tc35b + " | " + tc35c + ")";
            s += "  " + "TC33(" + tc36a + " | " + tc36b + " | " + tc36c + ")";
            s += "  " + "TC33(" + tc37a + " | " + tc37b + " | " + tc37c + ")";
            s += "  " + "TC33(" + tc38a + " | " + tc38b + " | " + tc38c + ")";
            s += "  " + "TC33(" + tc39a + " | " + tc39b + " | " + tc39c + ")";
            s += "  " + "TC33(" + tc310a + " | " + tc310b + " | " + tc310c + ")";
            s += "  " + "TC33(" + tc311a + " | " + tc311b + " | " + tc311c + ")";
            s += "\r\n";
            s += "  " + "TC41(" + tc41a + " | " + tc41b + " | " + tc41c + ")";
            s += "  " + "TC42(" + tc42a + " | " + tc42b + " | " + tc42c + ")";
            s += "\r\n";
            s += "  " + "TC51(" + tc51a + " | " + tc51b + " | " + tc51c + ")";
            s += "  " + "TC52(" + tc52a + " | " + tc52b + " | " + tc52c + ")";
            s += "  " + "TC53(" + tc53a + " | " + tc53b + " | " + tc53c + ")";

            txtTieuchi.Text = s;


            //tinh tieu chuan
            //11,12,13
            tchuan1a = (tc11a + tc12a + tc13a) / 3;
            tchuan1b = (tc11b + tc12b + tc13b) / 3;
            tchuan1c = (tc11c + tc12c + tc13c) / 3;
            //21,22
            tchuan2a = (tc21a + tc22a + tc23a) / 3;
            tchuan2b = (tc21b + tc22b + tc23b) / 3;
            tchuan2c = (tc21c + tc22c + tc23c) / 3;
            //31,32,33
            tchuan3a = (tc31a + tc32a + tc33a + tc34a + tc35a + tc36a + tc37a + tc38a + tc39a + tc310a + tc311a) / 11;
            tchuan3b = (tc31b + tc32b + tc33b + tc34b + tc35b + tc36b + tc37b + tc38b + tc39b + tc310b + tc311b) / 11;
            tchuan3c = (tc31c + tc32c + tc33c + tc34c + tc35c + tc36c + tc37c + tc38c + tc39c + tc310c + tc311c) / 11;
            //41,42,43
            tchuan4a = (tc41a + tc42a) / 2;
            tchuan4b = (tc41b + tc42b) / 2;
            tchuan4c = (tc41c + tc42c) / 2;
            //51,52,53
            tchuan5a = (tc51a + tc52a + tc53a) / 3;
            tchuan5b = (tc51b + tc52b + tc53b) / 3;
            tchuan5c = (tc51c + tc52c + tc53c) / 3;

            string s1;
            s1 = "  " + "TIEUCHUAN1" + "(" + tchuan1a + " | " + tchuan1b + " | " + tchuan1c + ")";
            s1 += "\r\n";
            s1 += "  " + "TIEUCHUAN2" + "(" + tchuan2a + " | " + tchuan2b + " | " + tchuan2c + ")";
            s1 += "\r\n";
            s1 += "  " + "TIEUCHUAN3" + "(" + tchuan3a + " | " + tchuan3b + " | " + tchuan3c + ")";
            s1 += "\r\n";
            s1 += "  " + "TIEUCHUAN4" + "(" + tchuan4a + " | " + tchuan4b + " | " + tchuan4c + ")";
            s1 += "\r\n";
            s1 += "  " + "TIEUCHUAN5" + "(" + tchuan5a + " | " + tchuan5b + " | " + tchuan5c + ")";
            txtTieuchuan.Text = s1;

            //ket qua ren luyen


            string s3;
            kqa = (tchuan1a + tchuan2a + tchuan3a + tchuan4a + tchuan5a) / 5;
            kqb = (tchuan1b + tchuan2b + tchuan3b + tchuan4b + tchuan5b) / 5;
            kqc = (tchuan1c + tchuan2c + tchuan3c + tchuan4c + tchuan5c) / 5;

            s3 = "KETQUA" + "(" + kqa + " | " + kqb + " | " + kqc + ")";
            s3 += "\r\n" + "Kết quả nhận sét  ";

            if (kqb <= 5)
            {
                xeploai = "Dưới bình thường";

            }
            if (kqb >= 5 && kqb < 7)
            {

                xeploai = "Bình thường";

            }

            if (kqb >= 7 && kqb < 8)
            {


                xeploai = "Khá";


            }
            if (kqb >= 8 && kqb < 9)
            {

                xeploai = "Tốt";

            }

            if (kqb > 9)
            {
                xeploai = "Rất tốt";
            }


            txtKetQua.Text = s3 + " " + xeploai;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string masv = cbochonsv.SelectedValue.ToString();
            string hoten = cbochonsv.Text;
            string ketqua = "(" + kqa + " | " + kqb + " | " + kqc + ")";
            string _xeploai = xeploai;

            var kqtotnghiep = KETQUATOTNGHIEPDao.GetByPrimaryKey(masv);
            if (kqtotnghiep != null)
            {
                 KETQUATOTNGHIEPDao.Update(new KETQUATOTNGHIEP
                     {
                         MASV = masv,
                         HOTEN = hoten,
                         KETQUA = ketqua,
                         XEPLOAI = _xeploai
                     });

            }
            else

                KETQUATOTNGHIEPDao.Insert(new KETQUATOTNGHIEP
                {
                         MASV = masv,
                         HOTEN = hoten,
                         KETQUA = ketqua,
                         XEPLOAI = _xeploai
                     });


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = KETQUATOTNGHIEPDao.GetAll();
            dataGridView2.DataSource = dt;
        }


    }
}
