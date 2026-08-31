using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CashOutAsync : Sample
{
    public const string GroupPath = "Работа с ККМ|Денежный ящик";
    public const string Title = "Асинхронная выемка наличных";
    public const int SortOrder = 7;

    public async Task<ServerKkm> PostCashOutAsync()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.CashAmount = 500;
        await kkm.CashOutAsync();
        return kkm;
    }
}
