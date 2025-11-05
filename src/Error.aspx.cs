using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace devShop
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string errorMessage = Request.Params["errorMessage"].ToString();
                errorLBL.ForeColor= System.Drawing.Color.Red;
                errorLBL.Text = Server.HtmlEncode("Error Message - "+errorMessage);
            }
        }
    }
}