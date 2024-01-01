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
    public partial class history : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = (string)Session["user"];
                display();
            }
        }
        protected void display()
        {
            string k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string a = "select * from internshiptb";
            cm = new SqlCommand(a, cn);
            dr = cm.ExecuteReader();


            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;
            Label lblid = (Label)r1.FindControl("Label1");

            string delquery = "delete from internshiptb where studentid= @id1";
            cm = new SqlCommand(delquery, cn);
            cm.Parameters.AddWithValue("id1", lblid.Text);
            cm.ExecuteNonQuery();
            Response.Write("<script language='JavaScript'>alert('Record Deleted');</script>");
        }
    }
}

