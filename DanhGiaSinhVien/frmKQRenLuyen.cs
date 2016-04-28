using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DatabaseDAL.DAO;
using DatabaseDAL.Entities;

namespace NhanXetSinhVien
{
    public partial class frmKQRenLuyen : Form
    {
        private SINHVIENDao sinvienDao = new SINHVIENDao();
        KETQUADANHGIADao KETQUADANHGIA = new KETQUADANHGIADao();
        KETQUARENLUYENDao KETQUARENLUYENDao = new KETQUARENLUYENDao();
        TIEUCHUANDao TIEUCHUANDao = new TIEUCHUANDao();
        private Dictionary<int, TIEUCHUAN> dicTIEUCHUAN = new Dictionary<int, TIEUCHUAN>();
        public frmKQRenLuyen()
        {
            InitializeComponent();

            var tb = sinvienDao.GetAll("1");
            cbochonsv.DataSource = tb.ToList();
            cbochonsv.DisplayMember = "HOTEN";
            cbochonsv.ValueMember = "MASV";


        }
        float kqa, kqb, kqc;
        string xeploai = "";

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void cbochonsv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = KETQUADANHGIA.GetAllKetQuaByMaSV(cbochonsv.SelectedValue.ToString());
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

            float tc31a = 0;
            float tc31b = 0;
            float tc31c = 0;
            float tc32a = 0;
            float tc32b = 0;
            float tc32c = 0;
            float tc33a = 0;
            float tc33b = 0;
            float tc33c = 0;

            float tc41a = 0;
            float tc41b = 0;
            float tc41c = 0;
            float tc42a = 0;
            float tc42b = 0;
            float tc42c = 0;
            float tc43a = 0;
            float tc43b = 0;
            float tc43c = 0;

            float tc51a = 0;
            float tc51b = 0;
            float tc51c = 0;
            float tc52a = 0;
            float tc52b = 0;
            float tc52c = 0;
            float tc53a = 0;
            float tc53b = 0;
            float tc53c = 0;


            List<KETQUADANHGIA> lstKQ = KETQUADANHGIA.GetAllKetQuaByMaSVDanhGia(cbochonsv.SelectedValue.ToString());

