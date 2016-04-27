using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace NhanXetSinhVien
{
    class KetQuaRenLuyenDAO
    {
        
   
        private SQLExcute sqlexcute = new SQLExcute();
        public static KetQuaRenLuyenDAO Instance
        {
            get
            {
                return new KetQuaRenLuyenDAO();
            }
        }
        public int GetByMasv(string _masv)
        {
            String query = "sp_KetQuaRenLuyen_GetByID";
            List<SqlParameter> para = new List<SqlParameter>();
            para.Add(new SqlParameter("@masv", _masv));
            DataTable tb = sqlexcute.FillDataTable(query, para, CommandType.StoredProcedure);
            return tb.Rows.Count > 0 ? 1 : 0;
           
        }
        public int Insert(string _masv,string _hoten,string _ketqua,string _xeploai)
        {
            String query = "sp_KetQuaRenLuyen_Insert";
            List<SqlParameter> para = new List<SqlParameter>();
            SqlParameter pID = new SqlParameter("@masv", _masv);
            para.Add(pID);
            SqlParameter pHoten = new SqlParameter("@hoten", _hoten);
            para.Add(pHoten);
            SqlParameter pKetqua = new SqlParameter("@ketqua", _ketqua);
            para.Add(pKetqua);
            SqlParameter pXeploai = new SqlParameter("@xeploai", _xeploai);
            para.Add(pXeploai);

            int kq = sqlexcute.SQLExcuteNoneQuery(query, para, CommandType.StoredProcedure);
            // v.Masv = pID.Value;
            return kq;
        }
        public int Update(string _masv, string _hoten, string _ketqua, string _xeploai)
        {
            String query = "sp_KetQuaRenLuyen_Update";
            List<SqlParameter> para = new List<SqlParameter>();
            SqlParameter pID = new SqlParameter("@masv", _masv);
            para.Add(pID);
            SqlParameter pHoten = new SqlParameter("@hoten", _hoten);
            para.Add(pHoten);
            SqlParameter pKetqua = new SqlParameter("@ketqua", _ketqua);
            para.Add(pKetqua);
            SqlParameter pXeploai = new SqlParameter("@xeploai", _xeploai);
            para.Add(pXeploai);

            int kq = sqlexcute.SQLExcuteNoneQuery(query, para, CommandType.StoredProcedure);
            return kq;
        }
        public DataTable GetAllKetQuaRenLuyen()
        {
            String query = "sp_KetQuaRenLuyen_GetAll";
            DataTable tb1 = sqlexcute.FillDataTable(query, CommandType.StoredProcedure);

            return tb1;
        }
    }
}
