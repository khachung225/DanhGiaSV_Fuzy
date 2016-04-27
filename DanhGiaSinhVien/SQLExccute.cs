using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace NhanXetSinhVien
{
    public class SQLExcute
    {
        public static string server=".";
        public static SqlConnection _sqlcon = new SqlConnection("Data Source=local;Initial Catalog=DIEMRENLUYEN;User ID=lemon;Password=admin");
        public SQLExcute()
        {
            
        }
        public SQLExcute(string conStr)
        {
            if (_sqlcon == null)
                _sqlcon = new SqlConnection(conStr);
        }
        public SqlConnection OpenConnection()
        {
            try
            {
                //CloseConnection();
                //_sqlcon = new SqlConnection(System.Web.Configuration.WebConfigurationManager.AppSettings["connection"]);

                _sqlcon.Open();
                return _sqlcon;
            }
            catch (Exception ex)
            {
                CloseConnection();
                //WriteErrorLog("Open Connection"+ex.ToString());
                return null;
            }
        }
        public void WriteErrorLog(String s)
        {
            StreamWriter sw = new StreamWriter(".\\Log.txt", true);
            sw.Write("--\n\n" + s + "\n\n--");
            sw.Close();
        }
        //public  SqlConnection OpenConnection(string conStr)
        //{
        //    try
        //    {
        //        _sqlcon = new SqlConnection(conStr);
        //        _sqlcon.Open();
        //        return _sqlcon;
        //    }
        //    catch (Exception  ex)
        //    {
        //        CloseConnection();
        //        //WriteErrorLog("OpenConnection"+ex.ToString());
        //        return _sqlcon;
        //    }
        //}
        public SqlConnection CloseConnection()
        {
            try
            {
                //_sqlcon = new SqlConnection(conStr);
                if (_sqlcon.State != ConnectionState.Closed)
                    _sqlcon.Close();
                return _sqlcon;
            }
            catch (Exception ex)
            {
                //WriteErrorLog(ex.ToString());
                return _sqlcon;
            }
        }
        public int SQLExcuteNoneQuery(string cmd, CommandType cmdType)
        {
            try
            {
                OpenConnection();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = cmdType;
                sqlcmd.CommandText = cmd;
                sqlcmd.Connection = _sqlcon;
                int result = sqlcmd.ExecuteNonQuery();
                CloseConnection();
                return result;
            }
            catch (Exception ex)
            {
                //WriteErrorLog(ex.ToString());
                CloseConnection();
                return 0;
            }

        }
        public int SQLExcuteNoneQuery(string cmd, List<SqlParameter> sqlpara, CommandType cmdType)
        {
            try
            {
                OpenConnection();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = cmdType;
                sqlcmd.CommandText = cmd;
                sqlcmd.Connection = _sqlcon;
                for (int i = 0; i < sqlpara.Count; i++)
                    sqlcmd.Parameters.Add(sqlpara[i]);
                int result = sqlcmd.ExecuteNonQuery();
                //  _sqlcon.Close();
                CloseConnection();
                return result;
            }
            catch (SqlException ex)
            {
                //WriteErrorLog(ex.ToString());
                CloseConnection();
                return 0;
            }
        }

        public static DataSet FillDataSet(string cmd, CommandType cmdType)
        {

            return null;
        }
        public DataTable FillDataTable(string cmd, CommandType cmdType)
        {
            try
            {
                OpenConnection();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = cmdType;
                sqlcmd.CommandText = cmd;
                sqlcmd.Connection = _sqlcon;

                //SqlDataReader sqlreader = sqlcmd.ExecuteReader();                
                DataTable tb = new DataTable();
                SqlDataAdapter db = new SqlDataAdapter(sqlcmd);
                db.Fill(tb);
                db.Dispose();
                CloseConnection();
                return tb;
            }
            catch (Exception ex)
            {
                //WriteErrorLog(ex.ToString());
                CloseConnection();
                return null;
            }

        }
        public DataSet FillDataSet(string cmd, List<SqlParameter> sqlpara, CommandType cmdType)
        {
            return null;
        }
        public DataTable FillDataTable(string cmd, List<SqlParameter> sqlpara, CommandType cmdType)
        {
            try
            {
                OpenConnection();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = cmdType;
                sqlcmd.CommandText = cmd;
                sqlcmd.Connection = _sqlcon;
                for (int i = 0; i < sqlpara.Count; i++)
                    sqlcmd.Parameters.Add(sqlpara[i]);
                //SqlDataReader sqlreader = sqlcmd.ExecuteReader();                
                DataTable tb = new DataTable();
                SqlDataAdapter db = new SqlDataAdapter(sqlcmd);

                db.Fill(tb);
                db.Dispose();
                CloseConnection();
                return tb;
            }
            catch (Exception ex)
            {
                //WriteErrorLog(ex.ToString());
                CloseConnection();
                return null;
            }
        }
    }
}
