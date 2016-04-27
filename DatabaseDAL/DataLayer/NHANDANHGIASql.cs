using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using DatabaseDAL.Entities;

namespace DatabaseDAL.DataLayer
{
	/// <summary>
	/// Data access layer class for NHANDANHGIA
	/// </summary>
	class NHANDANHGIASql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public NHANDANHGIASql()
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
		public bool Insert(NHANDANHGIA businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[NHANDANHGIA_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@MALOAI", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MALOAI));
				sqlCommand.Parameters.Add(new SqlParameter("@TENLOAI", SqlDbType.NVarChar, 150, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TENLOAI));
				sqlCommand.Parameters.Add(new SqlParameter("@P1", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.P1));
				sqlCommand.Parameters.Add(new SqlParameter("@P2", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.P2));
				sqlCommand.Parameters.Add(new SqlParameter("@P3", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.P3));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                
				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("NHANDANHGIA::Insert::Error occured.", ex);
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
        public bool Update(NHANDANHGIA businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[NHANDANHGIA_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@MALOAI", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MALOAI));
				sqlCommand.Parameters.Add(new SqlParameter("@TENLOAI", SqlDbType.NVarChar, 150, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TENLOAI));
				sqlCommand.Parameters.Add(new SqlParameter("@P1", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.P1));
				sqlCommand.Parameters.Add(new SqlParameter("@P2", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.P2));
				sqlCommand.Parameters.Add(new SqlParameter("@P3", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.P3));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("NHANDANHGIA::Update::Error occured.", ex);
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
        /// <returns>NHANDANHGIA business object</returns>
        public NHANDANHGIA SelectByPrimaryKey(byte key)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[NHANDANHGIA_SelectByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@MALOAI", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, key));

                
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    NHANDANHGIA businessObject = new NHANDANHGIA();

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
                throw new Exception("NHANDANHGIA::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of NHANDANHGIA</returns>
        public List<NHANDANHGIA> SelectAll()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[NHANDANHGIA_SelectAll]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {                
                throw new Exception("NHANDANHGIA::SelectAll::Error occured.", ex);
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
        /// <returns>list of NHANDANHGIA</returns>
        public List<NHANDANHGIA> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[NHANDANHGIA_SelectByField]";
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
                throw new Exception("NHANDANHGIA::SelectByField::Error occured.", ex);
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
        public bool Delete(byte key)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[NHANDANHGIA_DeleteByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@MALOAI", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, key));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("NHANDANHGIA::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[NHANDANHGIA_DeleteByField]";
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
                throw new Exception("NHANDANHGIA::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(NHANDANHGIA businessObject, IDataReader dataReader)
        {


				businessObject.MALOAI = (byte)dataReader.GetInt16(dataReader.GetOrdinal(NHANDANHGIA.NHANDANHGIAFields.MALOAI.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NHANDANHGIA.NHANDANHGIAFields.TENLOAI.ToString())))
				{
					businessObject.TENLOAI = dataReader.GetString(dataReader.GetOrdinal(NHANDANHGIA.NHANDANHGIAFields.TENLOAI.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NHANDANHGIA.NHANDANHGIAFields.P1.ToString())))
				{
					businessObject.P1 = dataReader.GetDouble(dataReader.GetOrdinal(NHANDANHGIA.NHANDANHGIAFields.P1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NHANDANHGIA.NHANDANHGIAFields.P2.ToString())))
				{
					businessObject.P2 = dataReader.GetDouble(dataReader.GetOrdinal(NHANDANHGIA.NHANDANHGIAFields.P2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NHANDANHGIA.NHANDANHGIAFields.P3.ToString())))
				{
					businessObject.P3 = dataReader.GetDouble(dataReader.GetOrdinal(NHANDANHGIA.NHANDANHGIAFields.P3.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of NHANDANHGIA</returns>
        internal List<NHANDANHGIA> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<NHANDANHGIA> list = new List<NHANDANHGIA>();

            while (dataReader.Read())
            {
                NHANDANHGIA businessObject = new NHANDANHGIA();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
