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
    public partial class dashboardadmin : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hodCount();
                studentCse();
                studentIT();
                studentCivil();
                intetnship();
            }
        }

        protected void hodCount()
        {
            string loc = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(loc);
            cn.Open();

            string a = "select count(uerid) from hodtb";
            cm = new SqlCommand(a, cn);
            int count = (int)cm.ExecuteScalar();
            Label2.Text = count.ToString();
        }

        protected void studentCse()
        {
            string loc = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(loc);
            cn.Open();

            string a = "select count(studentid) from studenttb where branch=@branch1";
            cm = new SqlCommand(a, cn);
            string bh = "CSE";
            cm.Parameters.AddWithValue("branch1", bh.ToString());
            int count = (int)cm.ExecuteScalar();
            Label3.Text = count.ToString();
        }
        protected void studentIT()
        {
            string loc = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(loc);
            cn.Open();

            string a = "select count(studentid) from studenttb where branch=@branch1";
            cm = new SqlCommand(a, cn);
            string bh = "IT";
            cm.Parameters.AddWithValue("branch1", bh.ToString());
            int count = (int)cm.ExecuteScalar();
            Label4.Text = count.ToString();

        }
        protected void studentCivil()
        {
            string loc = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(loc);
            cn.Open();
            string a = "select count(studentid) from studenttb where branch=@branch1";
            cm = new SqlCommand(a, cn);
            string bh = "CIVIL";
            cm.Parameters.AddWithValue("branch1", bh.ToString());
            int count = (int)cm.ExecuteScalar();
            Label5.Text = count.ToString();
        }
        protected void intetnship()
        {
            string loc = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(loc);
            cn.Open();

            string a = "select count(studentid) from internshiptb ";
            cm = new SqlCommand(a, cn);
            int count = (int)cm.ExecuteScalar();
            Label6.Text = count.ToString();
        }
    }
}