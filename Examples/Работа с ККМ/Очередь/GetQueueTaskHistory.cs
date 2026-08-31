using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetQueueTaskHistory : Sample
{
    public const string GroupPath = "Работа с ККМ|Очередь";
    public const string Title = "История обработки задания";
    public const bool NeedDocumentId = true;

    public async Task<ServerKkm> GetGetQueueTaskHistory()
    {
        kkm.QueueTaskId = documentId;
        await kkm.GetQueueTaskHistory();
        return kkm;
    }
}
