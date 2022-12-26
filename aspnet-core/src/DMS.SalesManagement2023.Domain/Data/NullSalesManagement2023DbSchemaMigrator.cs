using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DMS.SalesManagement2023.Data;

/* This is used if database provider does't define
 * ISalesManagement2023DbSchemaMigrator implementation.
 */
public class NullSalesManagement2023DbSchemaMigrator : ISalesManagement2023DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
