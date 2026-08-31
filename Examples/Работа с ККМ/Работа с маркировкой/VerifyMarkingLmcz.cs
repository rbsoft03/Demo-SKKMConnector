using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class VerifyMarkingLmcz : Sample
{
    public const string GroupPath = "Работа с ККМ|Работа с маркировкой";
    public const string Title = "Проверка КМ через ЛМ ЧЗ";
    public const int SortOrder = 7;

    public async Task<ServerKkm> PostVerifyMarkingLmcz()
    {
        kkm.DeviceName = deviceName;
        kkm.MarkingCodes.Clear();
        kkm.MarkingCodes.Add("MDEwNDY3MDU0MDE3NjA5OTIxNSdXOVVtHTkzZEdWeg==");
        await kkm.VerifyMarkingLmcz();
        return kkm;
    }
}
