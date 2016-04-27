using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using DatabaseDAL.Entities;

namespace DatabaseDAL.DataLayer
{
	/// <summary>
	/// Data access layer class for KETQUARENLUYEN
	/// </summary>
	class KETQUARENLUYENSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public KETQUARENLUYENSql()
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
		public bool Insert(KETQUARENLUYEN businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[sp_KetQuaRenLuyen_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@MASV", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MASV));
				sqlCommand.Parameters.Add(new SqlParameter("@HOTEN", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.HOTEN));
				sqlCommand.Parameters.Add(new SqlParameter("@KETQUA", SqlDbType.NVarChar, 150, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KETQUA));
				sqlCommand.Parameters.Add(new SqlParameter("@XEPLOAI", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.XEPLOAI));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                
				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("KETQUARENLUYEN::Insert::Error occured.", ex);
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
        public bool Update(KETQUARENLUYEN businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[sp_KetQuaRenLuyen_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@MASV", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MASV));
				sqlCommand.Parameters.Add(new SqlParameter("@HOTEN", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.HOTEN));
				sqlCommand.Parameters.Add(new SqlParameter("@KETQUA", SqlDbType.NVarChar, 150, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KETQUA));
				sqlCommand.Parameters.Add(new SqlParameter("@XEPLOAI", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.XEPLOAI));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("KETQUARENLUYEN::Update::Error occured.", ex);
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
        /// <returns>KETQUARENLUYEN business object</returns>
        public KETQUARENLUYEN SelectByPrimaryKey(string key)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[sp_KetQuaRenLuyen_GetByID]"; //KETQUARENLUYEN_SelectByPrimaryKey
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
                    KETQUARENLUYEN businessObject = new KETQUARENLUYEN();

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
                throw new Exception("KETQUARENLUYEN::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of KETQUARENLUYEN</returns>
        public List<KETQUARENLUYEN> SelectAll()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[sp_KetQuaRenLuyen_GetAll]"; // KETQUARENLUYEN_SelectAll
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
                throw new Exception("KETQUARENLUYEN::SelectAll::Error occured.", ex);
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
        /// <returns>list of KETQUARENLUYEN</returns>
        public List<KETQUARENLUYEN> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KETQUARENLUYEN_SelectByField]";
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
                throw new Exception("KETQUARENLUYEN::SelectByField::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KETQUARENLUYEN_DeleteByPrimaryKey]";
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
                throw new Exception("KETQUARENLUYEN::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KETQUARENLUYEN_DeleteByField]";
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
                throw new Exception("KETQUARENLUYEN::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(KETQUARENLUYEN businessObject, IDataReader dataReader)
        {


				businessObject.MASV = dataReader.GetString(dataReader.GetOrdinal(KETQUARENLUYEN.KETQUARENLUYENFields.MASV.ToString()));

				businessObject.HOTEN = dataReader.GetString(dataReader.GetOrdinal(KETQUARENLUYEN.KETQUARENLUYENFields.HOTEN.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUARENLUYEN.KETQUARENLUYENFields.KETQUA.ToString())))
				{
					businessObject.KETQUA = dataReader.GetString(dataReader.GetOrdinal(KETQUARENLUYEN.KETQUARENLUYENFields.KETQUA.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUARENLUYEN.KETQUARENLUYENFields.XEPLOAI.ToString())))
				{
					businessObject.XEPLOAI = dataReader.GetString(dataReader.GetOrdinal(KETQUARENLUYEN.KETQUARENLUYENFields.XEPLOAI.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of KETQUARENLUYEN</returns>
        internal List<KETQUARENLUYEN> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<KETQUARENLUYEN> list = new List<KETQUARENLUYEN>();

            while (dataReader.Read())
            {
                KETQUARENLUYEN businessObject = new KETQUARENLUYEN();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
