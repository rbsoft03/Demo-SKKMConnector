using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class PrintCheckCopy : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков";
    public const string Title = "Копия последнего чека";
    public const int SortOrder = 2;

    public async Task<ServerKkm> PostPrintCheckCopy()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        // пустой FiscalSign — копия последнего чека
        await kkm.PrintCheckCopy();

        return kkm;
    }
}