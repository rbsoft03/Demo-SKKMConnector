using RBSoftSkkm;

namespace SkkmNugetSample.Examples;

public class GetCheckCorrection120List : Sample
{
    public const string GroupPath = "Работа с ККМ|Корректировочные чеки|Корректировки ФФД 1.2";
    public const string Title = "Список чеков коррекции 1.2";

    public async Task<SkkmConnector> GetCheckCorrection120ListItems()
    {
        kkm.DeviceName = deviceName;
        await kkm.GetCorrection120List();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
