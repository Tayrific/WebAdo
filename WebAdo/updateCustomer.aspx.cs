using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAdo
{
    public partial class updateCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<center><h1>Update Customers</h1></center><hr/>");
            Response.Write("<br/>");

        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}