using RBSoftSkkm;

namespace SkkmNugetSample.Examples;

public class DeletePicture : Sample
{
    public const string GroupPath = "Работа с ККМ|Нефискальные чеки|Работа с картинками";
    public const string Title = "Удаление изображения";
    public const int SortOrder = 3;

    public async Task<SkkmConnector> DeleteDeletePicture()
    {
        kkm.DeviceName = deviceName;
        kkm.PictureId = "demo.bmp";
        await kkm.DeletePicture();
        return kkm;
    }
}
