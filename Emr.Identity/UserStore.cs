using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Emr.Database;
using Emr.Database.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Emr.Identity
{
    public class UserStore : IUserRoleStore<User>
    {
        private readonly DatabaseContext _context;

        public UserStore(DatabaseContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public void Dispose()
        {
        }

        /// <inheritdoc />
        public async Task<string> GetUserIdAsync(User user, CancellationToken cancellationToken)
        {
            return user.UserGuid.ToString();
        }

        /// <inheritdoc />
        public async Task<string> GetUserNameAsync(User user, CancellationToken cancellationToken)
        {
            return user.Login;
        }

        /// <inheritdoc />
        public async Task SetUserNameAsync(User user, string userName, CancellationToken cancellationToken)
        {
        }

        /// <inheritdoc />
        public async Task<string> GetNormalizedUserNameAsync(User user, CancellationToken cancellationToken)
        {
            return user.Login.ToUpper();
        }

        /// <inheritdoc />
        public async Task SetNormalizedUserNameAsync(User user, string normalizedName, CancellationToken cancellationToken)
        {
        }

        /// <inheritdoc />
        public async Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken)
        {
            return null;
        }

        /// <inheritdoc />
        public async Task<IdentityResult> UpdateAsync(User user, CancellationToken cancellationToken)
        {
            return null;
        }

        /// <inheritdoc />
        public async Task<IdentityResult> DeleteAsync(User user, CancellationToken cancellationToken)
        {
            return null;
        }

        /// <inheritdoc />
        public async Task<User> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            var result = await _context.Users.SingleAsync(x => x.UserGuid == Guid.Parse(userId), cancellationToken: cancellationToken);
            return result;
        }

        /// <inheritdoc />
        public async Task<User> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            var result = await _context.Users.SingleAsync(x => x.Login.ToUpper() == normalizedUserName.ToUpper(), cancellationToken: cancellationToken);
            return null;
        }

        /// <inheritdoc />
        public async Task AddToRoleAsync(User user, string roleName, CancellationToken cancellationToken)
        {
        }

        /// <inheritdoc />
        public async Task RemoveFromRoleAsync(User user, string roleName, CancellationToken cancellationToken)
        {
        }

        /// <inheritdoc />
        public async Task<IList<string>> GetRolesAsync(User user, CancellationToken cancellationToken)
        {
            var result = await _context.Users.Include(x=>x.Role).SingleAsync(x => x.UserGuid == user.UserGuid);

            return new List<string> {result.Role.Name};
        }

        /// <inheritdoc />
        public async Task<bool> IsInRoleAsync(User user, string roleName, CancellationToken cancellationToken)
        {
            var result = await _context.Users.SingleAsync(x => x.UserGuid == user.UserGuid);
            if (result.Role.Name == roleName)
                return true;
            return false;
        }

        /// <inheritdoc />
        public async Task<IList<User>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
        {
            return null;
        }

        /// <inheritdoc />
        public Task<DateTimeOffset?> GetLockoutEndDateAsync(User user, CancellationToken cancellationToken)
        {
            DateTimeOffset? result = null;
            return Task.FromResult(result);
        }

        /// <inheritdoc />
        public async Task SetLockoutEndDateAsync(User user, DateTimeOffset? lockoutEnd, CancellationToken cancellationToken)
        {
        }

        /// <inheritdoc />
        public async Task<int> IncrementAccessFailedCountAsync(User user, CancellationToken cancellationToken)
        {
            return 0;
        }

        /// <inheritdoc />
        public async Task ResetAccessFailedCountAsync(User user, CancellationToken cancellationToken)
        {
        }

        /// <inheritdoc />
        public async Task<int> GetAccessFailedCountAsync(User user, CancellationToken cancellationToken)
        {
            return 0;
        }

        /// <inheritdoc />
        public async Task<bool> GetLockoutEnabledAsync(User user, CancellationToken cancellationToken)
        {
            return false;
        }

        /// <inheritdoc />
        public async Task SetLockoutEnabledAsync(User user, bool enabled, CancellationToken cancellationToken)
        {
        }
    }
}
