using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using DatabaseDAL.Entities;

namespace DatabaseDAL.DataLayer
{
	/// <summary>
	/// Data access layer class for KETQUADANHGIA
	/// </summary>
	class KETQUADANHGIASql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public KETQUADANHGIASql()
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
		public bool Insert(KETQUADANHGIA businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[sp_KetQuaDanhGia_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@MASV", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MASV));
				sqlCommand.Parameters.Add(new SqlParameter("@MASVDANHGIA", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MASVDANHGIA));
				sqlCommand.Parameters.Add(new SqlParameter("@TC11", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc11));
				sqlCommand.Parameters.Add(new SqlParameter("@TC12", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc12));
				sqlCommand.Parameters.Add(new SqlParameter("@TC13", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc13));
				sqlCommand.Parameters.Add(new SqlParameter("@TC21", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc21));
				sqlCommand.Parameters.Add(new SqlParameter("@TC22", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc22));
				sqlCommand.Parameters.Add(new SqlParameter("@TC31", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc31));
				sqlCommand.Parameters.Add(new SqlParameter("@TC32", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc32));
				sqlCommand.Parameters.Add(new SqlParameter("@TC33", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc33));
				sqlCommand.Parameters.Add(new SqlParameter("@TC41", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc41));
				sqlCommand.Parameters.Add(new SqlParameter("@TC42", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc42));
				sqlCommand.Parameters.Add(new SqlParameter("@TC43", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc43));
				sqlCommand.Parameters.Add(new SqlParameter("@TC51", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc51));
				sqlCommand.Parameters.Add(new SqlParameter("@TC52", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc52));
				sqlCommand.Parameters.Add(new SqlParameter("@TC53", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc53));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                
				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("KETQUADANHGIA::Insert::Error occured.", ex);
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
        public bool Update(KETQUADANHGIA businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[sp_KetQuaDanhGia_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@MASV", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MASV));
				sqlCommand.Parameters.Add(new SqlParameter("@MASVDANHGIA", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MASVDANHGIA));
				sqlCommand.Parameters.Add(new SqlParameter("@TC11", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc11));
				sqlCommand.Parameters.Add(new SqlParameter("@TC12", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc12));
				sqlCommand.Parameters.Add(new SqlParameter("@TC13", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc13));
				sqlCommand.Parameters.Add(new SqlParameter("@TC21", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc21));
				sqlCommand.Parameters.Add(new SqlParameter("@TC22", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc22));
				sqlCommand.Parameters.Add(new SqlParameter("@TC31", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc31));
				sqlCommand.Parameters.Add(new SqlParameter("@TC32", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc32));
				sqlCommand.Parameters.Add(new SqlParameter("@TC33", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc33));
				sqlCommand.Parameters.Add(new SqlParameter("@TC41", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc41));
				sqlCommand.Parameters.Add(new SqlParameter("@TC42", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc42));
				sqlCommand.Parameters.Add(new SqlParameter("@TC43", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc43));
				sqlCommand.Parameters.Add(new SqlParameter("@TC51", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc51));
				sqlCommand.Parameters.Add(new SqlParameter("@TC52", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc52));
				sqlCommand.Parameters.Add(new SqlParameter("@TC53", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Tc53));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("KETQUADANHGIA::Update::Error occured.", ex);
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
        /// <returns>KETQUADANHGIA business object</returns>
        public KETQUADANHGIA SelectByPrimaryKey(KETQUADANHGIAKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KETQUADANHGIA_SelectByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    KETQUADANHGIA businessObject = new KETQUADANHGIA();

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
                throw new Exception("KETQUADANHGIA::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }
        public List<KETQUADANHGIA> SelectByMasv(string _masvdanhgia, string _masv)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[sp_KetQuaDanhGia_GetByID]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@masvdanhgia", _masvdanhgia));
                sqlCommand.Parameters.Add(new SqlParameter("@masv", _masv));

                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                
                    KETQUADANHGIA businessObject = new KETQUADANHGIA();

                    return PopulateObjectsFromReader(dataReader);
             
                
            }
            catch (Exception ex)
            {
                throw new Exception("KETQUADANHGIA::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
            return null;
        }

        public List<KETQUADANHGIA> GetAllKetQuaByMaSV(string _masvdanhgia)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[sp_KetQua_GetAll_GetByMaSV]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@masvdanhgia", _masvdanhgia));
               

                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();
                 
                    return PopulateObjectsFromReader(dataReader);
                
            }
            catch (Exception ex)
            {
                throw new Exception("KETQUADANHGIA::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
            return null;
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of KETQUADANHGIA</returns>
        public List<KETQUADANHGIA> SelectAll()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KETQUADANHGIA_SelectAll]";
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
                throw new Exception("KETQUADANHGIA::SelectAll::Error occured.", ex);
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
        /// <returns>list of KETQUADANHGIA</returns>
        public List<KETQUADANHGIA> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KETQUADANHGIA_SelectByField]";
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
                throw new Exception("KETQUADANHGIA::SelectByField::Error occured.", ex);
            }
            finally
            {

                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public List<KETQUADANHGIA> GetAllKetQuaByMaSVDanhGia(string masvdanhgia)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[sp_KetQua_GetAll_GetByMaSV]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@masvdanhgia", masvdanhgia));

                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {
                throw new Exception("KETQUADANHGIA::SelectByField::Error occured.", ex);
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
        public bool Delete(KETQUADANHGIAKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KETQUADANHGIA_DeleteByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {



                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("KETQUADANHGIA::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KETQUADANHGIA_DeleteByField]";
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
                throw new Exception("KETQUADANHGIA::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(KETQUADANHGIA businessObject, IDataReader dataReader)
        {


				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.MASV.ToString())))
				{
					businessObject.MASV = dataReader.GetString(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.MASV.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.MASVDANHGIA.ToString())))
				{
					businessObject.MASVDANHGIA = dataReader.GetString(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.MASVDANHGIA.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC11.ToString())))
				{
					businessObject.Tc11 = (int)dataReader.GetInt16(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC11.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC12.ToString())))
				{
					businessObject.Tc12 = (int)dataReader.GetInt16(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC12.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC13.ToString())))
				{
					businessObject.Tc13 = (int)dataReader.GetInt16(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC13.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC21.ToString())))
				{
					businessObject.Tc21 = (int)dataReader.GetInt16(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC21.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC22.ToString())))
				{
					businessObject.Tc22 = (int)dataReader.GetInt16(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC22.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC31.ToString())))
				{
					businessObject.Tc31 = (int)dataReader.GetInt16(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC31.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC32.ToString())))
				{
					businessObject.Tc32 = (int)dataReader.GetInt16(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC32.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC33.ToString())))
				{
					businessObject.Tc33 = (int)dataReader.GetInt16(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC33.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC41.ToString())))
				{
					businessObject.Tc41 = (int)dataReader.GetInt16(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC41.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC42.ToString())))
				{
					businessObject.Tc42 = (int)dataReader.GetInt16(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC42.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC43.ToString())))
				{
					businessObject.Tc43 = (int)dataReader.GetInt16(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC43.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC51.ToString())))
				{
					businessObject.Tc51 = (int)dataReader.GetInt16(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC51.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC52.ToString())))
				{
					businessObject.Tc52 = (int)dataReader.GetInt16(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC52.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC53.ToString())))
				{
					businessObject.Tc53 = (int)dataReader.GetInt16(dataReader.GetOrdinal(KETQUADANHGIA.KETQUADANHGIAFields.TC53.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of KETQUADANHGIA</returns>
        internal List<KETQUADANHGIA> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<KETQUADANHGIA> list = new List<KETQUADANHGIA>();

            while (dataReader.Read())
            {
                KETQUADANHGIA businessObject = new KETQUADANHGIA();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
