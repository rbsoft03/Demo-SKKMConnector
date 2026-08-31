using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetFiscalization : Sample
{
    public const string GroupPath = "Работа с ККМ|Фискализация";
    public const string Title = "Результат фискализации";
    public const bool NeedDocumentId = true;
    public const int SortOrder = 2;

    public async Task<ServerKkm> GetGetFiscalization()
    {
        kkm.DeviceName = deviceName;
        kkm.DocumentId = documentId;
        await kkm.GetFiscalization();
        return kkm;
    }
}
