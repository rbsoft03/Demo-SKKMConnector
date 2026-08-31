using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class Ping : Sample
{
    public const string GroupPath = "Служебные";
    public const string Title = "Проверка доступности сервера";
    public const int SortOrder = 0;

    public async Task<ServerKkm> GetPing()
    {
        await kkm.Ping();
        return kkm;
    }
}
