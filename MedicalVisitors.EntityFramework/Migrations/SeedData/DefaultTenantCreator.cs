using System.Linq;
using MedicalVisitors.EntityFramework;
using MedicalVisitors.MultiTenancy;

namespace MedicalVisitors.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MedicalVisitorsDbContext _context;

        public DefaultTenantCreator(MedicalVisitorsDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
