<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignWork.aspx.cs" Inherits="WebApplication3.assignWork" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            width: 160px;
        }
        .auto-style4 {
            height: 23px;
            width: 160px;
        }
    </style>
</head>
<body style="background-image:url('Images/decent.jpg');">
    <form id="form1" runat="server">
        <br />
        <br />
        <br />
        <div style="background-color: #808080; color: #000000; font-family: Arial; width: 1093px; background-image: url('Images/de2.jpg'); margin-left: 33px; height: 500px; margin-top: 23px;">
           &nbsp;&nbsp;
           <br />
            <br />
            <br />
             <table>
                <tr>
                    <td></td>
                    <td class="auto-style3" ></td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Select Customer 
                    </td>
                    <td class="auto-style3" >
                        <asp:DropDownList runat="server" AutoPostBack="True" ID="selectCustomer" Height="24px" Width="160px" OnSelectedIndexChanged="selectCustomer_SelectedIndexChanged" BackColor="#FFFFCC"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                        Measurements 
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server" Height="88px" OnTextChanged="TextBox1_TextChanged" Width="150px" BackColor="#00CCFF" Font-Bold="True"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <table style="margin-left:350px; margin-top:-150px;">
                 <tr>
                     <td></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        Select Worker 
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="selectWorker" Height="24px" Width="175px" BackColor="#FFFFCC" OnSelectedIndexChanged="selectWorker_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        Price for work
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox runat="server" ID="price" TextMode="Number" OnTextChanged="price_TextChanged" BackColor="#FFFFCC"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        Due Date  
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="dueDate" TextMode="Date" BackColor="#FFFFCC" OnTextChanged="dueDate_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        Remarks 
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="remarks" TextMode="MultiLine" OnTextChanged="remarks_TextChanged" BackColor="#FFFFCC" Height="85px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <table style="margin-left:700px;margin-top:-120px;">
                <tr>
                    <td><asp:Button  runat="server" ID="add" Text="Add" Width="69px" OnClick="add_Click" BackColor="#CCFFCC" BorderColor="Black" BorderStyle="Groove" Font-Bold="True"/></td>
                </tr>
                 <tr>
                    <td><asp:Button  runat="server" ID="search" Text="Search" Width="67px" OnClick="search_Click" BackColor="#FFFF66" BorderColor="Black" BorderStyle="Groove" Font-Bold="True"/></td>
                </tr>
                 <tr>
                    <td><asp:Button  runat="server" ID="markAsCompleted" Text="Mark As Complete" Width="142px" OnClick="markAsCompleted_Click" Height="32px" style="margin-left: 0px" BackColor="#66CCFF" BorderColor="Black" BorderStyle="Groove" Font-Bold="True"/></td>
                </tr>
                </table>
            <asp:Button ID="Button1" runat="server" BackColor="White" BorderColor="Red" BorderStyle="Groove" Font-Bold="True" OnClick="Button1_Click" style="margin-left: 705px" Text="Close" />
            <br /><br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Works Detail<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
          
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-left: 174px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Task" HeaderText="Task" />
                    <asp:BoundField DataField="Comp" HeaderText="Complete" />
                    <asp:BoundField DataField="pend" HeaderText="Pending" />
                    <asp:BoundField DataField="total" HeaderText="total over due date" />
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            <br />
            <br />
        </div>
        <br />
        <br />
        <br />
    </form>
</body>
</html>
