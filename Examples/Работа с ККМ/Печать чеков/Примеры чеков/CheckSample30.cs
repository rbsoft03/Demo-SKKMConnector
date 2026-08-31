using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample30 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Позиция с акцизом, страной происхождения, таможенной декларацией и скидкой";

    public async Task<ServerKkm> PostCheckSample30()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Сигареты",
            ProductCode = "2402 20 900 0",
            Quantity = 2m,
            Price = 50m,
            Sum = 90m,
            DiscountSum = 10m,
            Department = 1,
            Tax = "20",
            TaxSum = 15m,
            SignMethodCalculation = 4,
            SignCalculationObject = 2,
            MeasureOfQuantity = 0,
            ExciseAmount = 5.5m,
            CountryOfOrigin = "643",
            CustomsDeclaration = "10009100/220211/0001122",
            AdditionalAttribute = "Доп. реквизит",
        });
        kkm.Payments = new Payments
        {
            Cash = 90.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
