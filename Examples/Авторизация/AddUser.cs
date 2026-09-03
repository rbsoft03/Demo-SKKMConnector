using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class AddUser : Sample
{
    public const string GroupPath = "Авторизация";
    public const string Title = "Добавление пользователя";
    public const int SortOrder = 2;

    public async Task<ServerKkm> PostAddUser()
    {
        kkm.ServiceUser = new ServiceUser
        {
            UserName = "Alex",
            FullName = "Алексей Петров",
            Password = "Admin",
            Vatin = "222222",
            Role = ServiceUserRole.Employee
        };
        await kkm.AddUser();
        return kkm;
    }
}
