using System;
using System.Collections.Generic;
using System.Text;

namespace Emr.Domain.Accounts.Models
{
    public class UserRegInfo
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }

        public DateTime BirthDay { get; set; }

        public UserRegInfo()
        {
            
        }
    }
}
