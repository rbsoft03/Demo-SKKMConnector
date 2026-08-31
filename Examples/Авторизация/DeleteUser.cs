using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class DeleteUser : Sample
{
    public const string GroupPath = "Авторизация";
    public const string Title = "Удаление пользователя";
    public const int SortOrder = 3;

    public async Task<ServerKkm> DeleteDeleteUser()
    {
        kkm.UserId = "83f43a79-027c-449e-ab97-c3f2a4b6e81c";
        await kkm.DeleteUser();
        return kkm;
    }
}
