<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dashBoardAdmin.aspx.cs" Inherits="WebApplication3.dashBoardAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        #form1 {
            height: 62px;
        }
    </style>
</head>
<body style="background-image:url('Images/tailor2.jpg')">
     <form id="form1" runat="server">
        <div class="topnav" id="myTopnav" style="font-family: Arial">
           <div class="dropdown">
         <asp:Button runat="server" CssClass="dropbtn" Text="Tasks" Height="45px" Width="111px" OnClick="Unnamed1_Click" /><i class="fa fa-caret-down"></i>
 <div class="dropdown-content">
      <a href="loginForm.aspx">Lougout</a>
      <a href="Exir1.aspx">Exit</a>
   </div>
          </div>
          <div class="dropdown">
         <asp:Button runat="server" CssClass="dropbtn" Text="Setup" Height="45px" Width="111px" />
           <i class="fa fa-caret-down"></i>
    <div class="dropdown-content">
      <a href="createUser.aspx">Add Users</a>
      <a href="addWorkers.aspx">Add Worker</a>
      <a href="addCustomer.aspx">Add Customer</a>
    </div>
  </div>
             <div class="dropdown">
  <asp:Button runat="server" CssClass="dropbtn" Text="Assign Work" Height="45px" Width="111px" />
     <i class="fa fa-caret-down"></i>
    <div class="dropdown-content">
      <a href="assignWork.aspx">Work To Worker</a>
    </div>
    </div>
 <div class="dropdown">
  <asp:Button runat="server" CssClass="dropbtn" Text="Help" Height="45px" Width="111px" />
     <i class="fa fa-caret-down"></i>
    <div class="dropdown-content">
      <a href="aboutUs.aspx">About Us</a>
    </div>
    </div>
    <div class="dropdown">
  <asp:Button runat="server" CssClass="dropbtn" Text="Reports" Height="45px" Width="111px" />
     <i class="fa fa-caret-down"></i>
    <div class="dropdown-content">
      <a href="#">Pending Work</a>
         <a href="#">Completed Work</a>
    </div>
    </div>
     </div>
         
         <br />
         <p>&nbsp;</p>
         <p>&nbsp;</p>
         <p>&nbsp;</p>
         <p>&nbsp;</p>
         <p>&nbsp;</p>
         <p>&nbsp;</p>
         <p style="background-color: #000000; color: #FFFFFF; width: 860px; height: 121px; margin-left: 19px; margin-top: 3px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <b style="font-family: Kalam; font-size: xx-large">WELCOME TO TAILOR  MANAGEMENT SYSTEM</b></p>
         </form>
</body>
</html>
