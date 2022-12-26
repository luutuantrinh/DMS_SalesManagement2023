using DMS.SalesManagement2023.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DMS.SalesManagement2023.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SalesManagement2023Controller : AbpControllerBase
{
    protected SalesManagement2023Controller()
    {
        LocalizationResource = typeof(SalesManagement2023Resource);
    }
}
