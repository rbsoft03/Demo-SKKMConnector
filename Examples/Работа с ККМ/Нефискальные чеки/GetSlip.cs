using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetSlip : Sample
{
    public const string GroupPath = "Работа с ККМ|Нефискальные чеки";
    public const string Title = "Получение нефискального документа";
    public const bool NeedDocumentId = true;
    public const int SortOrder = 3;

    public async Task<ServerKkm> GetGetSlip()
    {
        kkm.DeviceName = deviceName;
        kkm.DocumentId = documentId;
        await kkm.GetSlip();
        return kkm;
    }
}
