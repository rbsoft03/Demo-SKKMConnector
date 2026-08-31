using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetTemplateList : Sample
{
    public const string GroupPath = "Работа с ККМ|Нефискальные чеки|Рекламные чеки";
    public const string Title = "Список шаблонов печати";
    public const int SortOrder = 3;

    public async Task<ServerKkm> GetGetTemplateList()
    {
        await kkm.GetTemplateList();
        return kkm;
    }
}
