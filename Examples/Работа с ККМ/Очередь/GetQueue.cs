using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetQueue : Sample
{
    public const string GroupPath = "Работа с ККМ|Очередь";
    public const string Title = "Состояние очереди";
    public const bool NeedDevice = false;

    public async Task<ServerKkm> GetGetQueue()
    {
        await kkm.GetQueue();
        return kkm;
    }
}
