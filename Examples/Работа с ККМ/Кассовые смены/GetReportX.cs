using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetReportX : Sample
{
    public const string GroupPath = "Работа с ККМ|Кассовые смены";
    public const string Title = "Результат X-отчёта";
    public const bool NeedDocumentId = true;
    public const int SortOrder = 10;

    public async Task<ServerKkm> GetGetReportX()
    {
        kkm.DeviceName = deviceName;
        kkm.DocumentId = documentId;
        await kkm.GetReportX();
        return kkm;
    }
}
