using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class VerifyMarking : Sample
{
    public const string GroupPath = "Работа с ККМ|Работа с маркировкой";
    public const string Title = "Проверка КМ (verify)";

    public async Task<ServerKkm> PostVerifyMarking()
    {
        kkm.DeviceName = deviceName;
        kkm.MarkingCodes.Clear();
        kkm.MarkingCodes.Add("0104670540176099215'W9Um93dGVz");
        await kkm.VerifyMarking();
        return kkm;
    }
}
