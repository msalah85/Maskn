using System.Threading.Tasks;
using Abp.Application.Services;
using Maskn.Authorization.Accounts.Dto;

namespace Maskn.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
