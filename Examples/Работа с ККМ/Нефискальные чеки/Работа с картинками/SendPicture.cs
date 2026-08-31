using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class SendPicture : Sample
{
    public const string GroupPath = "Работа с ККМ|Нефискальные чеки|Работа с картинками";
    public const string Title = "Загрузить картинку";
    public const int SortOrder = 0;

    public async Task<ServerKkm> PostSendPicture()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.PictureName = "demo.png";
        kkm.PictureAlignment = 2;
        kkm.PictureBase64 = "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mP8z8BQDwAEhQGAhKmMIQAAAABJRU5ErkJggg==";
        await kkm.SendPicture();

        return kkm;
    }
}
