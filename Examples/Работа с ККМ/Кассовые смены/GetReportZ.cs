using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetReportZ : Sample
{
    public const string GroupPath = "Работа с ККМ|Кассовые смены";
    public const string Title = "Результат закрытия смены";
    public const bool NeedDocumentId = true;
    public const int SortOrder = 6;

    public async Task<ServerKkm> GetGetReportZ()
    {
        kkm.DeviceName = deviceName;
        kkm.DocumentId = documentId;
        await kkm.GetReportZ();
        return kkm;
    }
}
