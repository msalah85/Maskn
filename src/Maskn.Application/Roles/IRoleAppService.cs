using System.Threading.Tasks;
using Abp.Application.Services;
using Maskn.Roles.Dto;

namespace Maskn.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
