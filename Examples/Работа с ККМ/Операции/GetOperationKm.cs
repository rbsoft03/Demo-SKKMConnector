using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetOperationKm : Sample
{
    public const string GroupPath = "Работа с ККМ|Операции";
    public const string Title = "Коды маркировки операции";
    public const bool NeedDocumentId = true;
    public const int SortOrder = 4;

    public async Task<ServerKkm> GetGetOperationKm()
    {
        kkm.DocumentId = documentId;
        await kkm.GetOperationKm();
        return kkm;
    }
}
