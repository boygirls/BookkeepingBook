using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookkeepingBook.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void signinButton_Click(object sender, EventArgs e)
        {


            String code = Request.Cookies.Get("CheckCode").Value.Trim();
            
            
            Console.WriteLine(code);

            Response.Write("<script>alert(' " + code + " !')</script>");
            System.Diagnostics.Debug.Write("asdf");


        }
    }
}