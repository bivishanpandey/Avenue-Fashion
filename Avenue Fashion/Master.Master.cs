using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Avenue_Fashion
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                SessionLabel.Text = Session["email"].ToString();
                //Session.Clear();
            }
            else
            {
                Session.Clear();
                //SessionLabel.Text = Session["email"].ToString();
                //Response.Redirect("Default.aspx");
                //Response.Redirect("~/Sign Up.aspx");
            }
        }

        protected void AdminBtn_Click(object sender, EventArgs e)
        {
            string email = string.Empty;
            if (Session["email"] != null)
            {
                SessionLabel.Text = Session["email"].ToString();
                Response.Redirect("Admin.aspx");
            }
            else
            {
                Response.Redirect("SignUp.aspx");
            }
            /*try
            {
                email = Session["email"].ToString();

            }
            catch
            {
                Response.Redirect("~/Sign Up.aspx");
            }*/
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Default.aspx");
        }
    }
}