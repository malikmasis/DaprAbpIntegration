using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace DaprExample.Web;

[Dependency(ReplaceServices = true)]
public class DaprExampleBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DaprExample";
}
