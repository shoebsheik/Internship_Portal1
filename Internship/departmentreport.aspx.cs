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
    public partial class departmentreport : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                display();
            }
        }

        protected void display()
        {
            string branch = (string)Session["branch"];
            string loc = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(loc);
            cn.Open();

            string queryselect = "select  distinct section  from internshiptb";
            cm = new SqlCommand(queryselect, cn);
          //  cm.Parameters.AddWithValue("branch1", branch.ToString());
            dr = cm.ExecuteReader();

            DropDownList1.DataSource = dr;
            DropDownList1.DataTextField = "section";
            DropDownList1.DataBind();
            dr.Close();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loc = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(loc);
            cn.Open();

            string queryselect = "select *  from internshiptb where section=@section1";
            cm = new SqlCommand(queryselect, cn);
            cm.Parameters.AddWithValue("section1", DropDownList1.Text);
            dr = cm.ExecuteReader();

            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
        }
    }
}