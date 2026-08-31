using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetQueueTask : Sample
{
    public const string GroupPath = "Работа с ККМ|Очередь";
    public const string Title = "Актуальный статус задачи";
    public const bool NeedDocumentId = true;

    public async Task<ServerKkm> GetGetQueueTask()
    {
        kkm.QueueTaskId = documentId;
        await kkm.GetQueueTask();
        return kkm;
    }
}
