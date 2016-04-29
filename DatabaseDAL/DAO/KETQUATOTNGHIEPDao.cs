using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DatabaseDAL.DataLayer;
using DatabaseDAL.Entities;

namespace DatabaseDAL.DAO
{
    public class KETQUATOTNGHIEPDao
    {

        #region Data Members

        private KETQUATOTNGHIEPSql _dataObject = null;

        #endregion

        #region Constructor

        public KETQUATOTNGHIEPDao()
        {
            _dataObject = new KETQUATOTNGHIEPSql();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Insert new KETQUARENLUYEN
        /// </summary>
        /// <param name="businessObject">KETQUARENLUYEN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(KETQUATOTNGHIEP businessObject)
        {
            return _dataObject.Insert(businessObject);
        }

        /// <summary>
        /// Update existing KETQUARENLUYEN
        /// </summary>
        /// <param name="businessObject">KETQUARENLUYEN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(KETQUATOTNGHIEP businessObject)
        {
            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get KETQUARENLUYEN by primary key.
        /// </summary>
        /// <param name="key">primary key</param>
        /// <returns>KETQUARENLUYEN</returns>
        public KETQUATOTNGHIEP GetByPrimaryKey(string key)
        {
            return _dataObject.SelectByPrimaryKey(key); 
        }

        /// <summary>
        /// get list of all KETQUARENLUYENs
        /// </summary>
        /// <returns>list</returns>
        public List<KETQUATOTNGHIEP> GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        
        /// <summary>
        /// get list of KETQUARENLUYEN by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<KETQUATOTNGHIEP> GetAllBy(KETQUATOTNGHIEP.KETQUATOTNGHIEPFields fieldName, object value)
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
        /// delete KETQUARENLUYEN by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(KETQUATOTNGHIEP.KETQUATOTNGHIEPFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
