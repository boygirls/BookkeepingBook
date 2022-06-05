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
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            deleteMessage.Text = "";

            Init();
        }

        private void Init()
        {
            String sql = "select Account.id,Account.typename as '类型',typetb.typename as '类别',beizhu,money as '备注',time as '时间' from [Account] left join typetb on Account.sImageId = typetb.id";

            DataTable data = DBClass.GetDataSet(sql);


            if (data.Rows.Count > 0)
            {

                this.deletedata.DataSource = data;

                this.deletedata.DataBind();


            }
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            String  num = this.deleteItem.Text.Trim();

            String sql = "delete from Account where id = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id",int.Parse(num)),
            };

            DBClass.ExcuteSql(sql, parameters);

            deleteMessage.Text = "删除成功";

            Init();
        }
    }
}