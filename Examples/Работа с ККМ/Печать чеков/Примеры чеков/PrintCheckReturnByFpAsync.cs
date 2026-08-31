using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class PrintCheckReturnByFpAsync : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Асинхронная печать чека возврата по ФП";

    public async Task<ServerKkm> PostPrintCheckReturnByFpAsync()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 2;
        kkm.TaxVariant = 0;
        kkm.Electronically = false;
        kkm.AdditionalAttribute = "1775661887";
        kkm.Customer = new Customer
        {
            Info = "ООО 'Рога и Копыта'",
            Email = "kuznicov@mail.ru",
            Vatin = "500100732259"
        };
        kkm.Payments = new Payments
        {
            Cash = 90,
            ElectronicPayment = 0,
            AdvancePayment = 0,
            Credit = 0,
            CashProvision = 0
        };
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Бутылка с водой 1л.",
            Quantity = 1,
            Price = 73.18m,
            Sum = 73.18m,
            DiscountSum = 0,
            Department = 1,
            Tax = "20",
            TaxSum = 0,
            SignMethodCalculation = 4,
            SignCalculationObject = 4
        });
        await kkm.PrintCheckAsync();
        return kkm;
    }
}
