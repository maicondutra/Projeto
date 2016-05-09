using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProStoqWeb
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            //string clientIP = Request.UserHostAddress;
            //DateTime loginDate = DateTime.Now;

            //string userAgent = Request.Browser.Browser + "-" + Request.Browser.Version;
            //try
            //{
            //   UserDetails objUser = UserManagement.getUserDetails(userName);

            //    if (objUser == null)
            //    {
            //        ShowAlert("User does not have right to use application");
            //        return;
            //    }

            //    if (!objUser.IsActive)
            //    {
            //        ShowAlert("This user is currently deactivated. Please contact system administrator");
            //        return;
            //    }

            //    if (password.Trim() == objUser.UserPassword)
            //    {
            //        UserManagement.InsertUserLogin(objUser.UserId, loginDate, clientIP, Session.SessionID);

            //        objUser.UserHost = clientIP;
            //        objUser.UserBrowser = userAgent;

            //        Session["UserDetails"] = objUser;

            //        FormsAuthentication.SetAuthCookie(txtUserName.Text, false);

            //        if (objUser.PreviligeId == 0)
            //            ShowAlert("No rights to login into application");
            //        else
            //            Response.Redirect("main.aspx", false);

            //    }
            //    else
            //    {
            //        ShowAlert("Please enter valid username or password");
            //    }
            //}
            //catch (Exception exp)
            //{
            //    ShowAlert("An application error occured during user login.");
            //}
        }

        public void ShowAlert(string alertMsg)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('" + alertMsg.Replace(",", "") + "');", true);

        }
    }
}