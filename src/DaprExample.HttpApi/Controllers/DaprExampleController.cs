using DaprExample.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DaprExample.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DaprExampleController : AbpControllerBase
{
    protected DaprExampleController()
    {
        LocalizationResource = typeof(DaprExampleResource);
    }
}
