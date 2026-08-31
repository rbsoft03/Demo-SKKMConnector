using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class OpenCashdrawer : Sample
{
    public const string GroupPath = "Работа с ККМ|Денежный ящик";
    public const string Title = "Открыть ящик";
    public const int SortOrder = 0;

    public async Task<ServerKkm> PostOpenCashdrawer()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        await kkm.OpenCashdrawer();

        return kkm;
    }
}