using System.Threading;
using System.Threading.Tasks;
using Emr.Database.Models;
using Microsoft.AspNetCore.Identity;

namespace Emr.Identity
{
    public class RoleStore : IRoleStore<Role>
    {
        /// <inheritdoc />
        public void Dispose()
        {
        }

        /// <inheritdoc />
        public async Task<IdentityResult> CreateAsync(Role role, CancellationToken cancellationToken)
        {
            return null;
        }

        /// <inheritdoc />
        public async Task<IdentityResult> UpdateAsync(Role role, CancellationToken cancellationToken)
        {
            return null;
        }

        /// <inheritdoc />
        public async Task<IdentityResult> DeleteAsync(Role role, CancellationToken cancellationToken)
        {
            return null;
        }

        /// <inheritdoc />
        public async Task<string> GetRoleIdAsync(Role role, CancellationToken cancellationToken)
        {
            return null;
        }

        /// <inheritdoc />
        public async Task<string> GetRoleNameAsync(Role role, CancellationToken cancellationToken)
        {
            return null;
        }

        /// <inheritdoc />
        public async Task SetRoleNameAsync(Role role, string roleName, CancellationToken cancellationToken)
        {
        }

        /// <inheritdoc />
        public async Task<string> GetNormalizedRoleNameAsync(Role role, CancellationToken cancellationToken)
        {
            return null;
        }

        /// <inheritdoc />
        public async Task SetNormalizedRoleNameAsync(Role role, string normalizedName, CancellationToken cancellationToken)
        {
        }

        /// <inheritdoc />
        public async Task<Role> FindByIdAsync(string roleId, CancellationToken cancellationToken)
        {
            return null;
        }

        /// <inheritdoc />
        public async Task<Role> FindByNameAsync(string normalizedRoleName, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