            foreach (var k in lstKQ)
            {
                TIEUCHUAN dt;
                if (dicTIEUCHUAN.ContainsKey(k.Tc11))
                {
                    dt = dicTIEUCHUAN[k.Tc11];
                    tc11a += (float)(dt.P1 ?? 0);
                    tc11b += (float)(dt.P2 ?? 0);
                    tc11c += (float)(dt.P3 ?? 0);
                }

                if (dicTIEUCHUAN.ContainsKey(k.Tc12))
                {
                    dt = dicTIEUCHUAN[k.Tc12];
                    tc12a += (float)(dt.P1 ?? 0);
                    tc12b += (float)(dt.P2 ?? 0);
                    tc12c += (float)(dt.P3 ?? 0);
                }
                if (dicTIEUCHUAN.ContainsKey(k.Tc13))
                {
                    dt = dicTIEUCHUAN[k.Tc13];
                    tc13a += (float)(dt.P1 ?? 0);
                    tc13b += (float)(dt.P2 ?? 0);
                    tc13c += (float)(dt.P3 ?? 0);
                }
                if (dicTIEUCHUAN.ContainsKey(k.Tc21))
                {
                    dt = dicTIEUCHUAN[k.Tc21];
                    tc21a += (float)(dt.P1 ?? 0);
                    tc21b += (float)(dt.P2 ?? 0);
                    tc21c += (float)(dt.P3 ?? 0);
                }
                if (dicTIEUCHUAN.ContainsKey(k.Tc22))
                {
                    dt = dicTIEUCHUAN[k.Tc22];
                    tc22a += (float)(dt.P1 ?? 0);
                    tc22b += (float)(dt.P2 ?? 0);
                    tc22c += (float)(dt.P3 ?? 0);
                }


                //tc31,32,33
                if (dicTIEUCHUAN.ContainsKey(k.Tc31))
                {
                    dt = dicTIEUCHUAN[k.Tc31];
                    tc31a += (float)(dt.P1 ?? 0);
                    tc31b += (float)(dt.P2 ?? 0);
                    tc31c += (float)(dt.P3 ?? 0);
                }
                if (dicTIEUCHUAN.ContainsKey(k.Tc32))
                {
                    dt = dicTIEUCHUAN[k.Tc32];
                    tc32a += (float)(dt.P1 ?? 0);
                    tc32b += (float)(dt.P2 ?? 0);
                    tc32c += (float)(dt.P3 ?? 0);
                }
                if (dicTIEUCHUAN.ContainsKey(k.Tc33))
                {
                    dt = dicTIEUCHUAN[k.Tc33];
                    tc33a += (float)(dt.P1 ?? 0);
                    tc33b += (float)(dt.P2 ?? 0);
                    tc33c += (float)(dt.P3 ?? 0);
                }

                //tc41.42.43
                if (dicTIEUCHUAN.ContainsKey(k.Tc41))
                {
                    dt = dicTIEUCHUAN[k.Tc41];
                    tc41a += (float)(dt.P1 ?? 0);
                    tc41b += (float)(dt.P2 ?? 0);
                    tc41c += (float)(dt.P3 ?? 0);
                }
                if (dicTIEUCHUAN.ContainsKey(k.Tc42))
                {
                    dt = dicTIEUCHUAN[k.Tc42];
                    tc42a += (float)(dt.P1 ?? 0);
                    tc42b += (float)(dt.P2 ?? 0);
                    tc42c += (float)(dt.P3 ?? 0);
                }
                if (dicTIEUCHUAN.ContainsKey(k.Tc43))
                {
                    dt = dicTIEUCHUAN[k.Tc43];
                    tc43a += (float)(dt.P1 ?? 0);
                    tc43b += (float)(dt.P2 ?? 0);
                    tc43c += (float)(dt.P3 ?? 0);
                }

                //tc 51,52,53
                if (dicTIEUCHUAN.ContainsKey(k.Tc51))
                {
                    dt = dicTIEUCHUAN[k.Tc51];
                    tc51a += (float)(dt.P1 ?? 0);
                    tc51b += (float)(dt.P2 ?? 0);
                    tc51c += (float)(dt.P3 ?? 0);
                }
                if (dicTIEUCHUAN.ContainsKey(k.Tc52))
                {
                    dt = dicTIEUCHUAN[k.Tc52];
                    tc52a += (float)(dt.P1 ?? 0);
                    tc52b += (float)(dt.P2 ?? 0);
                    tc52c += (float)(dt.P3 ?? 0);
                }
                if (dicTIEUCHUAN.ContainsKey(k.Tc53))
                {
                    dt = dicTIEUCHUAN[k.Tc53];
                    tc53a += (float)(dt.P1 ?? 0);
                    tc53b += (float)(dt.P2 ?? 0);
                    tc53c += (float)(dt.P3 ?? 0);
                }
                

            }
            int totalsv = lstKQ.Count;
            tc11a = tc11a / totalsv; tc11b = tc11b / totalsv; tc11c = tc11c / totalsv;
            tc12a = tc12a / totalsv; tc12b = tc12b / totalsv; tc12c = tc12c / totalsv;
            tc13a = tc13a / totalsv; tc13b = tc13b / totalsv; tc13c = tc13c / totalsv;
            //21 va 22
            tc21a = tc21a / totalsv; tc21b = tc21b / totalsv; tc21c = tc21c / totalsv;
            tc22a = tc22a / totalsv; tc22b = tc22b / totalsv; tc22c = tc22c / totalsv;
            //31,32,33
            tc31a = tc31a / totalsv; tc31b = tc31b / totalsv; tc31c = tc31c / totalsv;
            tc32a = tc32a / totalsv; tc32b = tc32b / totalsv; tc32c = tc32c / totalsv;
            tc33a = tc33a / totalsv; tc33b = tc33b / totalsv; tc33c = tc33c / totalsv;
            //41,42,43
            tc41a = tc41a / totalsv; tc41b = tc41b / totalsv; tc41c = tc41c / totalsv;
            tc42a = tc42a / totalsv; tc42b = tc42b / totalsv; tc42c = tc42c / totalsv;
            tc43a = tc43a / totalsv; tc43b = tc43b / totalsv; tc43c = tc43c / totalsv;
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
            s = "  " + "TC11" + "(" + tc11a + "," + tc11b + "," + tc11c + ")";

            s += "  " + "TC12(" + tc12a + "," + tc12b + "," + tc12c + ")";
            s += "  " + "TC13(" + tc13a + "," + tc13b + "," + tc13c + ")";
            s += "\r\n";
            s += "  " + "TC21(" + tc21a + "," + tc21b + "," + tc21c + ")";
            s += "  " + "TC22(" + tc22a + "," + tc22b + "," + tc22c + ")";
            s += "\r\n";
            s += "  " + "TC31(" + tc31a + "," + tc31b + "," + tc31c + ")";
            s += "  " + "TC32(" + tc32a + "," + tc32b + "," + tc32c + ")";
            s += "  " + "TC33(" + tc33a + "," + tc33b + "," + tc33c + ")";
            s += "\r\n";
            s += "  " + "TC41(" + tc41a + "," + tc41b + "," + tc41c + ")";
            s += "  " + "TC42(" + tc42a + "," + tc42b + "," + tc42c + ")";
            s += "  " + "TC43(" + tc43a + "," + tc43b + "," + tc43c + ")";
            s += "\r\n";
            s += "  " + "TC51(" + tc51a + "," + tc51b + "," + tc51c + ")";
            s += "  " + "TC52(" + tc52a + "," + tc52b + "," + tc52c + ")";
            s += "  " + "TC53(" + tc53a + "," + tc53b + "," + tc53c + ")";

