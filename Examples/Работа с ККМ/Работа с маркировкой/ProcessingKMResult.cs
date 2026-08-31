using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class ProcessingKMResult : Sample
{
    public const string GroupPath = "Работа с ККМ|Работа с маркировкой";
    public const string Title = "Результат ОИСМ";

    public async Task<ServerKkm> GetProcessingKMResult()
    {
        kkm.DeviceName = deviceName;
        await kkm.GetProcessingKMResult();

        return kkm;
    }
}