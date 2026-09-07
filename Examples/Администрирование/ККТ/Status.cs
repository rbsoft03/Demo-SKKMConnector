using RBSoftSkkm;

namespace SkkmNugetSample.Examples;

public class Status : Sample
{
    public const string GroupPath = "Администрирование|ККТ";
    public const string Title = "Статус ККМ";
    public const int SortOrder = 7;

    public async Task<SkkmConnector> GetStatus()
    {
        kkm.DeviceName = deviceName;
        await kkm.GetStatus();

        return kkm;
    }
}