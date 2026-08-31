using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CashOut : Sample
{
    public const string GroupPath = "Работа с ККМ|Денежный ящик";
    public const string Title = "Выемка";
    public const int SortOrder = 6;

    public async Task<ServerKkm> PostCashOut()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.CashAmount = 500;
        await kkm.CashOut();

        return kkm;
    }
}