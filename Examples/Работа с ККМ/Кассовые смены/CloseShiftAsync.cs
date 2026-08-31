using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CloseShiftAsync : Sample
{
    public const string GroupPath = "Работа с ККМ|Кассовые смены";
    public const string Title = "Асинхронное закрытие смены";
    public const int SortOrder = 5;

    public async Task<ServerKkm> PostCloseShiftAsync()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        await kkm.CloseShiftAsync();
        return kkm;
    }
}
