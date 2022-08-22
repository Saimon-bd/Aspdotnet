<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUI.aspx.cs" Inherits="LoginPanel1.HomeUI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<style type="text/css">
        .buttonbg
        {
            color: #FF0000;
            border: 2px #006699 solid; /*cursor: hand;*/
        }
        #hrlnkPasswordForget
        {
            /*background-color:#002258;*/
            text-decoration: none;
            border: 2px solid saddlebrown;
            font-weight: bold;
            padding: 0px 5px 0 5px;
        }
        #hrlnkPasswordForget:hover
        {
            background-color: #658ECC;
            color: #ACF21F;
            text-decoration: underline;
        }
    </style>
    <title>Home</title>
</head>
<body>

    <form id="form1" runat="server">
    <div><asp:Button ID="btnLogout"  class="button green small" runat="server" 
                                        Text=" Logout " Font-Bold="True" OnClick="btnLogout_Click"
                                        Font-Names="Tahoma" Font-Size="13px" /></div>
    <div>
    Welcome
    </div>
    </form>
</body>
</html>
