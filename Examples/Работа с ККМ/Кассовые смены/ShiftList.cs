using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class ShiftList : Sample
{
    public const string GroupPath = "Работа с ККМ|Кассовые смены";
    public const string Title = "Список закрытий смен";
    public const int SortOrder = 7;

    public async Task<ServerKkm> GetShiftList()
    {
        kkm.DeviceName = deviceName;
        kkm.ShiftsFrom = fromDate;
        kkm.ShiftsTo = toDate;
        await kkm.GetShiftList();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}