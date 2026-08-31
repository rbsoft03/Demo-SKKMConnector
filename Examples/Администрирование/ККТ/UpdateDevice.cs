using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class UpdateDevice : Sample
{
    public const string GroupPath = "Администрирование|ККТ";
    public const string Title = "Редактирование ККТ";
    public const int SortOrder = 5;

    public async Task<ServerKkm> PutUpdateDevice()
    {
        kkm.DeviceName = deviceName;
        kkm.DeviceSettings = new DeviceSettings
        {
            DeviceName = deviceName,
            DeviceType = 1,
            Available = true,
            MethodConnection = 0,
            PortNumber = 1,
            BaudRate = 9600,
            IpAddress = "192.168.0.109",
            TcpPort = 7778,
            Password = "30",
            SerialNumber = "0392790042005043",
            SenderEmail = "ivanov@mail.ru",
            Cashier = cashierName,
            CashierVatin = cashierVatin,
            Vatin = "7700000000",
            OrganizationName = "ООО 'Ромашка'",
            SaleAddress = "г.Улан-Удэ, ул.Виноградная, д11А, офис 25",
            ClientSaleLocation = "Офис",
            TimeoutConnection = 5000,
            TimeoutWaitForPrinting = 60000,
            OfdAddress = "ofd.example.ru",
            OfdPort = 7777
        };
        await kkm.UpdateDevice();
        return kkm;
    }
}
