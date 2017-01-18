using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MedicalVisitors.EntityFramework;

namespace MedicalVisitors.Migrator
{
    [DependsOn(typeof(MedicalVisitorsDataModule))]
    public class MedicalVisitorsMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MedicalVisitorsDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}