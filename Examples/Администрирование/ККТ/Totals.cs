using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class Totals : Sample
{
    public const string GroupPath = "Администрирование|ККТ";
    public const string Title = "Итоги смены";
    public const int SortOrder = 9;

    public async Task<ServerKkm> GetTotals()
    {
        kkm.DeviceName = deviceName;
        await kkm.GetTotals();

        return kkm;
    }
}