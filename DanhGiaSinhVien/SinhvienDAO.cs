using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace NhanXetSinhVien
{
    public class SinhvienDAO
    {
        private SQLExcute sqlexcute = new SQLExcute();
        public static SinhvienDAO Instance
        {
            get
            {
                return new SinhvienDAO();
            }
        }
        public int Insert(Sinhvien v)
        {
            String query = "sp_SinhVien_Insert";
            List<SqlParameter> para = new List<SqlParameter>();
            SqlParameter pID = new SqlParameter("@masv", v.Masv);
            pID.Direction = ParameterDirection.Output; ;
            para.Add(pID);
            SqlParameter pTenMon = new SqlParameter("@tensv", v.Tensv);
            para.Add(pTenMon);
            int kq = sqlexcute.SQLExcuteNoneQuery(query, para, CommandType.StoredProcedure);
           // v.Masv = pID.Value;
            return kq;
        }
        public int Update(Sinhvien v)
        {
            String query = "sp_SinhVien_Update";
            List<SqlParameter> para = new List<SqlParameter>();
            para.Add(new SqlParameter("@Masv", v.Masv));
            para.Add(new SqlParameter("@Tensv", v.Tensv));
            return sqlexcute.SQLExcuteNoneQuery(query, para, CommandType.StoredProcedure);
        }
        public int Delete(string masv)
        {
            String query = "sp_SinhVien_Delete";
            List<SqlParameter> para = new List<SqlParameter>();
            para.Add(new SqlParameter("@masv", masv));
            return sqlexcute.SQLExcuteNoneQuery(query, para, CommandType.StoredProcedure);
        }
        public DataTable GetAll(String _masv)
        {

            String query = "sp_SinhVien_GetAll_Ex";
            List<SqlParameter> para = new List<SqlParameter>();
            para.Add(new SqlParameter("@masv", _masv));
             DataTable tb = sqlexcute.FillDataTable(query, para, CommandType.StoredProcedure);

            return tb;
        }
        public List<Sinhvien> GetAllSinhVien()
        {
            List<Sinhvien> list = new List<Sinhvien>();
            String query = "sp_SinhVien_GetAll";
            DataTable tb = sqlexcute.FillDataTable(query, CommandType.StoredProcedure);
            try
            {
                foreach (DataRow row in tb.Rows)
                {
                    Sinhvien v = RowToClass(row);
                    list.Add(v);
                }
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable GetAllXepLoai()
        {
            String query = "sp_XepLoai_GetAll";
            DataTable tb1 = sqlexcute.FillDataTable(query, CommandType.StoredProcedure);

            return tb1;
        }
        public Sinhvien RowToClass(DataRow dr)
        {

            Sinhvien sv = new Sinhvien((String)dr["masv"], (String)dr["hoten"]);
            return sv;
        }
        public Sinhvien GetByMasv(String _masv)
        {
            String query = "sp_Sinhvien_GetByID";
            List<SqlParameter> para = new List<SqlParameter>();
            para.Add(new SqlParameter("@masv", _masv));
            DataTable tb = sqlexcute.FillDataTable(query, para, CommandType.StoredProcedure);
            try
            {
                foreach (DataRow row in tb.Rows)
                {
                    Sinhvien v = RowToClass(row);
                    return v;
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }
    }
}
