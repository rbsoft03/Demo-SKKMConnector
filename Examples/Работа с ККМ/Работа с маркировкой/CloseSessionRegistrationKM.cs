using RBSoftSkkm;

namespace SkkmNugetSample.Examples;

public class CloseSessionRegistrationKM : Sample
{
    public const string GroupPath = "Работа с ККМ|Работа с маркировкой";
    public const string Title = "Закрыть сессию КМ";

    public async Task<SkkmConnector> PostCloseSessionRegistrationKM()
    {
        kkm.DeviceName = deviceName;
        await kkm.CloseSessionRegistrationKM();

        return kkm;
    }
}