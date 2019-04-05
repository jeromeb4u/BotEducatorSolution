using System;
using System.Collections.Generic;

namespace BotEducatorDAL.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}
