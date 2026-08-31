using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetFiscalizationList : Sample
{
    public const string GroupPath = "Работа с ККМ|Фискализация";
    public const string Title = "Список фискализаций";
    public const int SortOrder = 3;

    public async Task<ServerKkm> GetGetFiscalizationList()
    {
        kkm.DeviceName = deviceName;
        await kkm.GetFiscalizationList();
        return kkm;
    }
}
