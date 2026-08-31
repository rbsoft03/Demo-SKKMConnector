using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetCashInList : Sample
{
    public const string GroupPath = "Работа с ККМ|Денежный ящик";
    public const string Title = "Список внесений";
    public const int SortOrder = 4;

    public async Task<ServerKkm> GetCashInListByDevice()
    {
        kkm.DeviceName = deviceName;
        await kkm.GetCashInList();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
