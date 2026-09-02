using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetOperationLast : Sample
{
    public const string GroupPath = "Работа с ККМ|Операции";
    public const string Title = "Последняя операция";
    public const int SortOrder = 0;

    public async Task<ServerKkm> GetGetOperationLast()
    {
        kkm.PaymentType = CheckType.Sale;
        kkm.IsProcessed = true;
        await kkm.GetOperationLast();
        return kkm;
    }
}
