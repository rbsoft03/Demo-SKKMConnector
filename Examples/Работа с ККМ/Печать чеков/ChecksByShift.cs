using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class ChecksByShift : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков";
    public const string Title = "Чеки за смену";
    public const int SortOrder = 7;

    public async Task<ServerKkm> GetChecksByShift()
    {
        kkm.DeviceName = deviceName;
        kkm.ShiftNumber = 1;
        await kkm.GetChecksByShift();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}