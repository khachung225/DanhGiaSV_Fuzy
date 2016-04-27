using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseDAL.Entities
{
	public class GIAOVIEN
	{

		#region InnerClass
		public enum GIAOVIENFields
		{
			MaGv,
			TenGiaoVien,
			Sex,
			Adress,
			UserLogin,
			Password
		}
		#endregion

		#region Constructors

		public GIAOVIEN()
		{
		}

        public GIAOVIEN(string maGv, string tenGiaoVien, int sex, string adress, string userLogin, string password)
		{
			_maGv = maGv;
			_tenGiaoVien = tenGiaoVien;
			_sex = sex;
			_adress = adress;
			_userLogin = userLogin;
			_password = password;
		}

		public GIAOVIEN(string tenGiaoVien, int sex, string adress, string userLogin, string password)
		{
			_tenGiaoVien = tenGiaoVien;
			_sex = sex;
			_adress = adress;
			_userLogin = userLogin;
			_password = password;
		}

		#endregion

		#region Data Members

        private string _maGv;
		private string _tenGiaoVien;
		private int _sex;
		private string _adress;
		private string _userLogin;
		private string _password;

		#endregion

		#region Properties

        public string MaGv
		{
			 get { return _maGv; }
			 set { _maGv = value; }
		}

		public string  TenGiaoVien
		{
			 get { return _tenGiaoVien; }
			 set { _tenGiaoVien = value; }
		}

		public int  Sex
		{
			 get { return _sex; }
			 set { _sex = value; }
		}

		public string  Adress
		{
			 get { return _adress; }
			 set { _adress = value; }
		}

		public string  UserLogin
		{
			 get { return _userLogin; }
			 set { _userLogin = value; }
		}

		public string  Password
		{
			 get { return _password; }
			 set { _password = value; }
		}


		#endregion

	}
}
