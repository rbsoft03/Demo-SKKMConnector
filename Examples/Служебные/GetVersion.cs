using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetVersion : Sample
{
    public const string GroupPath = "Служебные";
    public const string Title = "Текущая версия сервера";
    public const int SortOrder = 1;

    public async Task<ServerKkm> GetGetVersion()
    {
        await kkm.GetVersion();
        return kkm;
    }
}
