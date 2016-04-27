using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using DatabaseDAL.Entities;

namespace DatabaseDAL.DataLayer
{
	/// <summary>
	/// Data access layer class for SINHVIEN
	/// </summary>
	class SINHVIENSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public SINHVIENSql()
		{
			// Nothing for now.
		}

        #endregion

        #region Public Methods

        /// <summary>
        /// insert new row in the table
        /// </summary>
		/// <param name="businessObject">business object</param>
		/// <returns>true of successfully insert</returns>
		public bool Insert(SINHVIEN businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[SINHVIEN_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@MASV", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MASV));
				sqlCommand.Parameters.Add(new SqlParameter("@HOTEN", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.HOTEN));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                
				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("SINHVIEN::Insert::Error occured.", ex);
			}
			finally
			{			
				MainConnection.Close();
				sqlCommand.Dispose();
			}
		}

        /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(SINHVIEN businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[SINHVIEN_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@MASV", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MASV));
				sqlCommand.Parameters.Add(new SqlParameter("@HOTEN", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.HOTEN));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("SINHVIEN::Update::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>SINHVIEN business object</returns>
        public SINHVIEN SelectByPrimaryKey(string key)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[SINHVIEN_SelectByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@MASV", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, key));

                
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    SINHVIEN businessObject = new SINHVIEN();

                    PopulateBusinessObjectFromReader(businessObject, dataReader);

                    return businessObject;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("SINHVIEN::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of SINHVIEN</returns>
        public List<SINHVIEN> SelectAll( string masv)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[sp_SinhVien_GetAll_Ex]";
//            sqlCommand.CommandText = "dbo.[SINHVIEN_SelectAll]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                sqlCommand.Parameters.Add(new SqlParameter("@masv", masv));
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {                
                throw new Exception("SINHVIEN::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Select records by field
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>list of SINHVIEN</returns>
        public List<SINHVIEN> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[SINHVIEN_SelectByField]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@FieldName", fieldName));
                sqlCommand.Parameters.Add(new SqlParameter("@Value", value));

                MainConnection.Open();
                
                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {
                throw new Exception("SINHVIEN::SelectByField::Error occured.", ex);
            }
            finally
            {

                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Delete by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(string key)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[SINHVIEN_DeleteByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@MASV", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, key));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("SINHVIEN::DeleteByKey::Error occured.", ex);
            }
            finally
            {                
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Delete records by field
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>true for successfully deleted</returns>
        public bool DeleteByField(string fieldName, object value)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[SINHVIEN_DeleteByField]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@FieldName", fieldName));
                sqlCommand.Parameters.Add(new SqlParameter("@Value", value));
                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {                
                throw new Exception("SINHVIEN::DeleteByField::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Populate business object from data reader
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <param name="dataReader">data reader</param>
        internal void PopulateBusinessObjectFromReader(SINHVIEN businessObject, IDataReader dataReader)
        {


				businessObject.MASV = dataReader.GetString(dataReader.GetOrdinal(SINHVIEN.SINHVIENFields.MASV.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(SINHVIEN.SINHVIENFields.HOTEN.ToString())))
				{
					businessObject.HOTEN = dataReader.GetString(dataReader.GetOrdinal(SINHVIEN.SINHVIENFields.HOTEN.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of SINHVIEN</returns>
        internal List<SINHVIEN> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<SINHVIEN> list = new List<SINHVIEN>();

            while (dataReader.Read())
            {
                SINHVIEN businessObject = new SINHVIEN();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

        public List<SINHVIEN> GetAllXepLoai(string masv)
	    {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[sp_XepLoai_GetAll]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                //sqlCommand.Parameters.Add(new SqlParameter("@masv", masv));
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {
                throw new Exception("SINHVIEN::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

	    }
	}
}
