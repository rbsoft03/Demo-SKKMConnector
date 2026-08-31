using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetOperationRelated : Sample
{
    public const string GroupPath = "Работа с ККМ|Операции";
    public const string Title = "Связанные операции";
    public const bool NeedDocumentId = true;
    public const int SortOrder = 5;

    public async Task<ServerKkm> GetGetOperationRelated()
    {
        kkm.DocumentId = documentId;
        await kkm.GetOperationRelated();
        return kkm;
    }
}
