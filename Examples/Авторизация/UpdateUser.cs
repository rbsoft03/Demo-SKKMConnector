using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class UpdateUser : Sample
{
    public const string GroupPath = "Авторизация";
    public const string Title = "Редактирование пользователя";
    public const int SortOrder = 4;

    public async Task<ServerKkm> PutUpdateUser()
    {
        kkm.UserId = "83f43a79-027c-449e-ab97-c3f2a4b6e81c";
        kkm.ServiceUser = new ServiceUser
        {
            UserName = "artyom",
            Password = "Admin21",
            FullName = "Челпанов Артем",
            Vatin = "221431",
            Role = 1
        };
        await kkm.UpdateUser();
        return kkm;
    }
}
