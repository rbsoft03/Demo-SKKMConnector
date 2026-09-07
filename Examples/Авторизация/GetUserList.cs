using RBSoftSkkm;

namespace SkkmNugetSample.Examples;

public class GetUserList : Sample
{
    public const string GroupPath = "Авторизация";
    public const string Title = "Список пользователей";
    public const int SortOrder = 1;

    public async Task<SkkmConnector> GetGetUserList()
    {
        await kkm.GetUserList();
        return kkm;
    }
}
