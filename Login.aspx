<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginPanel1.Login" %>

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
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style=" text-align:center;">
    <input type="hidden" name="referer" value="home_client_login">
			<div class="login_form_display">
				<div class="login_row">
                <asp:Label ID="lblUserIdtext" runat="server" Text="User ID" Font-Size="12px"></asp:Label>
                <asp:TextBox ID="userNameTextBox" runat="server" Text="" ></asp:TextBox>
					
				</div>
			
				<div class="login_row">
                <asp:Label ID="lblPasswordtext" runat="server" Text="Password" Font-Size="12px"></asp:Label>
                <asp:TextBox ID="passwordTextBox" runat="server" onKeyDown="submitButton(event)" TextMode="Password" 
                             ></asp:TextBox>
					
				</div>
				<div class="clear"></div>
			</div>
	
	<section class="login_footer">
		<div class="textcenter">
        
        
<asp:Button ID="btnLogin"  class="button green small" runat="server" 
                                        Text=" Login " Font-Bold="True" OnClick="btnLogin_Click"
                                        Font-Names="Tahoma" Font-Size="13px" />
                                    

        </div>
		<div class="clear"></div>
    </div>
    </form>
</body>
</html>
