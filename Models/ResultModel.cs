using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookkeepingBook.Models
{
    public class ResultModel
    {

        /// <summary>
        /// 状态码
        /// </summary>
        public int ReturnCode { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string errorMsg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }
    }
}