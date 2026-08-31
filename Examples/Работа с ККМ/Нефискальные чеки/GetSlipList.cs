using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetSlipList : Sample
{
    public const string GroupPath = "Работа с ККМ|Нефискальные чеки";
    public const string Title = "Список нефискальных документов";
    public const int SortOrder = 2;

    public async Task<ServerKkm> GetGetSlipList()
    {
        kkm.DeviceName = deviceName;
        await kkm.GetSlipList();
        return kkm;
    }
}
