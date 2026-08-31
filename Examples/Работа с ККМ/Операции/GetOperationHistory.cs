using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetOperationHistory : Sample
{
    public const string GroupPath = "Работа с ККМ|Операции";
    public const string Title = "История операции";
    public const bool NeedDocumentId = true;
    public const int SortOrder = 2;

    public async Task<ServerKkm> GetGetOperationHistory()
    {
        kkm.DocumentId = documentId;
        await kkm.GetOperationHistory();
        return kkm;
    }
}
