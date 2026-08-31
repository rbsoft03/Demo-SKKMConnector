using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetCheckTemplate : Sample
{
    public const string GroupPath = "Работа с ККМ|Шаблоны чека";
    public const string Title = "Получение шаблона чека";

    public async Task<ServerKkm> GetGetCheckTemplate()
    {
        kkm.TemplateName = "piot_test_classic_5.1";
        await kkm.GetCheckTemplate();
        return kkm;
    }
}
