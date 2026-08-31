using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class OpenShift : Sample
{
    public const string GroupPath = "Работа с ККМ|Кассовые смены";
    public const string Title = "Открыть смену";
    public const int SortOrder = 0;

    public async Task<ServerKkm> PostOpenShift()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        await kkm.OpenShift();

        return kkm;
    }
}