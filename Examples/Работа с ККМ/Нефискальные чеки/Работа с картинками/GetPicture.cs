using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetPicture : Sample
{
    public const string GroupPath = "Работа с ККМ|Нефискальные чеки|Работа с картинками";
    public const string Title = "Получение изображения";
    public const int SortOrder = 1;

    public async Task<ServerKkm> GetGetPicture()
    {
        kkm.DeviceName = deviceName;
        kkm.PictureId = "demo.bmp";
        await kkm.GetPicture();
        return kkm;
    }
}
