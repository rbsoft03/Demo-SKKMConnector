using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class ConfirmKM : Sample
{
    public const string GroupPath = "Работа с ККМ|Работа с маркировкой";
    public const string Title = "Подтвердить КМ";

    public async Task<ServerKkm> PostConfirmKM()
    {
        kkm.DeviceName = deviceName;
        kkm.RequestKmGuid = "guid-из-проверки-КМ";
        kkm.ConfirmationType = KmConfirmationType.Included;
        await kkm.ConfirmKM();

        return kkm;
    }
}