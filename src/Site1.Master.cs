using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace devShop
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            StringBuilder sb = new StringBuilder();
             sb.Append("<div class=\"navbar-nav\">");
            try
            {
                // Obtain list of menu categories and databind to list control
                devShop.ProductsDB products = new devShop.ProductsDB();
                DataTable reader = products.GetProductCategories();

                // Corrected loop to iterate through rows in the DataTable
                foreach (DataRow row in reader.Rows)
                {
                    sb.Append("<a class='nav-item nav-link' href='Productslist.aspx?CategoryID=" + row["categoryid"] + "'>" + row["categoryname"] + " </a>");
                }
            }
            catch (Exception ex)
            {
                sb.Append("<div class='alert alert-danger' role='alert'>");
                sb.Append("An error occurred while loading categories: " + ex.Message);
                sb.Append("</div>");
            }

            sb.Append("</div>");

            navbarSupportedContent.InnerHtml = sb.ToString();
        }
    }
}