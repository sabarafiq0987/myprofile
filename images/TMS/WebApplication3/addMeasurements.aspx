<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addMeasurements.aspx.cs" Inherits="WebApplication3.addMeasurements" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 299px;
        }
    </style>
</head>
<body style="height: 401px;background-image:url('Images/m.jpg'); width: 710px; margin-left: 146px;">
    <form id="form1" runat="server">
        <div style="text-align:center; height: 527px; background-color: #808080; font-family: Arial;">
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table>
                <tr>
                    <td class="auto-style2"><label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Select Type&nbsp;&nbsp;&nbsp; </label></td>
                    <td><asp:DropDownList runat="server" ID="msr" AutoPostBack="True" Height="24px" OnSelectedIndexChanged="measurmentType_SelectedIndexChanged" Width="205px" BackColor="#FFCCFF" Font-Bold="True" ></asp:DropDownList></td>
                </tr>
                </table>
            <table>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                </tr>
            </table>
            <asp:GridView ID="GridView1" runat="server" Height="172px" Width="510px" AutoGenerateColumns="False" DataKeyNames="Name" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" style="margin-left: 96px">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:BoundField DataField="FileN" HeaderText="FileName" ReadOnly="True" />
                    <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" />
                    <asp:BoundField DataField="Value" HeaderText="Value">
                        
                    </asp:BoundField>
                    <asp:CommandField ShowEditButton="True" ButtonType="Button" />
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
            <br />
            <asp:Button  runat="server" ID="add" Text="save" OnClick="add_Click" BackColor="#FF66CC" BorderColor="#9900CC" BorderStyle="Solid" Font-Bold="True" ForeColor="Black" Width="43px"/>
            <asp:Button  runat="server" ID="close" Text="cancel" OnClick="close_Click" BackColor="#CCFFCC" BorderColor="#9900CC" BorderStyle="Solid" Font-Bold="True" ForeColor="Black" style="margin-left: 50px" Width="52px"/>
        </div>
    </form>
</body>
</html>
