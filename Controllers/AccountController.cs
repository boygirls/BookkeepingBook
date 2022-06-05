using BookkeepingBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookkeepingBook.App_Code;

using System.Data.SqlClient;
using System.Data;

namespace BookkeepingBook.Controllers
{
    public class AccountController : ApiController
    {
        // GET api/<controller>
        public ResultModel GetAllAccount()
        {

            ResultModel model = new ResultModel();

            String sql = "select * from [Account]";

            DataTable data = DBClass.GetDataSet(sql);

            model.Data = data;
            model.ReturnCode = 200;
            model.IsSuccess = true;

            return model;
        }

        // GET api/<controller>/5
        public ResultModel Get(int id)
        {

            ResultModel model = new ResultModel();

            String sql = "select * from [Account] where user_id = @user_id";

            SqlParameter[] parameters = new SqlParameter[1];

            parameters.SetValue(new SqlParameter("@user_id", id), 0);

            DataTable data = DBClass.GetDataSet(sql,parameters);

            model.Data = data;
            model.ReturnCode = 200;
            model.IsSuccess = true;

            return model;
        }

        // POST api/<controller>
        public ResultModel Post([FromBody] string value)
        {

            return null;
        }

        // PUT api/<controller>/5
        // 插入数据
        public ResultModel Put(Account account)
        {
            ResultModel model = new ResultModel();

            String sql = "insert into [Account] (id,typename,sImageId,beizhu,money,time,year,month,day,kind,user_id)value(@id,@typename,@sImageId,@beizhu,@money,@time,@year,@month,@day,@kind,@user_id)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id",account.id),
                new SqlParameter("@typename",account.typename),
                new SqlParameter("@sImageId",account.sImageId),
                new SqlParameter("@beizhu",account.beizhu),
                new SqlParameter("@money",account.money),
                new SqlParameter("@time",account.time),
                new SqlParameter("@year",account.year),
                new SqlParameter("@month",account.month),
                new SqlParameter("@day",account.day),
                new SqlParameter("@kind",account.kind),
                new SqlParameter("@user_id",account.user_id),
            };

            DBClass.ExcuteSql(sql, parameters);

            model.ReturnCode = 200;
            model.IsSuccess = true;

            return model;
        }

        // DELETE api/<controller>/5
        public ResultModel Delete(int user_id)
        {

            ResultModel model = new ResultModel();

            String sql = "delete from [Account] where user_id = " + user_id;

            DBClass.ExcuteSql(sql);

            model.ReturnCode = 200;
            model.IsSuccess = true;

            return model;
        }
    }
}