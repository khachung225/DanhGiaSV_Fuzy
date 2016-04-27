using System;

namespace NhanXetSinhVien
{
    public class Sinhvien
    {
        private String	_Masv;
		private String	_Tensv;
		public String Masv
		{
			get { return _Masv; }
			set { _Masv=value; }
		}
		public String Tensv
		{
			get { return _Tensv; }
			set { _Tensv=value; }
		}
		public Sinhvien()
		{
		}
		public Sinhvien(String masv, String tensv)
		{
			_Masv=masv;
			_Tensv=tensv;
		}
		public Sinhvien(Sinhvien sv)
		{
			_Masv=sv.Masv;
			_Tensv=sv.Tensv;
		}
    }
}
