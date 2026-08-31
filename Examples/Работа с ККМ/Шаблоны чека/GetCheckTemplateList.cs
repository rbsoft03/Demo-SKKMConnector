using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetCheckTemplateList : Sample
{
    public const string GroupPath = "Работа с ККМ|Шаблоны чека";
    public const string Title = "Список шаблонов чека";

    public async Task<ServerKkm> GetGetCheckTemplateList()
    {
        await kkm.GetCheckTemplateList();
        return kkm;
    }
}
