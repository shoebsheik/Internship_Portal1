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
    public partial class hodadmin : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string b = "select *from hodtb where uerid = @userid1";
            cm = new SqlCommand(b, cn);
            cm.Parameters.AddWithValue("@userid1", txtid.Text);
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

                string a = "insert into hodtb (uerid , name , email , mobile , password , department)Values(@userid1,@name1,@email1,@mobile1 , @password1 , @department1)";
                cm = new SqlCommand(a, cn);
              

                cm.Parameters.AddWithValue("userid1", txtid.Text);
                cm.Parameters.AddWithValue("name1", txtnohod.Text);
                cm.Parameters.AddWithValue("email1", txtemail.Text);
                cm.Parameters.AddWithValue("mobile1", txtmobile.Text);
                cm.Parameters.AddWithValue("password1", txtpassword.Text);
                cm.Parameters.AddWithValue("department1", dddept.Text);
               
                cm.ExecuteNonQuery();

                string c = "insert into logintb(uerid , password , role)Values(@userid1,@password1,@role1)";
                cm = new SqlCommand(c, cn);

                cm.Parameters.AddWithValue("userid1", txtid.Text);
                cm.Parameters.AddWithValue("password1", txtpassword.Text);
                cm.Parameters.AddWithValue("role1", "hod");
                cm.ExecuteNonQuery();

                txtid.Text = "";
                txtnohod.Text = "";
                txtemail.Text = "";
                txtmobile.Text = "";
                txtpassword.Text = "";
                dddept.SelectedIndex = 0; 

                Response.Write("Record Successfully inserted");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            TextBox idtxt = (TextBox)r1.FindControl("TextBox4");
            TextBox txtname = (TextBox)r1.FindControl("TextBox1");
            TextBox txtemail = (TextBox)r1.FindControl("TextBox2");
            TextBox txtpass = (TextBox)r1.FindControl("TextBox3");
            DropDownList dddept = (DropDownList)r1.FindControl("dddept");

           string hodid = idtxt.Text;
            string hodname = txtname.Text;
            string hodemail = txtemail.Text;
            string hodpass = txtpass.Text;
            string hoddept = dddept.Text;

            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string a = "UPDATE hodtb SET uerid = @userid1, name = @name1, email = @email1, password = @password1, department = @department1 WHERE uerid = @userid1";
            cm = new SqlCommand(a, cn);

            cm.Parameters.AddWithValue("@name1", hodname);
            cm.Parameters.AddWithValue("@email1", hodemail);
            cm.Parameters.AddWithValue("@password1", hodpass);
            cm.Parameters.AddWithValue("@department1", hoddept);
            cm.Parameters.AddWithValue("@userid1", hodid);

            cm.ExecuteNonQuery();

            Response.Write("Record Updated");
        }


        protected void Button4_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            TextBox tb = (TextBox)r1.FindControl("TextBox4");

            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string a = "Delete from hodtb where uerid=@userid1 ";
            cm = new SqlCommand(a, cn);
            cm.Parameters.AddWithValue("userid1",tb.Text);
            cm.ExecuteNonQuery();

            Response.Write("Record Delete");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string a = "select *from hodtb";
            cm = new SqlCommand(a, cn);

            dr = cm.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
        }
    }
}