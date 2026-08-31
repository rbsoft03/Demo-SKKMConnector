using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetReportSettlement : Sample
{
    public const string GroupPath = "Работа с ККМ|Отчеты";
    public const string Title = "Отчёт расчётов по id";
    public const bool NeedDocumentId = true;
    public const int SortOrder = 2;

    public async Task<ServerKkm> GetReportSettlementById()
    {
        kkm.DeviceName = deviceName;
        kkm.DocumentId = documentId;
        await kkm.GetReportSettlement();

        return kkm;
    }
}
