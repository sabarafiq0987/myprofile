<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchWorker.aspx.cs" Inherits="WebApplication3.searchWorker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url('Images/corona.jpg'); width: 948px; margin-left: 83px;" >
   <form id="form1" runat="server" style="color: #000000; font-family: Arial; background-color: #990000;">
   <br />
        <asp:GridView ID="GridView1" runat="server" Height="73px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-left: 126px; margin-top: 99px;" Width="322px" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#CCCCCC" BorderWidth="1px" CellPadding="4" ForeColor="#003366" GridLines="Horizontal" SelectedIndex="1" BorderStyle="None">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" ForeColor="White" Font-Bold="True" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:Button ID="Button3" runat="server" Height="25px" OnClick="Button1_Click" style="margin-left: 290px; " Text="Delete" Width="57px" BackColor="#FFCCFF" BorderStyle="Groove" Font-Bold="True" BorderColor="Black" />
        <asp:Button ID="Button2" runat="server" Height="26px" OnClick="Button2_Click" style="margin-left: 119px; margin-top: 36px; margin-bottom: 0px" Text="Close" Width="61px" BackColor="#009999" BorderStyle="Groove" Font-Bold="True" BorderColor="Black" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
