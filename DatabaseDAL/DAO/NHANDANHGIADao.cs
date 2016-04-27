using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DatabaseDAL.DataLayer;
using DatabaseDAL.Entities;

namespace DatabaseDAL.DAO
{
    public class NHANDANHGIADao
    {

        #region Data Members

        private NHANDANHGIASql _dataObject = null;

        #endregion

        #region Constructor

        public NHANDANHGIADao()
        {
            _dataObject = new NHANDANHGIASql();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Insert new NHANDANHGIA
        /// </summary>
        /// <param name="businessObject">NHANDANHGIA object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(NHANDANHGIA businessObject)
        {
            return _dataObject.Insert(businessObject);
        }

        /// <summary>
        /// Update existing NHANDANHGIA
        /// </summary>
        /// <param name="businessObject">NHANDANHGIA object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(NHANDANHGIA businessObject)
        {
            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get NHANDANHGIA by primary key.
        /// </summary>
        /// <param name="key">primary key</param>
        /// <returns>NHANDANHGIA</returns>
        public NHANDANHGIA GetByPrimaryKey(byte key)
        {
            return _dataObject.SelectByPrimaryKey(key); 
        }

        /// <summary>
        /// get list of all NHANDANHGIAs
        /// </summary>
        /// <returns>list</returns>
        public List<NHANDANHGIA> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of NHANDANHGIA by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<NHANDANHGIA> GetAllBy(NHANDANHGIA.NHANDANHGIAFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="key">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(byte key)
        {
            return _dataObject.Delete(key); 
        }

        /// <summary>
        /// delete NHANDANHGIA by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(NHANDANHGIA.NHANDANHGIAFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
