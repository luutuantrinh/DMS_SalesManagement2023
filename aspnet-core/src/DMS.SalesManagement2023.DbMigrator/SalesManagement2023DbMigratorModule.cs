using DMS.SalesManagement2023.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace DMS.SalesManagement2023.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SalesManagement2023EntityFrameworkCoreModule),
    typeof(SalesManagement2023ApplicationContractsModule)
    )]
public class SalesManagement2023DbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
