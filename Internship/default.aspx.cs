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
    public partial class _default : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(! IsPostBack)
            {

            }
        }

        

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string b = "select *from logintb where uerid = @user1 and Password = @password1";
            cm = new SqlCommand(b, cn);
            cm.Parameters.AddWithValue("@user1", txtid.Text);
            cm.Parameters.AddWithValue("@password1", txtpassword.Text);
            dr = cm.ExecuteReader();

            if (dr.Read())
            {
                Session["user"] = dr["uerid"].ToString();
               
                string role = dr["role"].ToString();
                if (role == "admin")
                {
                    Response.Redirect("dashboardadmin.aspx");
                }
                else if (role == "hod" || role == "HOD")
                {
                    dr.Close();
                    string a = "select department from hodtb where uerid = @uerid1";
                    cm = new SqlCommand(a, cn);
                    cm.Parameters.AddWithValue("uerid1", txtid.Text);
                    dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        Session["branch"] = dr["department"].ToString();
                    }
                    Response.Redirect("student.aspx");
                }

                else if (role == "student")
                {
                    dr.Close();
                    string a = "select  *from studenttb where studentid = @uerid1";
                    cm = new SqlCommand(a, cn);
                    cm.Parameters.AddWithValue("uerid1", txtid.Text);
                    dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        Session["studentid1"] = dr["studentid"].ToString();
                        Session["name1"] = dr["name"].ToString();
                        Session["branch1"] = dr["branch"].ToString();
                        Session["section1"] = dr["section"].ToString();
                    }
                    Response.Redirect("internshipstudent.aspx");
                }
                else
                {
                    Response.Write("Incorect ");
                }
                dr.Close();
            }
            else
            {
                Response.Write("Record Unmatch");
                dr.Close();
            }

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {

        }
    }
}