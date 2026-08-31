using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetCashIn : Sample
{
    public const string GroupPath = "Работа с ККМ|Денежный ящик";
    public const string Title = "Внесение по id";
    public const bool NeedDocumentId = true;
    public const int SortOrder = 5;

    public async Task<ServerKkm> GetCashInById()
    {
        kkm.DeviceName = deviceName;
        kkm.DocumentId = documentId;
        await kkm.GetCashIn();

        return kkm;
    }
}
