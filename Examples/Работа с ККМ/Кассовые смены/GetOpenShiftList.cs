using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetOpenShiftList : Sample
{
    public const string GroupPath = "Работа с ККМ|Кассовые смены";
    public const string Title = "Список открытий смен";
    public const int SortOrder = 2;

    public async Task<ServerKkm> GetOpenShiftListByPeriod()
    {
        kkm.DeviceName = deviceName;
        kkm.ShiftsFrom = fromDate;
        kkm.ShiftsTo = toDate;
        await kkm.GetOpenShiftList();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
