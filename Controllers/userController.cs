using BookkeepingBook.App_Code;
using BookkeepingBook.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;


namespace BookkeepingBook.Controllers
{
    public class userController : ApiController
    {

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<controller>
        public ResultModel Post(userDto user)
        {

            ResultModel model = new ResultModel();

            // 获取check先判断验证码是否一致
            String checkCode = null;
            CookieHeaderValue cookie = Request.Headers.GetCookies("CheckCode").FirstOrDefault();

            if (cookie == null)
            {
                model.IsSuccess = false;
                model.errorMsg = "zz验证码为空";
                return model;
            }
            checkCode = cookie["CheckCode"].Value;

            if(user  == null)
            {
                model.IsSuccess = false;
                model.errorMsg = "用户名为空";
                return model;
            }

            System.Diagnostics.Debug.Write(checkCode);
            System.Diagnostics.Debug.Write(user.check);

            if (!checkCode.Equals(user.check)) {
                model.IsSuccess = false;
                model.errorMsg = "验证码不一致";
                model.Data = user.check;
                return model;
            }

            // 判断数据中是否有用户

            String sql = "select * from [user] where username = @username and password = @password";
            SqlParameter[] parameters = new SqlParameter[2];

            parameters.SetValue(new SqlParameter("@username", user.username), 0);
            parameters.SetValue(new SqlParameter("@password", user.password), 1);

            // 查询成功返回重定向到首页
            DataTable data = DBClass.GetDataSet(sql,parameters);
            
            if(data.Rows.Count > 0)
            {

                // 将用户信息存入cookie
                var resp = new HttpResponseMessage();

                var cookies = new CookieHeaderValue("user", user.username);
                cookie.Expires = DateTimeOffset.Now.AddDays(1);
                cookie.Domain = Request.RequestUri.Host;
                cookie.Path = "/";

                resp.Headers.AddCookies(new CookieHeaderValue[] { cookie });

                model.IsSuccess = true;
                return model;
            }
            else
            {
                // 查询失败显示错误信息
                model.IsSuccess = false;
                model.errorMsg = "账号或密码不正确";
                return model;
            }

            //System.Diagnostics.Debug.Write(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}