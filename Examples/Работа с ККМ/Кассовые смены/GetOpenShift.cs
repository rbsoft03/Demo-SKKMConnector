using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetOpenShift : Sample
{
    public const string GroupPath = "Работа с ККМ|Кассовые смены";
    public const string Title = "Результат открытия смены";
    public const bool NeedDocumentId = true;
    public const int SortOrder = 1;

    public async Task<ServerKkm> GetOpenShiftById()
    {
        kkm.DeviceName = deviceName;
        kkm.DocumentId = documentId;
        await kkm.GetOpenShift();

        return kkm;
    }
}
