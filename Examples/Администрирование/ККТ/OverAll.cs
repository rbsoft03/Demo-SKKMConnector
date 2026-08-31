using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class OverAll : Sample
{
    public const string GroupPath = "Администрирование|ККТ";
    public const string Title = "Общие счётчики";
    public const int SortOrder = 13;

    public async Task<ServerKkm> GetOverAll()
    {
        kkm.DeviceName = deviceName;
        await kkm.GetOverAll();

        return kkm;
    }
}