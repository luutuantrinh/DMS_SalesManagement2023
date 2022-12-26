using DMS.SalesManagement2023.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DMS.SalesManagement2023;

[DependsOn(
    typeof(SalesManagement2023EntityFrameworkCoreTestModule)
    )]
public class SalesManagement2023DomainTestModule : AbpModule
{

}
