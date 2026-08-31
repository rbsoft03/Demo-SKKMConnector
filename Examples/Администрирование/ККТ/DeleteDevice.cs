using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class DeleteDevice : Sample
{
    public const string GroupPath = "Администрирование|ККТ";
    public const string Title = "Удаление ККТ";
    public const int SortOrder = 4;

    public async Task<ServerKkm> DeleteDeleteDevice()
    {
        kkm.DeviceName = deviceName;
        await kkm.DeleteDevice();
        return kkm;
    }
}
