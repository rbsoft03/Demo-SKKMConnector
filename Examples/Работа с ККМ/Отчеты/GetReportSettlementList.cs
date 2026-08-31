using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetReportSettlementList : Sample
{
    public const string GroupPath = "Работа с ККМ|Отчеты";
    public const string Title = "Список отчётов расчётов";
    public const int SortOrder = 3;

    public async Task<ServerKkm> GetReportSettlementListByPeriod()
    {
        kkm.DeviceName = deviceName;
        kkm.ShiftsFrom = fromDate;
        kkm.ShiftsTo = toDate;
        await kkm.GetReportSettlementList();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
