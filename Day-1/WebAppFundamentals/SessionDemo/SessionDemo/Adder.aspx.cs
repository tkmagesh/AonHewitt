using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionDemo
{
    public partial class Adder : System.Web.UI.Page
    {
        private int result = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["result"] = 0;
            }
            result = (int) Session["result"];
        }

        protected void BtnAddClick(object sender, EventArgs e)
        {
            result += int.Parse(TxtNumber.Text);
            Session["result"] = result;
        }

        protected void BtnShowResultClick(object sender, EventArgs e)
        {
            this.LblResult.Text = result.ToString();
        }
    }
}