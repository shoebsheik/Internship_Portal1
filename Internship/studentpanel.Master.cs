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
    public partial class studentpanel : System.Web.UI.MasterPage
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            //String k = ConfigurationManager.AppSettings["mydb"];
            ///cn = new SqlConnection(k);
           // cn.Open();

            //string a = "Select *From internshiptb ";
            //cm = new SqlCommand(a, cn);
           // dr = cm.ExecuteReader();

           // GridView1.DataSource = dr;
           // GridView1.DataBind();
           // dr.Close();
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }
    }
}