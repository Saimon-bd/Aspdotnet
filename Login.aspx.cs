using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPanel1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        LoginManager34 aLoginManager = new LoginManager34();
        protected void btnLogin_Click(object sender, EventArgs e)
        {

            if (UserNamePassword())
            {
                
                Response.Redirect("~/HomeUI.aspx");
                
            }
            else
            {

                Response.Redirect("~/Login.aspx");
            
            }
           


        }



        private bool UserNamePassword()
        {
            bool ret = false;

            try
            {
                UserLogin aUserLogin = new UserLogin();
                aUserLogin = aLoginManager.LoginUser(userNameTextBox.Text, passwordTextBox.Text);

                if (aUserLogin.RowCount != 0)
                {
                    if (userNameTextBox.Text == aUserLogin.UserId)
                    {
                        ret = true;
                    }
                    else
                    {
                        ret = false;
                    }

                }
            }
            catch (Exception ex)
            {
                ret = false;
            }
            return ret;

        }






    }
}