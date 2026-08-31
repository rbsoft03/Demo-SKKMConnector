using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class ReportXAsync : Sample
{
    public const string GroupPath = "Работа с ККМ|Кассовые смены";
    public const string Title = "Асинхронное получение X-отчёта";
    public const int SortOrder = 9;

    public async Task<ServerKkm> PostReportXAsync()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        await kkm.ReportXAsync();
        return kkm;
    }
}
