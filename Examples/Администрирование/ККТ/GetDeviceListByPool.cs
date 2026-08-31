using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetDeviceListByPool : Sample
{
    public const string GroupPath = "Администрирование|ККТ";
    public const string Title = "Список ККТ по пулу";
    public const int SortOrder = 1;

    public async Task<ServerKkm> GetGetDeviceListByPool()
    {
        kkm.PoolName = "pool";
        await kkm.GetDeviceListByPool();
        return kkm;
    }
}
