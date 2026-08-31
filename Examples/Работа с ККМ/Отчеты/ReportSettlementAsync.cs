using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class ReportSettlementAsync : Sample
{
    public const string GroupPath = "Работа с ККМ|Отчеты";
    public const string Title = "Асинхронный отчёт о расчётах";
    public const int SortOrder = 1;

    public async Task<ServerKkm> PostReportSettlementAsync()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        await kkm.ReportSettlementAsync();
        return kkm;
    }
}
