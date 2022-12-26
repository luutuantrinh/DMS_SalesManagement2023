using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DMS.SalesManagement2023.Data;
using Volo.Abp.DependencyInjection;

namespace DMS.SalesManagement2023.EntityFrameworkCore;

public class EntityFrameworkCoreSalesManagement2023DbSchemaMigrator
    : ISalesManagement2023DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSalesManagement2023DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SalesManagement2023DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SalesManagement2023DbContext>()
            .Database
            .MigrateAsync();
    }
}
