using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace devShop
{
    public partial class Order : System.Web.UI.Page
    {
        private static log4net.ILog Log { get; set; } = log4net.LogManager.GetLogger(typeof(Order));
        public Order()
        {
            Page.Init += new System.EventHandler(Page_Init);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtain ProductID from QueryString

                int ProductID = Int32.Parse(Request.Params["prodID"]);

                int catID = Int32.Parse(Request.Params["catID"]);

                int totalPrice = Int32.Parse(Request.Params["totPrice"]);

                string prodDesc = Request.Params["productName"];

                Log.Debug("Page_Load: Processing order and sending confirmation email for Product ID "+ ProductID + "");

                

            // Obtain Product Details
            devShop.ProductsDB products = new devShop.ProductsDB();

            String catName = products.GetCategoryDetails(catID).CatName;

            products.insertOrderDetails(ProductID,prodDesc,catID,catName,1,totalPrice);

            
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("admin@devshop.com");
                mail.To.Add("customer@devshop.com");
                mail.Subject = "Thanks You For Your Purchase";
                mail.Body = "Thanks You For Purchasing "+prodDesc+"";

                SmtpClient smtpClient = new SmtpClient(); // This will pick up settings from Web.config
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                Log.Error("Error Occured During Order Processing::", ex);
            }
        }
        private void Page_Init(object sender, EventArgs e)
        {
            //
            // CODEGEN: This call is required by the ASP.NET Web Form Designer.
            //
           
        }
    }
}