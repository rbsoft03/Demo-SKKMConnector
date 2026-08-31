using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class ShiftStatus : Sample
{
    public const string GroupPath = "Администрирование|ККТ";
    public const string Title = "Статус смены";
    public const int SortOrder = 8;

    public async Task<ServerKkm> GetShiftStatus()
    {
        kkm.DeviceName = deviceName;
        await kkm.GetShiftStatus();

        return kkm;
    }
}