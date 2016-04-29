using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DatabaseDAL.DataLayer;
using DatabaseDAL.Entities;

namespace DatabaseDAL.DAO
{
    public class KETQUADANHGIADao
    {

        #region Data Members

        private KETQUADANHGIASql _dataObject = null;

        #endregion

        #region Constructor

        public KETQUADANHGIADao()
        {
            _dataObject = new KETQUADANHGIASql();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Insert new KETQUADANHGIA
        /// </summary>
        /// <param name="businessObject">KETQUADANHGIA object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(KETQUADANHGIA businessObject)
        {
            return _dataObject.Insert(businessObject);
        }

        /// <summary>
        /// Update existing KETQUADANHGIA
        /// </summary>
        /// <param name="businessObject">KETQUADANHGIA object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(KETQUADANHGIA businessObject)
        {
            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get KETQUADANHGIA by primary key.
        /// </summary> 
        /// <param name="key">primary key</param>
        /// <returns>KETQUADANHGIA</returns>
        public KETQUADANHGIA GetByPrimaryKey(KETQUADANHGIAKeys key)
        {
            return _dataObject.SelectByPrimaryKey(key); 
        }
        public int SelectByMasv(string masvdanhgia, string masv)
        {
            var list = _dataObject.SelectByMasv(masvdanhgia, masv);
            if (list == null)
                return 0;
            if (list.Count > 0) return 1;
            return 0;
        }

        public List<KETQUADANHGIA> SelectByMasvMaGv(string masvdanhgia, string masv)
        {
            return _dataObject.SelectByMasv(masvdanhgia, masv);
        }

        public List<KETQUADANHGIA> GetAllKetQuaByMaSV(string _masvdanhgia)
        {
            return _dataObject.GetAllKetQuaByMaSV(_masvdanhgia); 
        }
        /// <summary>
        /// get list of all KETQUADANHGIAs
        /// </summary>
        /// <returns>list</returns>
        public List<KETQUADANHGIA> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of KETQUADANHGIA by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<KETQUADANHGIA> GetAllBy(KETQUADANHGIA.KETQUADANHGIAFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        public List<KETQUADANHGIA> GetAllKetQuaByMaSVDanhGia(string _masvdanhgia)
         {
             return _dataObject.GetAllKetQuaByMaSVDanhGia(_masvdanhgia);  
         }
        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="key">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(KETQUADANHGIAKeys key)
        {
            return _dataObject.Delete(key); 
        }

        /// <summary>
        /// delete KETQUADANHGIA by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(KETQUADANHGIA.KETQUADANHGIAFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
