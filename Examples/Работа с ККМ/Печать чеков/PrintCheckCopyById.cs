using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class PrintCheckCopyById : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков";
    public const string Title = "Копия чека по идентификатору";
    public const bool NeedDocumentId = true;
    public const int SortOrder = 3;

    public async Task<ServerKkm> PostPrintCheckCopyById()
    {
        kkm.DeviceName = deviceName;
        kkm.DocumentId = documentId;
        await kkm.PrintCheckCopy();
        return kkm;
    }
}
