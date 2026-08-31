using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetReportXList : Sample
{
    public const string GroupPath = "Работа с ККМ|Кассовые смены";
    public const string Title = "Список X-отчётов";
    public const int SortOrder = 11;

    public async Task<ServerKkm> GetReportXListByPeriod()
    {
        kkm.DeviceName = deviceName;
        kkm.ShiftsFrom = fromDate;
        kkm.ShiftsTo = toDate;
        await kkm.GetReportXList();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
