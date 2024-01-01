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
    public partial class certificate : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label4.Text = (string)Session["user"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FileUpload1.SaveAs(Server.MapPath("~") + "//image//" + FileUpload1.FileName);
            Label2.Text = FileUpload1.FileName;

            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string a = "update internshiptb set pic = @pic1 where studentid = @studentid1";
            cm = new SqlCommand(a, cn);
            cm.Parameters.AddWithValue("@pic1", Label2.Text);
            cm.Parameters.AddWithValue("@studentid1", Label4.Text);

            cm.ExecuteNonQuery();

            Response.Write("Record Submit");
        }
    }
}