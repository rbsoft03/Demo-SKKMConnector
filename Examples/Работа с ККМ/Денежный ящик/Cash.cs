using RBSoftSkkm;

namespace SkkmNugetSample.Examples;

public class Cash : Sample
{
    public const string GroupPath = "Работа с ККМ|Денежный ящик";
    public const string Title = "Остаток в ящике";
    public const int SortOrder = 1;

    public async Task<SkkmConnector> GetCash()
    {
        kkm.DeviceName = deviceName;
        await kkm.GetCash();

        return kkm;
    }
}