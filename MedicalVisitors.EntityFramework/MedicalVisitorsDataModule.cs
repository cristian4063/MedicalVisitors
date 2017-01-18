using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using MedicalVisitors.EntityFramework;

namespace MedicalVisitors
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(MedicalVisitorsCoreModule))]
    public class MedicalVisitorsDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MedicalVisitorsDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
