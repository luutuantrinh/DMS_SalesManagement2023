using System.Threading.Tasks;

namespace DMS.SalesManagement2023.Data;

public interface ISalesManagement2023DbSchemaMigrator
{
    Task MigrateAsync();
}
