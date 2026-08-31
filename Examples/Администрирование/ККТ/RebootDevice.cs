using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class RebootDevice : Sample
{
    public const string GroupPath = "Администрирование|ККТ";
    public const string Title = "Перезапуск ККТ";
    public const int SortOrder = 10;

    public async Task<ServerKkm> PostRebootDevice()
    {
        kkm.DeviceName = deviceName;
        await kkm.RebootDevice();
        return kkm;
    }
}
