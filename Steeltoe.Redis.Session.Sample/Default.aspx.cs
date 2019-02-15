using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Steeltoe.Redis.Session.Sample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["foo"] = "bar";
            Label1.Text = Session["foo"].ToString();
        }
    }
}