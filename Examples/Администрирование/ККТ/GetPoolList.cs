using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetPoolList : Sample
{
    public const string GroupPath = "Администрирование|ККТ";
    public const string Title = "Список пулов";
    public const int SortOrder = 12;

    public async Task<ServerKkm> GetGetPoolList()
    {
        await kkm.GetPoolList();
        return kkm;
    }
}
