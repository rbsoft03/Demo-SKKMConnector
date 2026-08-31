using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetServiceSettings : Sample
{
    public const string GroupPath = "Администрирование|Служба";
    public const string Title = "Получение настроек службы";
    public const int SortOrder = 0;

    public async Task<ServerKkm> GetGetServiceSettings()
    {
        await kkm.GetServiceSettings();
        return kkm;
    }
}
