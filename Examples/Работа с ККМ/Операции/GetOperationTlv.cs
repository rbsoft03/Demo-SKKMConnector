using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetOperationTlv : Sample
{
    public const string GroupPath = "Работа с ККМ|Операции";
    public const string Title = "TLV операции";
    public const bool NeedDocumentId = true;
    public const int SortOrder = 3;

    public async Task<ServerKkm> GetGetOperationTlv()
    {
        kkm.DocumentId = documentId;
        await kkm.GetOperationTlv();
        return kkm;
    }
}
