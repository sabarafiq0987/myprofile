<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginForm.aspx.cs" Inherits="WebApplication3.loginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
.color
{

}
</style>
</head>
<body style="background-image: url('Images/l2.jpg')">
   <div class="color">
    <form id="form1" runat="server" style="background-color: #333399; color: #FFFFFF; height: 372px; font-family: Arial; font-size: large; width: 773px; margin-left: 125px; background-image: url('Images/unnamed.png');">
        

           <label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Login : </label>
                        
                        <asp:DropDownList runat="server" ID="ddUserName" Height="18px" OnSelectedIndexChanged="ddUserName_SelectedIndexChanged" Width="177px" style="margin-left: 32px; margin-top: 84px"></asp:DropDownList>
                    <br />
                        <label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password : </label>
                       <asp:TextBox runat="server" ID="u_pass" TextMode="Password" OnTextChanged="u_pass_TextChanged" style="margin-left: 0px" Width="166px"></asp:TextBox>
                    <br />
                        <asp:Button runat="server" ID="login" OnClick="login_Click" text="Login" BackColor="#FF9999" BorderColor="#660033" BorderStyle="Groove" Height="29px" style="margin-left: 606px; margin-top: 13px; margin-bottom: 37px" Width="83px" />
    </form>
  </div>
</body>
</html>
