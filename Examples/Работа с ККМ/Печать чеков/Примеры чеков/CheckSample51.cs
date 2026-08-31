using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample51 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "код страны происхождения товара";

    public async Task<ServerKkm> PostCheckSample51()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар импортный",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
            CountryOfOrigin = "276",
        });
        kkm.Payments = new Payments
        {
            Cash = 100.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
