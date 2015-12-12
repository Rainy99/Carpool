using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Team2.Carpool.BLL;

namespace Team2.Carpool
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnLogin_Click(object sender, EventArgs e)
		{
			string username = this.txtPhone.Text;
			string password = this.txtPwd.Text;
			int result = UserBLL.Login(username,password);
			if(result>0)
			{
				Response.Write("<script>alert('登录成功！')</script>");
                Response.Redirect("Default.aspx");
			}
			else
			{
				Response.Write("<script>alert('登录失败！')</script>");
			}
		}

	}
}