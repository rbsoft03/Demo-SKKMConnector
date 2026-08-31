using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetTemplate : Sample
{
    public const string GroupPath = "Работа с ККМ|Нефискальные чеки|Рекламные чеки";
    public const string Title = "Получение шаблона печати";
    public const int SortOrder = 4;

    public async Task<ServerKkm> GetGetTemplate()
    {
        kkm.TemplateName = "Template32";
        await kkm.GetTemplate();
        return kkm;
    }
}
