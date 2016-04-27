using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseDAL.Entities
{
	public class KETQUARENLUYEN
	{

		#region InnerClass
		public enum KETQUARENLUYENFields
		{
			MASV,
			HOTEN,
			KETQUA,
			XEPLOAI
		}
		#endregion

		#region Constructors

		public KETQUARENLUYEN()
		{
		}

		public KETQUARENLUYEN(string mASV, string hOTEN, string kETQUA, string xEPLOAI)
		{
			_mASV = mASV;
			_hOTEN = hOTEN;
			_kETQUA = kETQUA;
			_xEPLOAI = xEPLOAI;
		}

		public KETQUARENLUYEN(string hOTEN, string kETQUA, string xEPLOAI)
		{
			_hOTEN = hOTEN;
			_kETQUA = kETQUA;
			_xEPLOAI = xEPLOAI;
		}

		#endregion

		#region Data Members

		private string _mASV;
		private string _hOTEN;
		private string _kETQUA;
		private string _xEPLOAI;

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

		public string  KETQUA
		{
			 get { return _kETQUA; }
			 set { _kETQUA = value; }
		}

		public string  XEPLOAI
		{
			 get { return _xEPLOAI; }
			 set { _xEPLOAI = value; }
		}


		#endregion

	}
}
