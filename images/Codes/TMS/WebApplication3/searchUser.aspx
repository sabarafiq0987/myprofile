<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchUser.aspx.cs" Inherits="WebApplication3.searchUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url('Images/tailor2.jpg')">
   <form id="form1" runat="server" style="font-family: Arial; background-color: #FFFF66; width: 814px;">
       <br />
        <asp:GridView ID="GridView1" runat="server" Height="243px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-left: 116px; margin-top: 95px;" Width="552px" AutoGenerateSelectButton="True" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" SelectedIndex="-1">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <asp:Button ID="Button3" runat="server" Height="25px" OnClick="Button1_Click" style="margin-left: 364px; " Text="Update" Width="57px" BackColor="#FFCCFF" BorderStyle="Groove" Font-Bold="True" BorderColor="Black" />
        <asp:Button ID="Button2" runat="server" Height="26px" OnClick="Button2_Click" style="margin-left: 61px; margin-top: 36px; margin-bottom: 0px" Text="Close" Width="61px" BackColor="#009999" BorderStyle="Groove" Font-Bold="True" BorderColor="Black" />
        <p>
            &nbsp;</p>
   
    </form>
</body>
</html>
