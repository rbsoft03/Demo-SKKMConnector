using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class SaveServiceSettings : Sample
{
    public const string GroupPath = "Администрирование|Служба";
    public const string Title = "Сохранение настроек службы";
    public const int SortOrder = 1;

    public async Task<ServerKkm> PostSaveServiceSettings()
    {
        kkm.ServiceSettings = new ServiceSettings
        {
            WcfServicePort = 4398,
            WebServicePort = 8888,
            ServiceTimeOut = "00:00:15",
            ProxyServerSettings = new ProxyConfig
            {
                IsUseProxy = false,
                IpAddress = "",
                Port = 0,
                Name = "",
                Password = ""
            },
            MaxQueueSize = 100,
            RepeatPrintingOnError = false
        };
        await kkm.SaveServiceSettings();
        return kkm;
    }
}
