using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetCheckCorrection105 : Sample
{
    public const string GroupPath = "Работа с ККМ|Корректировочные чеки|Корректировки ФФД 1.0.5";
    public const string Title = "Получение чека коррекции 1.0.5";
    public const bool NeedDocumentId = true;

    public async Task<ServerKkm> GetCheckCorrection105ById()
    {
        kkm.DeviceName = deviceName;
        kkm.DocumentId = documentId;
        await kkm.GetCorrection105();

        return kkm;
    }
}
