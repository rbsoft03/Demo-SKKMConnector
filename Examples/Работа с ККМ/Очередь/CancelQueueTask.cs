using RBSoftSkkm;

namespace SkkmNugetSample.Examples;

public class CancelQueueTask : Sample
{
    public const string GroupPath = "Работа с ККМ|Очередь";
    public const string Title = "Удаление задания из очереди";
    public const bool NeedDocumentId = true;

    public async Task<SkkmConnector> DeleteCancelQueueTask()
    {
        kkm.QueueTaskId = documentId;
        await kkm.CancelQueueTask();
        return kkm;
    }
}
