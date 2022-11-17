using Volo.Abp.Settings;

namespace DaprExample.Settings;

public class DaprExampleSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DaprExampleSettings.MySetting1));
    }
}
