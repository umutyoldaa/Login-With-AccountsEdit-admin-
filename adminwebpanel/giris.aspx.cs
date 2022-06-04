using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adminwebpanel
{
    public partial class giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-CTR7PJA1;Initial Catalog=adminpaneli;Integrated Security=True");
            connection.Open();
            SqlCommand commandgiris = new SqlCommand("select * from TABLOUSER where @p1=KULLANICI and @p2=SIFRE",connection);
            commandgiris.Parameters.AddWithValue("@p1", TextBox1.Text);
            commandgiris.Parameters.AddWithValue("@p2", TextBox2.Text);
            SqlDataReader dr = commandgiris.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("adminpaneli.aspx");

            }
            else
            {
                Response.Write("Wrong username or password! try again!!");
            }


        }
    }
}