using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Avenue_Fashion.Pages
{
    public partial class Sign_Up : System.Web.UI.Page
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-1NPG654;Initial Catalog=CRUD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected void Page_Load(object sender, EventArgs e)
        {
            errLabel.Text = "";
            scsLabel.Text = "";
            createErrLabel.Text = "";
            createScsLabel.Text = "";
        }

        protected void signInBtn_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            if (userNameBox.Text == "" || passwordBox.Text == "")
            {
                scsLabel.Text = "";
                createErrLabel.Text = "";
                createScsLabel.Text = "";
                errLabel.Text = "Please fill in all the details!";
            }
            else
            {
                var email = userNameBox.Text;
                var password = passwordBox.Text;
                errLabel.Text = "";
                createErrLabel.Text = "";
                createScsLabel.Text = "";
                if (AuthenticateAdmin(email, password))
                {
                    Session["email"] = email;
                    Response.Redirect("Admin.aspx");
                }
                else
                {
                    errLabel.Text = "Please enter valid information!";
                }
            }
        }

        private bool AuthenticateAdmin(string email, string password)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            var sql = "select * from Users where email = @email and Password = HashBytes('MD5', @Password)";
            var command = new SqlCommand(sql, sqlCon);
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;

            var da = new SqlDataAdapter(command);
            var dt = new DataTable();
            da.Fill(dt);
            return dt.Rows.Count > 0;
        }

        protected void createAccBtn_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            if (createUserNameBox.Text == "" || createPasswordBox.Text == "" || confirmPasswordBox.Text == "")
            {
                createScsLabel.Text = "";
                errLabel.Text = "";
                scsLabel.Text = "";
                createErrLabel.Text = "Please fill in all the details!";
            }
            else
            {
                if (createPasswordBox.Text != confirmPasswordBox.Text)
                {
                    createScsLabel.Text = "";
                    errLabel.Text = "";
                    scsLabel.Text = "";
                    createErrLabel.Text = "Password donot match!";
                }
                else
                {
                    createErrLabel.Text = "";
                    errLabel.Text = "";
                    scsLabel.Text = "";
                    SqlCommand sqlCmd = new SqlCommand("CRUDcreateOrUpdate", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@UserID", (HiddenUserID.Value == "" ? 0 : Convert.ToInt32(HiddenUserID.Value)));
                    sqlCmd.Parameters.AddWithValue("@Email", createUserNameBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", createPasswordBox.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                    string userID = HiddenUserID.Value;
                    Clear();
                    if (userID == "")
                    {
                        createScsLabel.Text = "Account created successfully";
                    }
                    else
                    {
                        createScsLabel.Text = "Account created successfully";
                    }
                }
            }
            
        }

        public void Clear()
        {
            HiddenUserID.Value = "";
            createUserNameBox.Text = createPasswordBox.Text = "";
            createScsLabel.Text = createErrLabel.Text = "";
        }
    }
}