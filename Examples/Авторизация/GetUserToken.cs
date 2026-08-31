using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class GetUserToken : Sample
{
    public const string GroupPath = "Авторизация";
    public const string Title = "Получение токена";
    public const int SortOrder = 0;

    public async Task<ServerKkm> GetGetUserToken()
    {
        kkm.AuthUserName = "Admin";
        kkm.AuthPassword = "Admin";
        await kkm.GetUserToken();
        return kkm;
    }
}
