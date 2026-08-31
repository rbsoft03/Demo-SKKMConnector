using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class OpenSessionRegistrationKM : Sample
{
    public const string GroupPath = "Работа с ККМ|Работа с маркировкой";
    public const string Title = "Открыть сессию КМ";

    public async Task<ServerKkm> PostOpenSessionRegistrationKM()
    {
        kkm.DeviceName = deviceName;
        await kkm.OpenSessionRegistrationKM();

        return kkm;
    }
}