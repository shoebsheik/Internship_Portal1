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
    public partial class student : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Session["user"] = dr["uerid"].ToString();
                txtsession.Text = "2023-24";
                txtbranch.Text = (string)Session["branch"];
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string b = "select *from studenttb where studentid = @studentid1";
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
                dr.Close();

                string a = "insert into studenttb (studentid , name , branch, section , mobile ,session ,  password )Values(@studentid1 , @name1 , @branch1, @section1 , @mobile1 ,@session1 ,  @password1)";
                cm = new SqlCommand(a, cn);


                cm.Parameters.AddWithValue("studentid1", txtid.Text);
                cm.Parameters.AddWithValue("name1", txtname.Text);
                cm.Parameters.AddWithValue("branch1", txtbranch.Text);
                cm.Parameters.AddWithValue("section1", ddsection.Text);
                cm.Parameters.AddWithValue("mobile1", txtmob.Text);
                cm.Parameters.AddWithValue("session1", txtsession.Text);
                cm.Parameters.AddWithValue("password1", txtpass.Text);

                cm.ExecuteNonQuery();

                string c = "insert into logintb(uerid , password , role)Values(@userid1,@password1,@role1)";
                cm = new SqlCommand(c, cn);

                cm.Parameters.AddWithValue("userid1", txtid.Text);
                cm.Parameters.AddWithValue("password1", txtpass.Text);
                cm.Parameters.AddWithValue("role1", "student");
                cm.ExecuteNonQuery();

                txtid.Text = "";
                txtname.Text = "";
                txtbranch.Text = "";
                ddsection.SelectedIndex = 0;
                txtmob.Text = "";
                //txtsession.Text = "";
                txtpass.Text = "";

                Response.Write("Record Successfully inserted");
            }
        } 

        protected void Button2_Click(object sender, EventArgs e)
        {
            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string a = "Select *From studenttb ";
            cm = new SqlCommand(a, cn);
            dr = cm.ExecuteReader();

            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            Label llid = (Label)r1.FindControl("Label1");
            TextBox name = (TextBox)r1.FindControl("TextBox6");
            TextBox branch = (TextBox)r1.FindControl("TextBox7");
            TextBox section = (TextBox)r1.FindControl("TextBox8");
            TextBox mobile = (TextBox)r1.FindControl("TextBox9");
           
            string a1 = name.Text;
            string a2 = branch.Text;
            string a3 = section.Text;
            string a4 = mobile.Text;
            string a5 = llid.Text;
           

            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();

            string a = "UPDATE studenttb SET  name = @name1, branch = @branch1,section = @section1 ,mobile = @mobile1 WHERE studentid = @id1";
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
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            Label tb = (Label)r1.FindControl("Label1");

            String k = ConfigurationManager.AppSettings["mydb"];
            cn = new SqlConnection(k);
            cn.Open();
            
            string a = "Delete from studenttb where studentid=@id1 ";
            cm = new SqlCommand(a, cn);
            cm.Parameters.AddWithValue("id1", tb.Text);
            cm.ExecuteNonQuery();

            Response.Write("Record Delete");
        }

        
    }
}
