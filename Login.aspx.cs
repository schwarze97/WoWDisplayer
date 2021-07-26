using Newtonsoft.Json;
using System;
using System.Text;
using System.Net;
using System.Web.UI;
using System.Collections.Generic;
using WoWDisplayer.Models;
using System.IO;
using System.Web;


namespace WoWDisplayer
{
    public partial class Login : System.Web.UI.Page
    {
        private static string Token;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TokenTextBox_TextChanged(object sender, EventArgs e)
        {
            Token = TokenTextBox.Text;
        }


        protected void ConfirmTokenButton_Click(object sender, EventArgs e)
        {
            if (Token != null)
            {
                try
                {
                    Session["Token"] = Token.ToString();
                    Response.Redirect("HomePage.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
                catch (Exception ex)
                {
                    Session["ErrorMessage"] = ex.ToString();
                    Response.Redirect("ErrorDisplay.aspx");
                }
            }
            else
            {
                string script = "alert('Please, enter your access token.');";
                System.Web.UI.ScriptManager.RegisterClientScriptBlock(ConfirmTokenButton, this.GetType(), "Test", script, true);
            }

        }

        protected void ClientIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}