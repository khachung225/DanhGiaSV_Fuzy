using System;
using System.Collections.Generic;
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
			TC31,
			TC32,
			TC33,
			TC41,
			TC42,
			TC43,
			TC51,
			TC52,
			TC53
		}
		#endregion

		#region Constructors

		public KETQUADANHGIA()
		{
		}

		 
		public KETQUADANHGIA(string mASV, string mASVDANHGIA, int tC11, int tC12, int tC13, int tC21, int tC22, int tC31, int tC32, int tC33, int tC41, int tC42, int tC43, int tC51, int tC52, int tC53)
		{
			MASV = mASV;
			MASVDANHGIA = mASVDANHGIA;
			Tc11 = tC11;
			Tc12 = tC12;
			Tc13 = tC13;
			Tc21 = tC21;
			Tc22 = tC22;
			Tc31 = tC31;
			Tc32 = tC32;
			Tc33 = tC33;
			Tc41 = tC41;
			Tc42 = tC42;
			Tc43 = tC43;
			Tc51 = tC51;
			Tc52 = tC52;
			Tc53 = tC53;
		}

		#endregion

		#region Data Members

	    #endregion

		#region Properties

	    public string MASV { get; set; }

	    public string MASVDANHGIA { get; set; }

	    public int Tc11 { get; set; }

        public int Tc12 { get; set; }

	    public int Tc13 { get; set; }

	    public int Tc21 { get; set; }

	    public int Tc22 { get; set; }

	    public int Tc31 { get; set; }

	    public int Tc32 { get; set; }

	    public int Tc33 { get; set; }

	    public int Tc41 { get; set; }

	    public int Tc42 { get; set; }

	    public int Tc43 { get; set; }

	    public int Tc51 { get; set; }

	    public int Tc52 { get; set; }

	    public int Tc53 { get; set; }

	    #endregion

	}
}
