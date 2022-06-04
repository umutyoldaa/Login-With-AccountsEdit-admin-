using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adminwebpanel
{
    public partial class ADMINGUNCELLE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"].ToString());
            DataSet1TableAdapters.TABLOUSERTableAdapter dy = new DataSet1TableAdapters.TABLOUSERTableAdapter();
            TextBox1.Text=x.ToString();
            if (Page.IsPostBack == false)
            {
                TextBox2.Text = dy.VeriGetir(Convert.ToInt32(TextBox1.Text))[0].KULLANICI;
                TextBox3.Text = dy.VeriGetir(Convert.ToInt32(TextBox1.Text))[0].SIFRE;
                TextBox4.Text = dy.VeriGetir(Convert.ToInt32(TextBox1.Text))[0].SIFRE;

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TABLOUSERTableAdapter dy = new DataSet1TableAdapters.TABLOUSERTableAdapter();
            dy.AdminGuncelle(TextBox2.Text, TextBox3.Text, Convert.ToInt32(TextBox1.Text));
            Response.Redirect("adminpaneli.aspx");
        }
    }
}