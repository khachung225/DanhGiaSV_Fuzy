using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseDAL.Entities
{
	public class TIEUCHUAN
	{

		#region InnerClass
		public enum TIEUCHUANFields
		{
			MATIECHUAN,
			TENTIEUCHUAN,
			P1,
			P2,
			P3
		}
		#endregion

		#region Constructors

		public TIEUCHUAN()
		{
		}

		public TIEUCHUAN(int mATIECHUAN, string tENTIEUCHUAN, double? p1, double? p2, double? p3)
		{
			_mATIECHUAN = mATIECHUAN;
			_tENTIEUCHUAN = tENTIEUCHUAN;
			_p1 = p1;
			_p2 = p2;
			_p3 = p3;
		}

		public TIEUCHUAN(string tENTIEUCHUAN, double? p1, double? p2, double? p3)
		{
			_tENTIEUCHUAN = tENTIEUCHUAN;
			_p1 = p1;
			_p2 = p2;
			_p3 = p3;
		}

		#endregion

		#region Data Members

		private int _mATIECHUAN;
		private string _tENTIEUCHUAN;
		private double? _p1;
		private double? _p2;
		private double? _p3;

		#endregion

		#region Properties

		public int  MATIECHUAN
		{
			 get { return _mATIECHUAN; }
			 set { _mATIECHUAN = value; }
		}

		public string  TENTIEUCHUAN
		{
			 get { return _tENTIEUCHUAN; }
			 set { _tENTIEUCHUAN = value; }
		}

		public double?  P1
		{
			 get { return _p1; }
			 set { _p1 = value; }
		}

		public double?  P2
		{
			 get { return _p2; }
			 set { _p2 = value; }
		}

		public double?  P3
		{
			 get { return _p3; }
			 set { _p3 = value; }
		}


		#endregion

	}
}
