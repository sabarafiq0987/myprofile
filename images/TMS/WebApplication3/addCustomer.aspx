<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addCustomer.aspx.cs" Inherits="WebApplication3.addCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body style="width: 967px; height: 1179px; margin-left: 99px;background-image: url('Images/table.jpg')">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div style="background-color:wheat; width: 845px; margin-left: 74px; height: 300px;">
        <br />
        <br />
        <br />
    <form id="form1" runat="server">
        <div  style="font-family: Arial;">
             <table style="margin-left: 106px">
                <tr>
                    <td class="auto-style1">Full Name : </td>
                    <td class="auto-style1"><asp:TextBox runat="server" ID="name" OnTextChanged="name_TextChanged"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>CNIC : </td>
                    <td><asp:TextBox runat="server" ID="CNIC" OnTextChanged="CNIC_TextChanged"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Address : </td>
                    <td><asp:TextBox runat="server" ID="address" OnTextChanged="address_TextChanged"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mobile No : </td>
                    <td><asp:TextBox runat="server" ID="mobileNo"  OnTextChanged="mobileNo_TextChanged"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Remarks : </td>
                    <td><asp:TextBox runat="server" ID="remarks" TextMode="MultiLine" OnTextChanged="remarks_TextChanged"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button runat="server" ID="Add" Text="Add" OnClick="Add_Click" BackColor="#FF6666" BorderStyle="Groove" BorderWidth="5px" Font-Bold="True" BorderColor="#660033" />
                        <asp:Button runat="server" ID="Search" Text="Search" OnClick="Search_Click" BackColor="#6699FF" BorderStyle="Groove" BorderWidth="5px" Font-Bold="True" BorderColor="#660033" />
                        <asp:Button runat="server" ID="Close" Text="Close" OnClick="Close_Click" BackColor="#00FFCC" BorderStyle="Groove" BorderWidth="5px" Font-Bold="True" BorderColor="#660033" />
                        <asp:Button runat="server" ID="Delete" Text="Delete" OnClick="Delete_Click" BackColor="White" BorderStyle="Groove" BorderWidth="5px" Font-Bold="True" BorderColor="#660033" />
                    </td>
                </tr>
            </table>
           <table style="margin-left:400px;margin-top:-170px;">
               <tr>
                   <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Add Measurments</td>
               </tr>
               <tr>
                   <td>
                       <asp:TextBox runat="server" ID="measurements" TextMode="MultiLine" Height="70px" OnTextChanged="measurments_TextChanged" style="margin-left: 205px"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       <asp:Button runat="server" ID="addMeasurements"  Text="Add" OnClick="addMeasurments_Click" BackColor="#FF5050" BorderStyle="Ridge" Font-Bold="True" ForeColor="Black" style="margin-left: 211px" Width="43px" BorderColor="#660066"/>
                       <asp:Button runat="server" ID="closeMeasurements"  Text="Clear" OnClick="closeMeasurments_Click" BackColor="#FFFF66" BorderStyle="Ridge" Font-Bold="True" ForeColor="#660033" style="margin-left: 18px" BorderColor="#990099"/>
                   </td>
               </tr>
           </table>
        </div>
    </form>
        </div>
</body>
</html>
