using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetCheckCorrection120 : Sample
{
    public const string GroupPath = "Работа с ККМ|Корректировочные чеки|Корректировки ФФД 1.2";
    public const string Title = "Получение чека коррекции 1.2";
    public const bool NeedDocumentId = true;

    public async Task<ServerKkm> GetCheckCorrection120ById()
    {
        kkm.DeviceName = deviceName;
        kkm.DocumentId = documentId;
        await kkm.GetCorrection120();

        return kkm;
    }
}
