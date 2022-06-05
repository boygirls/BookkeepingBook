using BookkeepingBook.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookkeepingBook.Views
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void serchBtn_Click(object sender, EventArgs e)
        {
            String sql = "select Account.id,Account.typename as '类型',typetb.typename as '类别',beizhu,money as '备注',time as '时间' from [Account] left join typetb on Account.sImageId = typetb.id  where year = @year and month = @month order by id desc";



            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@year",int.Parse( this.serchyear.Text.Trim())),
                new SqlParameter("@month",this.serchMonth.SelectedValue),
            };
            
            DataTable data = DBClass.GetDataSet(sql,parameters);


            if (data.Rows.Count > 0)
            {
                this.serchList.DataSource = data;
                this.serchList.DataBind();
                this.searchMessage.Text = "";
            }
            else
            {
                this.searchMessage.Text = "抱歉当前月份没有任何记录";
            }
        }
    }
}