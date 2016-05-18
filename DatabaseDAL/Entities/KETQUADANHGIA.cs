using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DatabaseDAL.Entities
{
    public class KETQUADANHGIA
    {

        #region InnerClass
        public enum KETQUADANHGIAFields
        {
            MASV,
            MASVDANHGIA,
            TC11,
            TC12,
            TC13,
            TC21,
            TC22,
            TC23,
            TC31,
            TC32,
            TC33,
            TC34,
            TC35,
            TC36,
            TC37,
            TC38,
            TC39,
            TC310,
            TC311,
            TC41,
            TC42,
            TC51,
            TC52,
            TC53
        }
        #endregion

        #region Constructors

        public KETQUADANHGIA()
        {
        }
        
        #endregion

        #region Data Members

        #endregion

        #region Properties
        [DisplayName("Mã GV")]
        public string MASV { get; set; }

        [DisplayName("Mã SV Nhận Sét")]
        public string MASVDANHGIA { get; set; }

        public int Tc11 { get; set; }
        public int Tc12 { get; set; }
        public int Tc13 { get; set; }

        public int Tc21 { get; set; }
        public int Tc22 { get; set; }
         public int Tc23 { get; set; }

        //[Browsable(false)]
        public int Tc31 { get; set; }
        public int Tc32 { get; set; }
        public int Tc33 { get; set; }
         public int Tc34 { get; set; }
        public int Tc35 { get; set; }
        public int Tc36 { get; set; }
        public int Tc37 { get; set; }
        public int Tc38 { get; set; }
        public int Tc39 { get; set; }
        public int Tc310 { get; set; }
        public int Tc311 { get; set; }

        public int Tc41 { get; set; }
        public int Tc42 { get; set; }
     
        public int Tc51 { get; set; }
        public int Tc52 { get; set; }
        public int Tc53 { get; set; }

        #endregion

    }
}
