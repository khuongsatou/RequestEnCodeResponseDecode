using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RequestReponse
{
    public partial class NhanPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["txt"] != null)
            {
                string nhanURL = Request.Form["txt"].ToString();
                lblNhan.Text = nhanURL;
            }
            else
            {
                lblNhan.Text = "Không có";
            }
        }
    }
}