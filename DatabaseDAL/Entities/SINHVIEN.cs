using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseDAL.Entities
{
	public class SINHVIEN
	{

		#region InnerClass
		public enum SINHVIENFields
		{
			MASV,
			HOTEN
		}
		#endregion

		#region Constructors

		public SINHVIEN()
		{
		}

		public SINHVIEN(string mASV, string hOTEN)
		{
			_mASV = mASV;
			_hOTEN = hOTEN;
		}

		public SINHVIEN(string hOTEN)
		{
			_hOTEN = hOTEN;
		}

		#endregion

		#region Data Members

		private string _mASV;
		private string _hOTEN;

		#endregion

		#region Properties

		public string  MASV
		{
			 get { return _mASV; }
			 set { _mASV = value; }
		}

		public string  HOTEN
		{
			 get { return _hOTEN; }
			 set { _hOTEN = value; }
		}


		#endregion

	}
}
