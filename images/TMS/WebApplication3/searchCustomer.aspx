<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchCustomer.aspx.cs" Inherits="WebApplication3.searchCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url('Images/back.jpg')">
   <form id="form1" runat="server" style="font-family: Arial; background-color: #006666; width: 841px;">
   <br />

        <asp:GridView ID="GridView1" runat="server" Height="243px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-left: 116px; margin-top: 95px;" Width="552px" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" SelectedIndex="1">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" ForeColor="#333333" Font-Bold="True" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:Button ID="Button3" runat="server" Height="25px" OnClick="Button1_Click" style="margin-left: 364px; " Text="Delete" Width="57px" BackColor="#FFCCFF" BorderStyle="Groove" Font-Bold="True" BorderColor="Black" />
        <asp:Button ID="Button2" runat="server" Height="26px" OnClick="Button2_Click" style="margin-left: 61px; margin-top: 36px; margin-bottom: 0px" Text="Close" Width="61px" BackColor="#CCFF99" BorderStyle="Groove" Font-Bold="True" BorderColor="Black" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
