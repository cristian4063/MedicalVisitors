using MedicalVisitors.EntityFramework;
using EntityFramework.DynamicFilters;

namespace MedicalVisitors.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MedicalVisitorsDbContext _context;

        public InitialHostDbBuilder(MedicalVisitorsDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
