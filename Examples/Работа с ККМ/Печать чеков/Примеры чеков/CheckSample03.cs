using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample03 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Часовая зона";

    public async Task<ServerKkm> PostCheckSample03()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.TimeZone = CheckTimeZone.MskPlus7;
        kkm.Customer = new Customer
        {
            Info = "ООО 'Рога и Копыта'",
            Vatin = "500100732259",
            Email = "kuznicov@mail.ru"
        };
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Бутылка с водой 1л.",
            Quantity = 2m,
            Price = 50m,
            Sum = 100m,
            Department = 0,
            Tax = "20",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.Advance,
            SignCalculationObject = SignCalculationObject.Advance,
            MeasurementUnit = "50",
        });
        kkm.Payments = new Payments
        {
            Cash = 50m,
            ElectronicPayment = 90.00m,
        };
        await kkm.PrintCheck();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
