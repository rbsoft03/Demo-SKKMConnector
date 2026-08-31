using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class VerifyMarkingTsPiot : Sample
{
    public const string GroupPath = "Работа с ККМ|Работа с маркировкой";
    public const string Title = "Проверка КМ через ТС ПИоТ";

    public async Task<ServerKkm> PostVerifyMarkingTsPiot()
    {
        kkm.DeviceName = deviceName;
        kkm.MarkingCodes.Clear();
        kkm.MarkingCodes.Add("MDEwNDY3MDU0MDE3NjA5OTIxNSdXOVVtHTkzZEdWeg==");
        await kkm.VerifyMarkingTsPiot();
        return kkm;
    }
}
