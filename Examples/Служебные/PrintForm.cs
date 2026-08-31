using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class PrintForm : Sample
{
    public const string GroupPath = "Служебные";
    public const string Title = "Печатная форма чека";
    public const int SortOrder = 3;
    public const bool NeedDocumentId = true;

    public async Task<ServerKkm> GetPrintForm()
    {
        kkm.DeviceName = deviceName;
        kkm.DocumentId = documentId;
        await kkm.GetPrintForm();
        return kkm;
    }
}
