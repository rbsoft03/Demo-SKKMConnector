using RBSoftSkkm;

namespace SkkmNugetSample.Examples;

public class ReportSettlement : Sample
{
    public const string GroupPath = "Работа с ККМ|Отчеты";
    public const string Title = "Отчёт расчётов";
    public const int SortOrder = 0;

    public async Task<SkkmConnector> PostReportSettlement()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        await kkm.ReportSettlement();

        return kkm;
    }
}