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
    public partial class internshipstudent : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtid.Text = (string)Session["studentid1"];
                txtname.Text = (string)Session["name1"];
                txtbranch.Text = (string)Session["branch1"];
                txtsection.Text = (string)Session["section1"];
                Label1.Text = (string)Session["user"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string b = "select *from internshiptb where studentid = @studentid1";
            cm = new SqlCommand(b, cn);
            cm.Parameters.AddWithValue("@studentid1", txtid.Text);
            dr = cm.ExecuteReader();

            if (dr.Read())
            {

                Response.Write(" Duplicate ID not allow");
                dr.Close();
            }
            else
            {
                //Session["department"] = dr["department"].ToString();
                dr.Close();

                string a = "insert into internshiptb (studentid , name , branch , section , company , city , type , status)Values(@studentid1 , @name1 , @branch1 , @section1 , @company1 , @city1 , @type1 , @status1)";
                cm = new SqlCommand(a, cn);


                cm.Parameters.AddWithValue("studentid1", txtid.Text);
                cm.Parameters.AddWithValue("name1", txtname.Text);
                cm.Parameters.AddWithValue("branch1", txtbranch.Text);
                cm.Parameters.AddWithValue("section1", txtsection.Text);
                cm.Parameters.AddWithValue("company1", txtcompany.Text);
                cm.Parameters.AddWithValue("city1", txtcity.Text);
                cm.Parameters.AddWithValue("type1", DropDownList1.Text);
                llstatus.Text = "Submit";
                cm.Parameters.AddWithValue("status1", llstatus.Text);
                llstatus.Text = "Submit";

                cm.ExecuteNonQuery();               

                Response.Write("Record Successfully inserted");
            }
        }
    }
}


