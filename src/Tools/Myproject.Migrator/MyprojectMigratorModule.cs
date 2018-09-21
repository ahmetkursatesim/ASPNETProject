using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Myproject.EntityFramework;

namespace Myproject.Migrator
{
    [DependsOn(typeof(MyprojectDataModule))]
    public class MyprojectMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MyprojectDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}