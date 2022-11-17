using DaprExample.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace DaprExample.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class DaprExamplePageModel : AbpPageModel
{
    protected DaprExamplePageModel()
    {
        LocalizationResourceType = typeof(DaprExampleResource);
    }
}
