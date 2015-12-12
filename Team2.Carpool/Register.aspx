<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Team2.Carpool.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<link href="Content/Register.css" rel="stylesheet" />
	<title></title>
</head>
<body>
	<div id="allbg">
		<form id="form1" runat="server">
			<div>
				<p id="top">
					<asp:Label ID="lblTopMessage" runat="server" Text="请您先登录或注册"></asp:Label>
				</p>
				<hr />
				<p id="ControlBtn">
					<asp:Button ID="btnLogin" class="Cbtn" runat="server" Text="注册" />
					<asp:Button ID="btnRegister" class="Cbtn" runat="server" Text="登录" />
				</p>
				<hr id="l2" />
				<p id="phone" class="main">
					<asp:Label ID="lblPhone" runat="server" Text="手&nbsp;机："></asp:Label>
					<asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
					<asp:Label ID="getCodeMessage" class="lblMS" runat="server" Text="获取验证码"></asp:Label>
					<asp:RequiredFieldValidator ID="RvPhone" runat="server" ControlToValidate="txtPhone" ErrorMessage="请输入用户名" ForeColor="Red"></asp:RequiredFieldValidator>
				</p>
				<p id="vCode" class="main">
					<asp:Label ID="lblVCode" runat="server" Text="验证码："></asp:Label>
					<asp:TextBox ID="txtVCode" runat="server"></asp:TextBox>
					<asp:Label ID="lblVCMessage" class="lblMS" runat="server" Text="验证码10分钟内有效"></asp:Label>
				</p>
				<p id="password" class="main">
					<asp:Label ID="lblPed" runat="server" Text="密&nbsp;码："></asp:Label>
					<asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
					<asp:Label ID="lblPwdMessage" class="lblMS" runat="server" Text="6-32位字符"></asp:Label>
					<asp:RequiredFieldValidator ID="RvPwd" runat="server" ControlToValidate="txtPwd" ErrorMessage="请输入密码" ForeColor="Red"></asp:RequiredFieldValidator>
				</p>
				<p id="btnRe">
					<asp:Button ID="Register" runat="server" Text="同意协议并注册" OnClick="Register_Click" />
					<a href="#">
						<asp:Label ID="lblProtocol" runat="server" Text="《拼车网注册协议》"></asp:Label>
					</a>
				</p>
			</div>
		</form>
	</div>
</body>
</html>
