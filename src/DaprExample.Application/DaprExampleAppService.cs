using System;
using System.Collections.Generic;
using System.Text;
using DaprExample.Localization;
using Volo.Abp.Application.Services;

namespace DaprExample;

/* Inherit your application services from this class.
 */
public abstract class DaprExampleAppService : ApplicationService
{
    protected DaprExampleAppService()
    {
        LocalizationResource = typeof(DaprExampleResource);
    }
}
