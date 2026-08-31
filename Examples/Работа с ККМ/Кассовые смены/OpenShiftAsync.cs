using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class OpenShiftAsync : Sample
{
    public const string GroupPath = "Работа с ККМ|Кассовые смены";
    public const string Title = "Открыть смену (async)";
    public const int SortOrder = 3;

    public async Task<ServerKkm> PostOpenShiftAsync()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        await kkm.OpenShiftAsync();
        return kkm;
    }
}
