using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Emr.Database.Models;
using Emr.Domain.Accounts.Models;

namespace Emr.Domain.Accounts
{
    public interface IAccountService
    {
        Task<Guid> RegistrateUser(UserRegInfo userInfo);

        User Login(UserLoginInfo loginInfo);
    }
}
