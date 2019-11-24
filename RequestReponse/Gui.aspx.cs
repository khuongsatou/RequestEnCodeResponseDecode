using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RequestReponse
{
    public partial class Gui : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnGui_Click(object sender, EventArgs e)
        {
            //mã hóa
            Response.Redirect("Nhan.aspx?txt=" +Server.UrlEncode(txtNhap.Text));
        }
        
    }
}