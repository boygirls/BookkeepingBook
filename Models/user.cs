﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookkeepingBook.Models
{
    public class user
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int status { get; set; }
        public string email { get; set; }

    }
}