using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class ReportX : Sample
{
    public const string GroupPath = "Работа с ККМ|Кассовые смены";
    public const string Title = "X-отчёт";
    public const int SortOrder = 8;

    public async Task<ServerKkm> PostReportX()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        await kkm.ReportX();

        return kkm;
    }
}