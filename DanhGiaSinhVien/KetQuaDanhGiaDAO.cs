using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace NhanXetSinhVien
{
    class KetQuaDanhGiaDAO
    {
        private SQLExcute sqlexcute = new SQLExcute();
        public static KetQuaDanhGiaDAO Instance
        {
            get
            {
                return new KetQuaDanhGiaDAO();
            }
        }


        public int Insert(KETQUANDANHGIA k)
        {
            String query = "sp_KetQuaDanhGia_Insert";
            List<SqlParameter> para = new List<SqlParameter>();
            SqlParameter masv = new SqlParameter("@masv", k.Masv);
            SqlParameter masvdanhgia = new SqlParameter("@masvdanhgia", k.Masvdanhgia);
            masv.Direction = ParameterDirection.InputOutput;
            para.Add(masv);
            para.Add(masvdanhgia);
            
            SqlParameter tc11 = new SqlParameter("@tc11", k.Tc11);
            SqlParameter tc12 = new SqlParameter("@tc12", k.Tc12);
            SqlParameter tc13 = new SqlParameter("@tc13", k.Tc13);
            SqlParameter tc21 = new SqlParameter("@tc21", k.Tc21);
            SqlParameter tc22 = new SqlParameter("@tc22", k.Tc22);
            SqlParameter tc31 = new SqlParameter("@tc31", k.Tc31);
            SqlParameter tc32 = new SqlParameter("@tc32", k.Tc32);
            SqlParameter tc33 = new SqlParameter("@tc33", k.Tc33);
            SqlParameter tc41 = new SqlParameter("@tc41", k.Tc41);
            SqlParameter tc42 = new SqlParameter("@tc42", k.Tc42);
            SqlParameter tc43 = new SqlParameter("@tc43", k.Tc43);
            SqlParameter tc51 = new SqlParameter("@tc51", k.Tc51);
            SqlParameter tc52 = new SqlParameter("@tc52", k.Tc52);
            SqlParameter tc53 = new SqlParameter("@tc53", k.Tc53);
            para.Add(tc11); para.Add(tc12); para.Add(tc13);
            para.Add(tc21); para.Add(tc22);
            para.Add(tc31); para.Add(tc32); para.Add(tc33);
            para.Add(tc41); para.Add(tc42); para.Add(tc43);
            para.Add(tc51); para.Add(tc52); para.Add(tc53);
            int kq = sqlexcute.SQLExcuteNoneQuery(query, para, CommandType.StoredProcedure);
            // v.Masv = pID.Value;
            return kq;
        }
        public int Update(KETQUANDANHGIA k)
        {
            String query = "sp_KetQuaDanhGia_Update";
            List<SqlParameter> para = new List<SqlParameter>();
            SqlParameter masv = new SqlParameter("@masv", k.Masv);
            SqlParameter masvdanhgia = new SqlParameter("@masvdanhgia", k.Masvdanhgia);
            masv.Direction = ParameterDirection.InputOutput; ;
            para.Add(masv);
            para.Add(masvdanhgia);
            SqlParameter tc11 = new SqlParameter("@tc11", k.Tc11);
            SqlParameter tc12 = new SqlParameter("@tc12", k.Tc12);
            SqlParameter tc13 = new SqlParameter("@tc13", k.Tc13);
            SqlParameter tc21 = new SqlParameter("@tc21", k.Tc21);
            SqlParameter tc22 = new SqlParameter("@tc22", k.Tc22);
            SqlParameter tc31 = new SqlParameter("@tc31", k.Tc31);
            SqlParameter tc32 = new SqlParameter("@tc32", k.Tc32);
            SqlParameter tc33 = new SqlParameter("@tc33", k.Tc33);
            SqlParameter tc41 = new SqlParameter("@tc41", k.Tc41);
            SqlParameter tc42 = new SqlParameter("@tc42", k.Tc42);
            SqlParameter tc43 = new SqlParameter("@tc43", k.Tc43);
            SqlParameter tc51 = new SqlParameter("@tc51", k.Tc51);
            SqlParameter tc52 = new SqlParameter("@tc52", k.Tc52);
            SqlParameter tc53 = new SqlParameter("@tc53", k.Tc53);
            para.Add(tc11); para.Add(tc12); para.Add(tc13);
            para.Add(tc21); para.Add(tc22);
            para.Add(tc31); para.Add(tc32); para.Add(tc33);
            para.Add(tc41); para.Add(tc42); para.Add(tc43);
            para.Add(tc51); para.Add(tc52); para.Add(tc53);
            int kq = sqlexcute.SQLExcuteNoneQuery(query, para, CommandType.StoredProcedure);
            // v.Masv = pID.Value;
            return kq;
        }
        public KETQUANDANHGIA RowToClass(DataRow dr)
        {

            KETQUANDANHGIA kq = new KETQUANDANHGIA((string)dr["masv"],(string)dr["masvdanhgia"],
                            int.Parse(dr["tc11"].ToString()), int.Parse(dr["tc12"].ToString()), int.Parse(dr["tc13"].ToString()),
                            int.Parse(dr["tc21"].ToString()), int.Parse(dr["tc22"].ToString()),
                            int.Parse(dr["tc31"].ToString()), int.Parse(dr["tc32"].ToString()), int.Parse(dr["tc33"].ToString()),
                            int.Parse(dr["tc41"].ToString()), int.Parse(dr["tc42"].ToString()), int.Parse(dr["tc43"].ToString()),
                            int.Parse(dr["tc51"].ToString()), int.Parse(dr["tc52"].ToString()), int.Parse(dr["tc53"].ToString()));
            return kq;
        }
        public DataTable GetAllKetQuaVaTieuChuan()
        {

            String query = "sp_KetQua_TieuChuan";
            DataTable tb = sqlexcute.FillDataTable(query, CommandType.StoredProcedure);
            return tb;
        }
        public List<KETQUANDANHGIA> GetAllKetQuaDanhGiaByMaSV()
        {
            List<KETQUANDANHGIA> list = new List<KETQUANDANHGIA>();
            String query = "sp_KetQua_GetAll";
            DataTable tb = sqlexcute.FillDataTable(query, CommandType.StoredProcedure);
            try
            {
                foreach (DataRow row in tb.Rows)
                {
                    KETQUANDANHGIA v = RowToClass(row);
                    list.Add(v);
                }
                return list;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<KETQUANDANHGIA> GetAllKetQuaByMaSVDanhGia(string _masvdanhgia)
        {
            String query = "sp_KetQua_GetAll_GetByMaSV";
            List<KETQUANDANHGIA> list = new List<KETQUANDANHGIA>();
            List<SqlParameter> para = new List<SqlParameter>();
            para.Add(new SqlParameter("@masvdanhgia", _masvdanhgia));

            DataTable tb = sqlexcute.FillDataTable(query, para, CommandType.StoredProcedure);
            try
            {
                foreach (DataRow row in tb.Rows)
                {
                    KETQUANDANHGIA v = RowToClass(row);
                    list.Add(v);
                }
                return list;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetAllKetQuaByMaSV(string _masvdanhgia)
        {
            String query = "sp_KetQua_GetAll_GetByMaSV";
            List<SqlParameter> para = new List<SqlParameter>();
            para.Add(new SqlParameter("@masvdanhgia", _masvdanhgia));

            DataTable tb = sqlexcute.FillDataTable(query, para, CommandType.StoredProcedure);
            return tb;
        }
        public DataTable GetByMaTieuChuan(int _matieuchuan)
        {
            String query = "sp_TieuChuan_GetByID";
            List<SqlParameter> para = new List<SqlParameter>();
            para.Add(new SqlParameter("@matieuchuan", _matieuchuan));
            DataTable tb = sqlexcute.FillDataTable(query, para, CommandType.StoredProcedure);
            return tb;
        }
        public int  GetByMasv(string _masvdanhgia,string _masv)
        {
            String query = "sp_KetQuaDanhGia_GetByID";
            List<SqlParameter> para = new List<SqlParameter>();
            para.Add(new SqlParameter("@masvdanhgia", _masvdanhgia));
            para.Add(new SqlParameter("@masv", _masv));
            DataTable tb = sqlexcute.FillDataTable(query, para, CommandType.StoredProcedure);
            return tb.Rows.Count > 0 ? 1 : 0;
            //try
            //{
            //    foreach (DataRow row in tb.Rows)
            //    {
            //        KETQUANDANHGIA v = RowToClass(row);
            //        return v;
            //    }
            //}
            //catch (Exception)
            //{
            //    return null;
            //}
            //return null;
        }
    }
}
