using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Team2.Carpool.DAL;

namespace Team2.Carpool.BLL
{
	public static class UserBLL
	{
		//注册
		public static bool Register(string userName, string password)
		{
			return UserDAL.Register(userName,password);
		}

		//登录
		public static int Login(string userName, string password)
		{
			return UserDAL.Login(userName,password);
		}
	}
}
