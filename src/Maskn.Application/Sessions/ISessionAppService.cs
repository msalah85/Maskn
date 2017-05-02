using System.Threading.Tasks;
using Abp.Application.Services;
using Maskn.Sessions.Dto;

namespace Maskn.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
