using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetFiscalSign : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков";
    public const string Title = "Фискальный признак";
    public const int SortOrder = 6;

    public async Task<ServerKkm> GetFiscalSignByDocNumber()
    {
        kkm.DeviceName = deviceName;
        kkm.CheckNumber = 1;
        await kkm.GetFiscalSign();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
