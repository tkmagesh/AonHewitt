using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionDemo
{
    public partial class Adder : System.Web.UI.Page
    {
        private int total;
        protected void Page_Load(object sender, EventArgs e)
        {
            total = (int) Session["total"];
        }

        protected void BtnAddClick(object sender, EventArgs e)
        {
            var number = int.Parse(TxtNumber.Text);
            total += number;
            Session["total"] = total;
             
        }

        protected void BtnShowResultClick(object sender, EventArgs e)
        {
            this.LblResult.Text = total.ToString();
        }

        protected void BtnResetSessionClick(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Adder.aspx");
            
        }
    }
}