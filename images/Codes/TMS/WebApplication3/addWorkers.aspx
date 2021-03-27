<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addWorkers.aspx.cs" Inherits="WebApplication3.addWorkers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            height: 26px;
            width: 757px;
        }
        .auto-style3 {
            width: 757px;
        }
        .auto-style4 {
            height: 30px;
        }
        .auto-style5 {
            width: 757px;
            height: 30px;
        }
      
    </style>
</head>
<body style="background-image: url('Images/worker.jpg')">
   
        <form id="form1" runat="server">
            <div>
                <br />
                <br />
            <table style="font-family: Arial; width: 708px; height: 397px; margin-left: 161px; margin-top: 88px; color: #FFFFFF;">
              
                <tr>
                    <td class="auto-style1" style="background-color: #00CC99; background-image: url('Images/table.jpg');">Full Name : </td>
                    <td class="auto-style2" style="background-color: #00CC99; background-image: url('Images/table.jpg');"><asp:TextBox runat="server" ID="name" Width="527px" Height="33px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="background-color: #00CC99; background-image: url('Images/table.jpg');">CNIC : </td>
                    <td class="auto-style2" style="background-color: #00CC99; background-image: url('Images/table.jpg');"><asp:TextBox runat="server" ID="CNIC"  Width="527px" Height="27px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="background-color: #00CC99; background-image: url('Images/table.jpg');">Address : </td>
                    <td class="auto-style2" style="background-color: #00CC99; background-image: url('Images/table.jpg');"><asp:TextBox runat="server" ID="address" Width="526px" Height="32px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="background-color: #00CC99; background-image: url('Images/table.jpg');">Mobile No : </td>
                    <td class="auto-style3" style="background-color: #00CC99; background-image: url('Images/table.jpg');"><asp:TextBox runat="server" ID="mobileNo" Width="526px" Height="30px"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td style="background-color: #00CC99; background-image: url('Images/table.jpg');">Emergency Contact : </td>
                    <td class="auto-style3" style="background-color: #00CC99; background-image: url('Images/table.jpg');"><asp:TextBox runat="server" ID="emg"  Height="37px" Width="528px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="background-color: #00CC99; background-image: url('Images/table.jpg');">Date of Joining : </td>
                    <td class="auto-style3" style="background-color: #00CC99; background-image: url('Images/table.jpg');"><asp:TextBox runat="server" TextMode="Date" ID="date" Height="44px" Width="260px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="background-color: #00CC99; background-image: url('Images/table.jpg');">&nbsp; Is Active:</td>
                    <td class="auto-style3" style="background-color: #00CC99; background-image: url('Images/table.jpg');"><asp:CheckBox runat="server" ID="IsActive"></asp:CheckBox></td>
                </tr>
                <tr>
                    <td style="background-color: #00CC99; background-image: url('Images/table.jpg');" class="auto-style4"></td>
                    <td class="auto-style5" style="background-color: #00CC99; background-image: url('Images/table.jpg');"><asp:Button runat="server" ID="add" Text="Add" OnClick="Add_Click" style="margin-left: 147px" Width="55px" BackColor="#CCFF66" Font-Bold="True" BorderStyle="Double" />
                        <asp:Button runat="server" ID="Search" Text="Search" OnClick="Search_Click" BackColor="#FF99FF" Font-Bold="True" BorderStyle="Solid" />
                        <asp:Button runat="server" ID="Close" Text="Close" OnClick="Close_Click" BackColor="#0066FF" Font-Bold="True" BorderStyle="Solid" style="height: 26px" />
                        <asp:Button runat="server" ID="delete" Text="Delete" OnClick="delete_Click" BackColor="#FF9900" Font-Bold="True" BorderStyle="Solid" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
       
</body>
</html>
