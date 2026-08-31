using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CashIn : Sample
{
    public const string GroupPath = "Работа с ККМ|Денежный ящик";
    public const string Title = "Внесение";
    public const int SortOrder = 2;

    public async Task<ServerKkm> PostCashIn()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.CashAmount = 1000;
        await kkm.CashIn();

        return kkm;
    }
}