using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookkeepingBook.Models
{
    public class Account
    {
        public int id { get; set; }
        public string typename { get; set; }
        public int sImageId { get; set; }
        public string beizhu { get; set; }
        public float money { get; set; }
        public string time { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public int kind { get; set; }
        public int user_id { get; set; }
    }
}