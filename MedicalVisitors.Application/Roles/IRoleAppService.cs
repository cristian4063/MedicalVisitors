using System.Threading.Tasks;
using Abp.Application.Services;
using MedicalVisitors.Roles.Dto;

namespace MedicalVisitors.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
