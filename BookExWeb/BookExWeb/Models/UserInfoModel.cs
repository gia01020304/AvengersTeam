using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookExWeb.Models
{
    public class UserInfoModel
    {
        public long ID { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
    }
}