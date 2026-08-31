using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetCheckCorrection105List : Sample
{
    public const string GroupPath = "Работа с ККМ|Корректировочные чеки|Корректировки ФФД 1.0.5";
    public const string Title = "Список чеков коррекции 1.0.5";

    public async Task<ServerKkm> GetCheckCorrection105ListItems()
    {
        kkm.DeviceName = deviceName;
        await kkm.GetCorrection105List();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
