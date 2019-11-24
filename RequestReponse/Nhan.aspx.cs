using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace RequestReponse
{
    public partial class Nhan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["txt"] !=null)
            {
                string nhanURL = Request.QueryString["txt"].ToString();
                string result = HttpUtility.UrlDecode(nhanURL);
                lblNhan.Text = result;
            }
        }
    }
}