using Volo.Abp.Modularity;

namespace DMS.SalesManagement2023;

[DependsOn(
    typeof(SalesManagement2023ApplicationModule),
    typeof(SalesManagement2023DomainTestModule)
    )]
public class SalesManagement2023ApplicationTestModule : AbpModule
{

}
