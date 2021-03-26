<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createUser.aspx.cs" Inherits="WebApplication3.createUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 26px;
            width: 202px;
        }
        .auto-style3 {
            width: 202px;
        }
        .auto-style6 {
            height: 26px;
            width: 14px;
        }
        .auto-style9 {
            width: 14px;
        }
        .auto-style10 {
            height: 32px;
            width: 14px;
        }
        .auto-style11 {
            width: 202px;
            height: 32px;
        }
        .auto-style12 {
            height: 19px;
            width: 14px;
        }
        .auto-style13 {
            height: 19px;
            width: 202px;
        }
        #form1 {
            width: 1061px;
        }
    </style>
</head>
<body style="background-image: url('Images/y.jpg')">
      <form id="form1" runat="server">
        <div style="background-image: url('Images/0_f0_xr8VpcvL0vfNs.jpeg'); height: 493px; width: auto; top: auto; right: auto; bottom: auto; left: auto; margin-top: 46px;">
            <table style="border: medium groove #800080; width: 540px; height: 231px; margin-left: 178px; font-family: Arial; background-image: none;" border="1">
                <tr>
                    <td class="auto-style6" style="background-color: #FFCC66">Full Name </td>
                    <td class="auto-style2" style="background-color: #FFCC66"><asp:TextBox runat="server" ID="textBox1" Width="195px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style6" style="background-color: #FFCC66">User Name </td>
                    <td class="auto-style2" style="background-color: #FFCC66"><asp:TextBox runat="server" ID="textBox2" Height="22px" Width="195px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style9" style="background-color: #FFCC66">Password </td>
                    <td class="auto-style3" style="background-color: #FFCC66"><asp:TextBox runat="server" ID="textBox3" Width="196px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style9" style="background-color: #FFCC66">Type </td>
                    <td class="auto-style3" style="background-color: #FFCC66"><asp:DropDownList runat="server" ID="combo1" Height="105px" Width="203px">
                        <asp:ListItem>Admin</asp:ListItem>
                        <asp:ListItem>Operator</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td class="auto-style12" style="background-color: #FFCC66"></td>
                    <td class="auto-style13" style="background-color: #FFCC66"><asp:CheckBox  ID="isActive" runat="server" Text="isActive"/></td>
                </tr>
                <tr>
                    <td class="auto-style10" style="background-color: #FFCC66"></td>
                    <td class="auto-style11" style="background-color: #FFCC66"> <asp:Button runat="server" ID="add" Text="Add" OnClick="add_Click1" BackColor="#CC0000" BorderColor="White" BorderStyle="Double" Font-Bold="True"  />
                        <asp:Button runat="server" ID="Search" Text="Search" OnClick="Search_Click1" BackColor="#99FF99" BorderColor="White" BorderStyle="Double" Font-Bold="True" Width="55px" />
                        <asp:Button runat="server" ID="Close" Text="Close"  style="width: 49px" OnClick="Close_Click" BackColor="#3399FF" BorderColor="White" BorderStyle="Double" Font-Bold="True" />
                        <asp:Button runat="server" ID="delete" Text="Delete" OnClick="delete_Click1" BackColor="#660066" BorderColor="White" BorderStyle="Double" Font-Bold="True" Width="49px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
