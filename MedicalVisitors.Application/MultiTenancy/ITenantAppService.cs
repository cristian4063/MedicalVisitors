using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MedicalVisitors.MultiTenancy.Dto;

namespace MedicalVisitors.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
