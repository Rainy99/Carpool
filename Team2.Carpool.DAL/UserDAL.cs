using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team2.Carpool.DAL
{
	public static class UserDAL
	{
		//注册
		public static bool  Register(string userName,string password)
		{
			DBHelper.DBHelper.connectionString = "Data Source=.;Initial Catalog=CarpoolDB;User ID=sa;Password=123456";
			string sql = String.Format("  insert into Customer(UserName,Password) values('" + userName + "','" + password + "');");
			var result = DBHelper.DBHelper.ExcuteSql(sql);
			return result;
		}

		//登录
		public static int Login(string userName,string password)
		{
			DBHelper.DBHelper.connectionString = "Data Source=.;Initial Catalog=CarpoolDB;User ID=sa;Password=123456";
			string sql = "select CId from Customer where UserName='" + userName + "'and Password='" + password + "';";
			int result = DBHelper.DBHelper.GetSingleBySql(sql);
			return result;
		}
	}
}
