using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class Check : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков";
    public const string Title = "Чек по id";
    public const bool NeedDocumentId = true;
    public const int SortOrder = 4;

    public async Task<ServerKkm> GetCheck()
    {
        kkm.DeviceName = deviceName;
        kkm.DocumentId = documentId;
        await kkm.GetCheck();

        return kkm;
    }
}