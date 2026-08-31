using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetCheckList : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков";
    public const string Title = "Список чеков за период";
    public const int SortOrder = 5;

    public async Task<ServerKkm> GetGetCheckList()
    {
        kkm.DeviceName = deviceName;
        kkm.ShiftsFrom = fromDate;
        kkm.ShiftsTo = toDate;
        await kkm.GetCheckList();
        return kkm;
    }
}
