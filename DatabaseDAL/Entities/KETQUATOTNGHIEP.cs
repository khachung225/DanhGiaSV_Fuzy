using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DatabaseDAL.Entities
{
	public class KETQUATOTNGHIEP
	{

		#region InnerClass
		public enum KETQUATOTNGHIEPFields
		{
			MASV,
			HOTEN,
			KETQUA,
			XEPLOAI
		}
		#endregion

		#region Constructors

		public KETQUATOTNGHIEP()
		{
		}

		public KETQUATOTNGHIEP(string mASV, string hOTEN, string kETQUA, string xEPLOAI)
		{
			_mASV = mASV;
			_hOTEN = hOTEN;
			_kETQUA = kETQUA;
			_xEPLOAI = xEPLOAI;
		}

		public KETQUATOTNGHIEP(string hOTEN, string kETQUA, string xEPLOAI)
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
        [DisplayName("Mã SV")]
		public string  MASV
		{
			 get { return _mASV; }
			 set { _mASV = value; }
		}
        [DisplayName("Họ Tên")]
		public string  HOTEN
		{
			 get { return _hOTEN; }
			 set { _hOTEN = value; }
		}
        [DisplayName("Kết Quả")]
		public string  KETQUA
		{
			 get { return _kETQUA; }
			 set { _kETQUA = value; }
		}
        [DisplayName("Xếp loại")]
		public string  XEPLOAI
		{
			 get { return _xEPLOAI; }
			 set { _xEPLOAI = value; }
		}


		#endregion

	}
}
