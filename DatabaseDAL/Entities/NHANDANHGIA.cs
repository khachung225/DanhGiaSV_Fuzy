using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseDAL.Entities
{
	public class NHANDANHGIA
	{

		#region InnerClass
		public enum NHANDANHGIAFields
		{
			MALOAI,
			TENLOAI,
			P1,
			P2,
			P3
		}
		#endregion

		#region Constructors

		public NHANDANHGIA()
		{
		}

		public NHANDANHGIA(byte mALOAI, string tENLOAI, double? p1, double? p2, double? p3)
		{
			_mALOAI = mALOAI;
			_tENLOAI = tENLOAI;
			_p1 = p1;
			_p2 = p2;
			_p3 = p3;
		}

		public NHANDANHGIA(string tENLOAI, double? p1, double? p2, double? p3)
		{
			_tENLOAI = tENLOAI;
			_p1 = p1;
			_p2 = p2;
			_p3 = p3;
		}

		#endregion

		#region Data Members

		private byte _mALOAI;
		private string _tENLOAI;
		private double? _p1;
		private double? _p2;
		private double? _p3;

		#endregion

		#region Properties

		public byte  MALOAI
		{
			 get { return _mALOAI; }
			 set { _mALOAI = value; }
		}

		public string  TENLOAI
		{
			 get { return _tENLOAI; }
			 set { _tENLOAI = value; }
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
