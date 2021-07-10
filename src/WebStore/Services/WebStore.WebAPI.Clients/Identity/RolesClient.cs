using Microsoft.AspNetCore.Identity;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WebStore.Domain.Entities.Identity;
using WebStore.Interfaces;
using WebStore.Interfaces.Services.Identity;
using WebStore.WebAPI.Clients.Base;

namespace WebStore.WebAPI.Clients.Identity
{
    public class RolesClient : BaseClient, IRolesClient
    {
        public RolesClient(HttpClient Client) : base (Client, WebAPIAddress.Identity.Roles) { }

        public Task<IdentityResult> CreateAsync(Role role, CancellationToken Cancel)
        {
            throw new System.NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(Role role, CancellationToken Cancel)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public Task<Role> FindByIdAsync(string roleId, CancellationToken Cancel)
        {
            throw new System.NotImplementedException();
        }

        public Task<Role> FindByNameAsync(string NormalizedName, CancellationToken Cancel)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetNormalizedRoleNameAsync(Role role, CancellationToken Cancel)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetRoleIdAsync(Role role, CancellationToken Cancel)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetRoleNameAsync(Role role, CancellationToken Cancel)
        {
            throw new System.NotImplementedException();
        }

        public Task SetNormalizedRoleNameAsync(Role role, string NormalizedName, CancellationToken Cancel)
        {
            throw new System.NotImplementedException();
        }

        public Task SetRoleNameAsync(Role role, string RoleName, CancellationToken Cancel)
        {
            throw new System.NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(Role role, CancellationToken Cancel)
        {
            throw new System.NotImplementedException();
        }
    }
}
