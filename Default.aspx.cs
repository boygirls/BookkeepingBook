using BookkeepingBook.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookkeepingBook
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Init();
           
        }

        private void Init()
        {

            String sql = "select Account.id,Account.typename as '类型',typetb.typename as '类别',beizhu,money as '备注',time as '时间' from [Account] left join typetb on Account.sImageId = typetb.id where user_id = 1";

            DataTable data = DBClass.GetDataSet(sql);

            this.AccountList.DataSource = data;
            this.AccountList.DataBind();


        }
    }
}