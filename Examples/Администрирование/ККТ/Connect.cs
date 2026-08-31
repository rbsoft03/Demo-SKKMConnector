using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class Connect : Sample
{
    public const string GroupPath = "Администрирование|ККТ";
    public const string Title = "Информация о ККТ";
    public const int SortOrder = 2;

    public async Task<ServerKkm> GetConnect()
    {
        kkm.DeviceName = deviceName;
        await kkm.Connect();

        return kkm;
    }
}