using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain.Accounts.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace Emr.Domain.Accounts
{
    public class AccountService : IAccountService
    {

        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public AccountService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<Guid> RegistrateUser(UserRegInfo userInfo)
        {
            if (_context.Users.Any(x => userInfo.Login == x.Login))
                throw new Exception($"Пользователь с таким ником уже существует.\n{userInfo.Login}");
            var result = _mapper.Map<UserRegInfo, User>(userInfo);
            _context.Users.Add(result);
            await _context.SaveChangesAsync();
            return result.UserGuid;
        }

        /// <inheritdoc />
        public User Login(UserLoginInfo loginInfo)
        {
            var user = _context.Users.SingleOrDefault(x => x.Login == loginInfo.Login);
            if (user == null)
                return null;
            if (user.Password != loginInfo.Password)
                return null;
            return user;
        }

    }
}
