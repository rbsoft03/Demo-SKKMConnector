using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample02 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Подакцизный товар";

    public async Task<ServerKkm> PostCheckSample02()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 1;
        kkm.Electronically = true;
        kkm.Customer = new Customer
        {
            Info = "ООО 'Рога и Копыта'",
            Vatin = "500100732259",
            Email = "kuznicov@mail.ru"
        };
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Бутылка с водой 1л.",
            Quantity = 1m,
            Price = 10m,
            Sum = 10m,
            Department = 0,
            Tax = "20",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 2,
            ExciseAmount = 1m,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Пиво",
            Quantity = 3m,
            Price = 10.50m,
            Sum = 31.50m,
            Department = 1,
            Tax = "20",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 2,
        });
        kkm.Payments = new Payments
        {
            Cash = 100.01m,
        };
        await kkm.PrintCheck();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
