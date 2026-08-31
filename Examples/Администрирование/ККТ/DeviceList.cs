using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class DeviceList : Sample
{
    public const string GroupPath = "Администрирование|ККТ";
    public const string Title = "Список ККМ";
    public const int SortOrder = 0;

    public async Task<ServerKkm> GetDeviceList()
    {
        await kkm.GetDeviceList();

        return kkm;
    }
}