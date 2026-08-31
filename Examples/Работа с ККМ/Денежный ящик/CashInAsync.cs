using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CashInAsync : Sample
{
    public const string GroupPath = "Работа с ККМ|Денежный ящик";
    public const string Title = "Асинхронное внесение наличных";
    public const int SortOrder = 3;

    public async Task<ServerKkm> PostCashInAsync()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.CashAmount = 1000;
        await kkm.CashInAsync();
        return kkm;
    }
}
