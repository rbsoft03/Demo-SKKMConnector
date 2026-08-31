using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class SetDeviceFont : Sample
{
    public const string GroupPath = "Администрирование|ККТ";
    public const string Title = "Настройки шрифта шаблона";
    public const int SortOrder = 11;

    public async Task<ServerKkm> PostSetDeviceFont()
    {
        kkm.DeviceName = deviceName;
        kkm.DeviceSettings = new DeviceSettings
        {
            TemplateSettingH1 = "1",
            TemplateSettingH2 = "1",
            TemplateSettingH3 = "2",
            TemplateSettingH4 = "2",
            TemplateSettingH5 = "2"
        };
        await kkm.SetDeviceFont();
        return kkm;
    }
}
