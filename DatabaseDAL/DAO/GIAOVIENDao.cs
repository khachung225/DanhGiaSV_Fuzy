using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DatabaseDAL.DataLayer;
using DatabaseDAL.Entities;

namespace DatabaseDAL.DAO
{
    public class GIAOVIENDao
    {

        #region Data Members

        private GIAOVIENSql _dataObject = null;

        #endregion

        #region Constructor

        public GIAOVIENDao()
        {
            _dataObject = new GIAOVIENSql();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Insert new GIAOVIEN
        /// </summary>
        /// <param name="businessObject">GIAOVIEN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(GIAOVIEN businessObject)
        {
            return _dataObject.Insert(businessObject);
        }

        /// <summary>
        /// Update existing GIAOVIEN
        /// </summary>
        /// <param name="businessObject">GIAOVIEN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(GIAOVIEN businessObject)
        {
            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get GIAOVIEN by primary key.
        /// </summary>
        /// <param name="key">primary key</param>
        /// <returns>GIAOVIEN</returns>
        public GIAOVIEN GetByPrimaryKey(int key)
        {
            return _dataObject.SelectByPrimaryKey(key); 
        }

        /// <summary>
        /// get list of all GIAOVIENs
        /// </summary>
        /// <returns>list</returns>
        public List<GIAOVIEN> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of GIAOVIEN by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<GIAOVIEN> GetAllBy(GIAOVIEN.GIAOVIENFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="key">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(int key)
        {
            return _dataObject.Delete(key); 
        }

        /// <summary>
        /// delete GIAOVIEN by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(GIAOVIEN.GIAOVIENFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

         
    }
}
