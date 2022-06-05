using BookkeepingBook.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookkeepingBook.Views
{
    public partial class Summary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {

            String sql = "select sum(ina.money)as '总收入', sum(outs.money) as '总支出',sum(ina.money)-sum(outs.money) as '结余'  from (select * from Account where kind = 1)ina ,(select money from Account where kind =0)outs ";

            DataTable data =  DBClass.GetDataSet(sql);

            if (data.Rows.Count > 0)
            {
                this.sumarrydata.DataSource = data;
                this.sumarrydata.DataBind();

            }





        }
    }
}