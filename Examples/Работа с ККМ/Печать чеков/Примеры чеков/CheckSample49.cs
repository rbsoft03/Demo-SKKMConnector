using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample49 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Подакцизный товар с указанием суммы акциза.";

    public async Task<ServerKkm> PostCheckSample49()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Сигареты",
            Quantity = 1m,
            Price = 200m,
            Sum = 200.0m,
            Tax = "20",
            TaxSum = 33.33m,
            SignMethodCalculation = 4,
            SignCalculationObject = 2,
            MeasureOfQuantity = 0,
            ExciseAmount = 48.5m,
        });
        kkm.Payments = new Payments
        {
            Cash = 200.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
