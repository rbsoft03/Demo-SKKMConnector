using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetOperation : Sample
{
    public const string GroupPath = "Работа с ККМ|Операции";
    public const string Title = "Операция по id";
    public const bool NeedDocumentId = true;
    public const int SortOrder = 1;

    public async Task<ServerKkm> GetGetOperation()
    {
        kkm.DocumentId = documentId;
        await kkm.GetOperation();
        return kkm;
    }
}
