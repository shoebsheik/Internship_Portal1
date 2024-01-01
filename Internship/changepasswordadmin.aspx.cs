using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Internship
{
    public partial class changepasswordadmin : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(! IsPostBack)
            {
                txtid.Text = (string)Session["user"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string a = "select *from logintb where uerid = @user1 and Password = @password1";
            cm = new SqlCommand(a, cn);
            cm.Parameters.AddWithValue("@user1", txtid.Text);
            cm.Parameters.AddWithValue("@password1", txtoldpass.Text);
            dr = cm.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();


                string b = "UPDATE logintb SET password = @newPassword WHERE uerid = @userId1"; 
                cm = new SqlCommand(b, cn);
                cm.Parameters.AddWithValue("@newPassword", txtnewpass.Text);
                cm.Parameters.AddWithValue("@userId1", txtid.Text);
                int check = cm.ExecuteNonQuery();

                if (check > 0)
                {                
                    Response.Write("Password updated successfully.");
                }
                else
                {                   
                    Response.Write("Failed to update password.");
                }
            }
            else
            {               
                Response.Write("Invalid user ID or old password.");
            }

           // Response.Write("Record Updated");

        }
    }
}