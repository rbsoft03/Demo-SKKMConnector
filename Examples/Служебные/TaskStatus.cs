using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class TaskStatus : Sample
{
    public const string GroupPath = "Служебные";
    public const string Title = "Статус задания";
    public const int SortOrder = 2;
    public const bool NeedDocumentId = true;

    public async Task<ServerKkm> GetTaskStatus()
    {
        kkm.DeviceName = deviceName;
        kkm.DocumentId = documentId;
        await kkm.GetTaskStatus();
        return kkm;
    }
}
