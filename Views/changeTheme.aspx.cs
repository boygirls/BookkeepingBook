using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Configuration;

namespace BookkeepingBook.Views
{
    public partial class changeTheme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void changeBtn_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(changeBtn.SelectedValue == null)
            {
                return;
            }

            string configPath = "~";              //表示根目录
            Configuration config = WebConfigurationManager.OpenWebConfiguration(configPath);
            PagesSection pages = (PagesSection)config.GetSection("system.web/pages");
            pages.Theme = changeBtn.SelectedValue;       //修改主题，我根据DropdownList回发修改主题。
            config.Save();
        }
    }
}