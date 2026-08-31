using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class LineLength : Sample
{
    public const string GroupPath = "Администрирование|ККТ";
    public const string Title = "Ширина строки";
    public const int SortOrder = 6;

    public async Task<ServerKkm> GetLineLength()
    {
        kkm.DeviceName = deviceName;
        await kkm.GetLineLength();

        return kkm;
    }
}