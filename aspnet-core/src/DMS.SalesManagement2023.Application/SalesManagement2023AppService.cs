using System;
using System.Collections.Generic;
using System.Text;
using DMS.SalesManagement2023.Localization;
using Volo.Abp.Application.Services;

namespace DMS.SalesManagement2023;

/* Inherit your application services from this class.
 */
public abstract class SalesManagement2023AppService : ApplicationService
{
    protected SalesManagement2023AppService()
    {
        LocalizationResource = typeof(SalesManagement2023Resource);
    }
}
