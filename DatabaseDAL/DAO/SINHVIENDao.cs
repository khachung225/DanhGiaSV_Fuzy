using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DatabaseDAL.DataLayer;
using DatabaseDAL.Entities;

namespace DatabaseDAL.DAO
{
    public class SINHVIENDao
    {

        #region Data Members

        private SINHVIENSql _dataObject = null;

        #endregion

        #region Constructor

        public SINHVIENDao()
        {
            _dataObject = new SINHVIENSql();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Insert new SINHVIEN
        /// </summary>
        /// <param name="businessObject">SINHVIEN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(SINHVIEN businessObject)
        {
            return _dataObject.Insert(businessObject);
        }

        /// <summary>
        /// Update existing SINHVIEN
        /// </summary>
        /// <param name="businessObject">SINHVIEN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(SINHVIEN businessObject)
        {
            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get SINHVIEN by primary key.
        /// </summary>
        /// <param name="key">primary key</param>
        /// <returns>SINHVIEN</returns>
        public SINHVIEN GetByPrimaryKey(string key)
        {
            return _dataObject.SelectByPrimaryKey(key); 
        }

        /// <summary>
        /// get list of all SINHVIENs
        /// </summary>
        /// <returns>list</returns>
        public List<SINHVIEN> GetAll(string masv)
        {
            return _dataObject.SelectAll(masv); 
        }

        public List<SINHVIEN> GetAllXepLoai(string masv)
        {
            return _dataObject.GetAllXepLoai(masv);
        }

        /// <summary>
        /// get list of SINHVIEN by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<SINHVIEN> GetAllBy(SINHVIEN.SINHVIENFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="key">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(string key)
        {
            return _dataObject.Delete(key); 
        }

        /// <summary>
        /// delete SINHVIEN by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(SINHVIEN.SINHVIENFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
