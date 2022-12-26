using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DMS.SalesManagement2023;

[Dependency(ReplaceServices = true)]
public class SalesManagement2023BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SalesManagement2023";
}
