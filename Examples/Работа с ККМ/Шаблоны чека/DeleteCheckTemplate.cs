using RBSoftSkkm;

namespace SkkmNugetSample.Examples;

public class DeleteCheckTemplate : Sample
{
    public const string GroupPath = "Работа с ККМ|Шаблоны чека";
    public const string Title = "Удаление шаблона чека";

    public async Task<SkkmConnector> DeleteDeleteCheckTemplate()
    {
        kkm.TemplateName = "sale_template_01";
        await kkm.DeleteCheckTemplate();
        return kkm;
    }
}
