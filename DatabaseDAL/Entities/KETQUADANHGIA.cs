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

		 
		public KETQUADANHGIA(string mASV, string mASVDANHGIA, int tC11, int tC12, int tC21, int tC22, int tC23, int tC32, int tC33, int tC41, int tC42, int tC43, int tC51, int tC52, int tC53)
		{
			MASV = mASV;
			MASVDANHGIA = mASVDANHGIA;
			Tc11 = tC11;
			Tc12 = tC12;
			Tc23 = tC23;
			Tc21 = tC21;
			Tc22 = tC22;
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
