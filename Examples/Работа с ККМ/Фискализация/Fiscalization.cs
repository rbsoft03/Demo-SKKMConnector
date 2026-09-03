using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class Fiscalization : Sample
{
    public const string GroupPath = "Работа с ККМ|Фискализация";
    public const string Title = "Фискализация кассы";
    public const int SortOrder = 0;

    public async Task<ServerKkm> PostFiscalization()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.FiscalizationParameters = new FiscalizationParameters
        {
            RnNumber = "00031415926",
            Fn = "0123123123123",
            CompanyName = "ООО 'Ромашка'",
            Vatin = "7722345678",
            SaleAddress = "г.Улан-Удэ, ул.Виноградная, д11А, офис 25",
            SaleLocation = "Офис",
            TaxationSystems = "0,1,2,4,5",
            FfdVersionKkt = "1.2",
            FfdVersionFn = "1.2",
            IsEncrypted = false,
            IsOffline = false,
            IsBsoSign = true,
            RegistrationLabelCodes = "3.1",
            ReasonCode = FiscalizationReasonCode.RequisitesChange,
            OfdName = "Тестовый ОФД",
            OfdVatin = "1234554321",
            FnsUrl = "nalog.ru",
            SenderEmail = "ivanov@mail.ru",
            IsMarking = true,
            IsExcisable = true
        };
        await kkm.Fiscalization();
        return kkm;
    }
}
