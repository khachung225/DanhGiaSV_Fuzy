using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using DatabaseDAL.Entities;

namespace DatabaseDAL.DataLayer
{
	/// <summary>
	/// Data access layer class for TIEUCHUAN
	/// </summary>
	class TIEUCHUANSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public TIEUCHUANSql()
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
		public bool Insert(TIEUCHUAN businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[TIEUCHUAN_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@MATIECHUAN", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MATIECHUAN));
				sqlCommand.Parameters.Add(new SqlParameter("@TENTIEUCHUAN", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TENTIEUCHUAN));
				sqlCommand.Parameters.Add(new SqlParameter("@P1", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.P1));
				sqlCommand.Parameters.Add(new SqlParameter("@P2", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.P2));
				sqlCommand.Parameters.Add(new SqlParameter("@P3", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.P3));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                
				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("TIEUCHUAN::Insert::Error occured.", ex);
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
        public bool Update(TIEUCHUAN businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[TIEUCHUAN_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@MATIECHUAN", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MATIECHUAN));
				sqlCommand.Parameters.Add(new SqlParameter("@TENTIEUCHUAN", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TENTIEUCHUAN));
				sqlCommand.Parameters.Add(new SqlParameter("@P1", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.P1));
				sqlCommand.Parameters.Add(new SqlParameter("@P2", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.P2));
				sqlCommand.Parameters.Add(new SqlParameter("@P3", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.P3));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("TIEUCHUAN::Update::Error occured.", ex);
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
        /// <returns>TIEUCHUAN business object</returns>
        public TIEUCHUAN SelectByPrimaryKey(int key)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[sp_TieuChuan_GetByID]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@MATIECHUAN", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, key));

                
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    TIEUCHUAN businessObject = new TIEUCHUAN();

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
                throw new Exception("TIEUCHUAN::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of TIEUCHUAN</returns>
        public List<TIEUCHUAN> SelectAll()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[sp_XepLoai_GetAll]";
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
                throw new Exception("TIEUCHUAN::SelectAll::Error occured.", ex);
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
        /// <returns>list of TIEUCHUAN</returns>
        public List<TIEUCHUAN> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[TIEUCHUAN_SelectByField]";
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
                throw new Exception("TIEUCHUAN::SelectByField::Error occured.", ex);
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
        public bool Delete(int key)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[TIEUCHUAN_DeleteByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@MATIECHUAN", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, key));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("TIEUCHUAN::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[TIEUCHUAN_DeleteByField]";
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
                throw new Exception("TIEUCHUAN::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(TIEUCHUAN businessObject, IDataReader dataReader)
        {


				businessObject.MATIECHUAN = dataReader.GetInt32(dataReader.GetOrdinal(TIEUCHUAN.TIEUCHUANFields.MATIECHUAN.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(TIEUCHUAN.TIEUCHUANFields.TENTIEUCHUAN.ToString())))
				{
					businessObject.TENTIEUCHUAN = dataReader.GetString(dataReader.GetOrdinal(TIEUCHUAN.TIEUCHUANFields.TENTIEUCHUAN.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(TIEUCHUAN.TIEUCHUANFields.P1.ToString())))
				{
					businessObject.P1 = dataReader.GetDouble(dataReader.GetOrdinal(TIEUCHUAN.TIEUCHUANFields.P1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(TIEUCHUAN.TIEUCHUANFields.P2.ToString())))
				{
					businessObject.P2 = dataReader.GetDouble(dataReader.GetOrdinal(TIEUCHUAN.TIEUCHUANFields.P2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(TIEUCHUAN.TIEUCHUANFields.P3.ToString())))
				{
					businessObject.P3 = dataReader.GetDouble(dataReader.GetOrdinal(TIEUCHUAN.TIEUCHUANFields.P3.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of TIEUCHUAN</returns>
        internal List<TIEUCHUAN> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<TIEUCHUAN> list = new List<TIEUCHUAN>();

            while (dataReader.Read())
            {
                TIEUCHUAN businessObject = new TIEUCHUAN();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
