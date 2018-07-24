using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Avenue_Fashion
{
    public partial class Admin : System.Web.UI.Page
    {

        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-1NPG654;Initial Catalog=CRUD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = string.Empty;
            try
            {
                email = Session["email"].ToString();

                if (!IsPostBack)
                {
                    btnDelete.Enabled = false;
                    FillGridView();
                }
            }
            catch
            {
                Response.Redirect("SignUp.aspx");
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            HiddenUserID.Value = "";
            txtEmail.Text = txtPassword.Text = "";
            lblErrorMessage.Text = lblSuccessMessage.Text = "";
            btnSave.Text = "SAVE";
            btnDelete.Enabled = false;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                lblErrorMessage.Text = "Please fill in all the details!";
            }
            else
            {
                SqlCommand sqlCmd = new SqlCommand("CRUDcreateOrUpdate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", (HiddenUserID.Value == "" ? 0 : Convert.ToInt32(HiddenUserID.Value)));
                sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                string userID = HiddenUserID.Value;
                Clear();
                if (userID == "")
                {
                    lblSuccessMessage.Text = "Saved Successfully!";
                }
                else
                {
                    lblSuccessMessage.Text = "Updated Successfully!";
                }
            }
            FillGridView();
        }

        void FillGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("usersViewAll", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            sqlCon.Close();
            gvUsers.DataSource = dt;
            gvUsers.DataBind();

        }

        protected void lnkView_OnClick(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("usersViewByID", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@userID", userID);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            sqlCon.Close();
            HiddenUserID.Value = userID.ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtPassword.Text = dt.Rows[0]["Password"].ToString();
            btnSave.Text = "UPDATE";
            btnDelete.Enabled = true;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd = new SqlCommand("usersDeleteByID", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@userID", Convert.ToInt32(HiddenUserID.Value));
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            Clear();
            FillGridView();
            lblSuccessMessage.Text = "Deleted Successfull!";

        }
    }
}