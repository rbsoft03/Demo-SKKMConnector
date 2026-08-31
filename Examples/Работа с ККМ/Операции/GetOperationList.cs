using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetOperationList : Sample
{
    public const string GroupPath = "Работа с ККМ|Операции";
    public const string Title = "Список операций";
    public const int SortOrder = 6;

    public async Task<ServerKkm> GetGetOperationList()
    {
        kkm.ShiftsFrom = fromDate;
        kkm.ShiftsTo = toDate;
        await kkm.GetOperationList();
        return kkm;
    }
}
