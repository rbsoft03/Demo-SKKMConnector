using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetCashOut : Sample
{
    public const string GroupPath = "Работа с ККМ|Денежный ящик";
    public const string Title = "Выемка по id";
    public const bool NeedDocumentId = true;
    public const int SortOrder = 8;

    public async Task<ServerKkm> GetCashOutById()
    {
        kkm.DeviceName = deviceName;
        kkm.DocumentId = documentId;
        await kkm.GetCashOut();

        return kkm;
    }
}
