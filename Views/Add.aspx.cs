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
    public partial class Add : System.Web.UI.Page
    {
        

        String sql0 = "select [typename] from [typetb] where kind = 0";
        String sql1 = "select [typename] from [typetb] where kind = 1";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) //防止返回默认值
            {
                Init(sql0);

            }
            

        }

        private void Init(String sql)
        {

            DataTable data = null;

            if (data != null) 
            {
                data.Rows.Clear();
            }


            data = DBClass.GetDataSet(sql);

            if (data.Rows.Count > 0)
            {
                this.Consumetype.ClearSelection();
                this.Consumetype.DataSource = data;
                this.Consumetype.DataTextField = "typename";
                this.Consumetype.DataValueField = "typename";
                this.Consumetype.DataBind();
            }
        }

        protected void choseType_SelectedIndexChanged(object sender, EventArgs e)
        {

            String type =  choseType.SelectedValue;

            if (type.Equals("收入")) 
            {

                Init(sql1);
            }
            else
            {
                Init(sql0);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            String type = this.choseType.SelectedValue;
            int kind;

            if (type.Equals("支出"))
            {
                kind = 0;
            }
            else
            {
                kind = 1;   
            }

            String sql = "insert into [Account] (typename,sImageId,beizhu,money,time,year,month,day,kind,user_id)values(@typename,@sImageId,@beizhu,@money,@time,@year,@month,@day,@kind,@user_id)";



            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@typename",this.choseType.SelectedValue),
                new SqlParameter("@sImageId",this.Consumetype.SelectedIndex),
                new SqlParameter("@beizhu",this.remarks.Text),
                new SqlParameter("@money", float.Parse( this.price.Text)),
                new SqlParameter("@time",DateTime.Now.ToLongDateString().ToString()),
                new SqlParameter("@year",DateTime.Now.Year.ToString()),
                new SqlParameter("@month",DateTime.Now.Month.ToString()),
                new SqlParameter("@day",DateTime.Now.DayOfYear.ToString()),
                new SqlParameter("@kind",kind),
                new SqlParameter("@user_id",1),
            };

            DBClass.ExcuteSql(sql, parameters);

            this.message.Text = "报存成功";

        }
    }
}