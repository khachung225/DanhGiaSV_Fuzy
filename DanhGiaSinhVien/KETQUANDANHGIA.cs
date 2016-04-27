namespace NhanXetSinhVien
{
    public class KETQUANDANHGIA
    {
        private string _Masv;
        private string _Masvdanhgia;

        public string Masvdanhgia
        {
            get { return _Masvdanhgia; }
            set { _Masvdanhgia = value; }
        }

        public string Masv
        {
            get { return _Masv; }
            set { _Masv = value; }
        }
       

        public int Tc11
        {
            get { return _Tc11; }
            set { _Tc11 = value; }
        }
        public int Tc12
        {
            get { return _Tc12; }
            set { _Tc12 = value; }
        }
        public int Tc13
        {
            get { return _Tc13; }
            set { _Tc13 = value; }
        }
        public int Tc21
        {
            get { return _Tc21; }
            set { _Tc21 = value; }
        }
        public int Tc22
        {
            get { return _Tc22; }
            set { _Tc22 = value; }
        }
        public int Tc31
        {
            get { return _Tc31; }
            set { _Tc31 = value; }
        }
        public int Tc32
        {
            get { return _Tc32; }
            set { _Tc32 = value; }
        }
        public int Tc33
        {
            get { return _Tc33; }
            set { _Tc33 = value; }
        }
        public int Tc41
        {
            get { return _Tc41; }
            set { _Tc41 = value; }
        }
        public int Tc42
        {
            get { return _Tc42; }
            set { _Tc42 = value; }
        }
        public int Tc43
        {
            get { return _Tc43; }
            set { _Tc43 = value; }
        }
        public int Tc51
        {
            get { return _Tc51; }
            set { _Tc51 = value; }
        }
        public int Tc52
        {
            get { return _Tc52; }
            set { _Tc52 = value; }
        }
        public int Tc53
        {
            get { return _Tc53; }
            set { _Tc53 = value; }
        }
        public KETQUANDANHGIA()
		{
		}
        public KETQUANDANHGIA(string masv, string username,int tc11,int tc12,int tc13,int tc21,int tc22,int tc31,int tc32,int tc33,int tc41,int tc42,int tc43,int tc51,int tc52,int tc53)
		{
			_Masv=masv;
            _Masvdanhgia = username;

			_Tc11=tc11;
            _Tc12 = tc12;
            _Tc13 = tc13;

            _Tc21 = tc21;
            _Tc22 = tc22;

            _Tc31 = tc31;
            _Tc32 = tc32;
            _Tc33 = tc33;

            _Tc41 = tc41;
            _Tc42 = tc42;
            _Tc43 = tc43;

            _Tc51 = tc51;
            _Tc52 = tc52;
            _Tc53 = tc53;


		}
        private int _Tc11;
        private int _Tc12;
        private int _Tc13;
        private int _Tc21;
        private int _Tc22;
        private int _Tc31;
        private int _Tc32;
        private int _Tc33;
        private int _Tc41;
        private int _Tc42;
        private int _Tc43;
        private int _Tc51;
        private int _Tc52;
        private int _Tc53;

    }
}