            txtTieuchi.Text = s;


            //tinh tieu chuan
            //11,12,13
            tchuan1a = (tc11a + tc12a + tc13a) / 3;
            tchuan1b = (tc11b + tc12b + tc13b) / 3;
            tchuan1c = (tc11c + tc12c + tc13c) / 3;
            //21,22
            tchuan2a = (tc21a + tc22a) / 2;
            tchuan2b = (tc21b + tc22b) / 2;
            tchuan2c = (tc21c + tc22c) / 2;
            //31,32,33
            tchuan3a = (tc31a + tc32a + tc33a) / 3;
            tchuan3b = (tc31b + tc32b + tc33b) / 3;
            tchuan3c = (tc31c + tc32c + tc33c) / 3;
            //41,42,43
            tchuan4a = (tc41a + tc42a + tc43a) / 3;
            tchuan4b = (tc41b + tc42b + tc43b) / 3;
            tchuan4c = (tc41c + tc42c + tc43c) / 3;
            //51,52,53
            tchuan5a = (tc51a + tc52a + tc53a) / 3;
            tchuan5b = (tc51b + tc52b + tc53b) / 3;
            tchuan5c = (tc51c + tc52c + tc53c) / 3;

            string s1;
            s1 = "  " + "TIEUCHUAN1" + "(" + tchuan1a + "," + tchuan1b + "," + tchuan1c + ")";
            s1 += "\r\n";
            s1 += "  " + "TIEUCHUAN2" + "(" + tchuan2a + "," + tchuan2b + "," + tchuan2c + ")";
            s1 += "\r\n";
            s1 += "  " + "TIEUCHUAN3" + "(" + tchuan3a + "," + tchuan3b + "," + tchuan3c + ")";
            s1 += "\r\n";
            s1 += "  " + "TIEUCHUAN4" + "(" + tchuan4a + "," + tchuan4b + "," + tchuan4c + ")";
            s1 += "\r\n";
            s1 += "  " + "TIEUCHUAN5" + "(" + tchuan5a + "," + tchuan5b + "," + tchuan5c + ")";
            txtTieuchuan.Text = s1;

            //ket qua ren luyen


            string s3;
            kqa = (tchuan1a + tchuan2a + tchuan3a + tchuan4a + tchuan5a) / 5;
            kqb = (tchuan1b + tchuan2b + tchuan3b + tchuan4b + tchuan5b) / 5;
            kqc = (tchuan1c + tchuan2c + tchuan3c + tchuan4c + tchuan5c) / 5;

            s3 = "KETQUA" + "(" + kqa + "," + kqb + "," + kqc + ")";
            s3 += "\r\n" + "Kết quả tốt nghiệp  ";

            if (kqb <= 3)
            {
                xeploai = "Kém";

            }

            if (kqb > 3 && kqb < 4)
            {
                xeploai = "Yếu";
            }
            if (kqb >= 4 && kqb < 5)
            {
                if (kqb - 4 < 5 - kqb)

                    xeploai = "Yếu";

                else
                    xeploai = "Trung Bình";

            }

            if (kqb >= 5 && kqb < 6)
            {
                if (kqb - 5 < 6 - kqb)

                    xeploai = "Trung bình";

                else
                    xeploai = "Trung Bình-Khá";

            }

            if (kqb >= 6 && kqb < 7)
            {
                if (kqb - 6 < 7 - kqb)

                    xeploai = "Trung bình-Khá";

                else
                    xeploai = "Khá";

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
                xeploai = "Xuất sắc";
            }


            txtKetQua.Text = s3 + " " + xeploai;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string masv = cbochonsv.SelectedValue.ToString();
            string hoten = cbochonsv.Text;
            string ketqua = "(" + kqa + "," + kqb + "," + kqc + ")";
            string _xeploai = xeploai;

            var kqrl = new KETQUARENLUYEN
                {
                    MASV = masv,
                    HOTEN = hoten,
                    KETQUA = ketqua,
                    XEPLOAI = _xeploai,
                };
            var kq = KETQUARENLUYENDao.GetByPrimaryKey(masv);
            if (kq != null)
                KETQUARENLUYENDao.Update(kqrl);
            else
                KETQUARENLUYENDao.Insert(kqrl);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = KETQUARENLUYENDao.GetAll();
            dataGridView2.DataSource = dt.ToList();
        }


        private void frmKQRenLuyen_Load(object sender, EventArgs e)
        {
            dicTIEUCHUAN.Clear();
            var listtieuchuan = TIEUCHUANDao.GetAll();
            foreach (var tieuchuan in listtieuchuan)
            {
                dicTIEUCHUAN[tieuchuan.MATIECHUAN] = tieuchuan;
            }
            cbochonsv_SelectedIndexChanged(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
