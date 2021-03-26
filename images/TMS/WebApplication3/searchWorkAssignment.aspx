<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchWorkAssignment.aspx.cs" Inherits="WebApplication3.searchWorkAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 1097px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #660066; height: 655px;">
      <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" Height="431px" Width="366px" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="Name" style="margin-left: 112px">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="WorkerName" ReadOnly="True" />
                <asp:BoundField DataField="Task" HeaderText="Task" />
                <asp:BoundField DataField="Comp" HeaderText="Complete" />
                <asp:BoundField DataField="pend" HeaderText="Pending" />
                <asp:BoundField DataField="total" HeaderText="Total Over Due" />
                <asp:BoundField DataField="C" HeaderText="CustomerName" />
                <asp:BoundField DataField="P" HeaderText="Price" />
                <asp:BoundField DataField="Isdue" HeaderText="IsDue" />
                <asp:BoundField DataField="R" HeaderText="Remarks" />
                <asp:BoundField DataField="IsCompleted" HeaderText="IsCompleted" />
                <asp:BoundField DataField="due" HeaderText="Due" />
                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
