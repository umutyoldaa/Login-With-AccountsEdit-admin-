using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adminwebpanel
{
    public partial class adminpaneli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            DataSet1TableAdapters.TABLOUSERTableAdapter dt = new DataSet1TableAdapters.TABLOUSERTableAdapter();
            Repeater1.DataSource = dt.adminlistesi();
            Repeater1.DataBind();
            

        }
    }
}