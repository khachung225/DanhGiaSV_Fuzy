using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DatabaseDAL.DataLayer;
using DatabaseDAL.Entities;

namespace DatabaseDAL.DAO
{
    public class TIEUCHUANDao
    {

        #region Data Members

        private TIEUCHUANSql _dataObject = null;

        #endregion

        #region Constructor

        public TIEUCHUANDao()
        {
            _dataObject = new TIEUCHUANSql();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Insert new TIEUCHUAN
        /// </summary>
        /// <param name="businessObject">TIEUCHUAN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(TIEUCHUAN businessObject)
        {
            return _dataObject.Insert(businessObject);
        }

        /// <summary>
        /// Update existing TIEUCHUAN
        /// </summary>
        /// <param name="businessObject">TIEUCHUAN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(TIEUCHUAN businessObject)
        {
            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get TIEUCHUAN by primary key.
        /// </summary>
        /// <param name="key">primary key</param>
        /// <returns>TIEUCHUAN</returns>
        public TIEUCHUAN GetByPrimaryKey(int key)
        {
            return _dataObject.SelectByPrimaryKey(key); 
        }

        /// <summary>
        /// get list of all TIEUCHUANs
        /// </summary>
        /// <returns>list</returns>
        public List<TIEUCHUAN> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of TIEUCHUAN by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<TIEUCHUAN> GetAllBy(TIEUCHUAN.TIEUCHUANFields fieldName, object value)
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
        /// delete TIEUCHUAN by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(TIEUCHUAN.TIEUCHUANFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
