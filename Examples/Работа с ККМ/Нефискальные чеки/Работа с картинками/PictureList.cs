using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class PictureList : Sample
{
    public const string GroupPath = "Работа с ККМ|Нефискальные чеки|Работа с картинками";
    public const string Title = "Список картинок";
    public const int SortOrder = 2;

    public async Task<ServerKkm> GetPictureList()
    {
        kkm.DeviceName = deviceName;
        await kkm.GetPictureList();

        return kkm;
    }
}