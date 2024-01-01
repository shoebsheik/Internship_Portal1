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
    public partial class incharge : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtbranch.Text = (string)Session["branch"];
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string b = "select *from inchargetb where inchargeid = @inchargeid1";
            cm = new SqlCommand(b, cn);
            cm.Parameters.AddWithValue("@inchargeid1", txtid.Text);
            dr = cm.ExecuteReader();

            if (dr.Read())
            {

                Response.Write(" Duplicate ID not allow");
                dr.Close();
            }

            else
            {
                dr.Close();

                string a = "insert into inchargetb (inchargeid , name , branch , mobile , section ,password )Values(@inchargeid1 , @name1 , @branch1 , @mobile1 , @section1 , @password1)";
                cm = new SqlCommand(a, cn);


                cm.Parameters.AddWithValue("inchargeid1", txtid.Text);
                cm.Parameters.AddWithValue("name1", txtname.Text);
                cm.Parameters.AddWithValue("branch1", txtbranch.Text);
                cm.Parameters.AddWithValue("mobile1", txtmobile.Text);
                cm.Parameters.AddWithValue("section1", ddsection.Text);
                cm.Parameters.AddWithValue("password1", txtpassword.Text);
               
                cm.ExecuteNonQuery();

                txtid.Text = "";
                txtname.Text = "";
                txtbranch.Text = "";
                ddsection.SelectedIndex = 0;
                txtmobile.Text = "";
                txtpassword.Text = "";

                Response.Write("<script language = 'JavaScript'>alert('Record Save Sucessfully')</script>");
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Edit 
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            Label llid = (Label)r1.FindControl("Label1");
            TextBox name = (TextBox)r1.FindControl("TextBox5");
            TextBox branch = (TextBox)r1.FindControl("TextBox6");
            DropDownList section = (DropDownList)r1.FindControl("DropDownList1");
            TextBox mobile = (TextBox)r1.FindControl("TextBox7");

            string a1 = name.Text;
            string a2 = branch.Text;      
            string a4 = mobile.Text;
            string a3 = section.Text;
            string a5 = llid.Text;


            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string a = "UPDATE inchargetb SET  name = @name1, branch = @branch1,section = @section1 ,mobile = @mobile1 WHERE inchargeid = @id1";
            cm = new SqlCommand(a, cn);

            cm.Parameters.AddWithValue("@id1", a5);
            cm.Parameters.AddWithValue("@name1", a1);
            cm.Parameters.AddWithValue("@branch1", a2);
            cm.Parameters.AddWithValue("@section1", a3);
            cm.Parameters.AddWithValue("@mobile1", a4);

            cm.ExecuteNonQuery();

            Response.Write("Update ");

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // Delete 

            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            Label tb = (Label)r1.FindControl("Label1");

            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string a = "Delete from inchargetb where inchargeid=@id1 ";
            cm = new SqlCommand(a, cn);
            cm.Parameters.AddWithValue("id1", tb.Text);
            cm.ExecuteNonQuery();

            Response.Write("Record Delete");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string a = "Select *From inchargetb ";
            cm = new SqlCommand(a, cn);
            dr = cm.ExecuteReader();

            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
        }
    }
}