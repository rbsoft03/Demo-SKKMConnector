using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class DeleteTemplate : Sample
{
    public const string GroupPath = "Работа с ККМ|Нефискальные чеки|Рекламные чеки";
    public const string Title = "Удаление шаблона печати";
    public const int SortOrder = 2;

    public async Task<ServerKkm> DeleteDeleteTemplate()
    {
        kkm.TemplateName = "name1221212121220";
        await kkm.DeleteTemplate();
        return kkm;
    }
}
