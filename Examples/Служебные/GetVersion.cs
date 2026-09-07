using RBSoftSkkm;

namespace SkkmNugetSample.Examples;

public class GetVersion : Sample
{
    public const string GroupPath = "Служебные";
    public const string Title = "Текущая версия сервера";
    public const int SortOrder = 1;

    public async Task<SkkmConnector> GetGetVersion()
    {
        await kkm.GetVersion();
        return kkm;
    }
}
