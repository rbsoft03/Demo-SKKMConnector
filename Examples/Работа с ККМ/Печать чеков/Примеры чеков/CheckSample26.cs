using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample26 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "ЕНВД";

    public async Task<ServerKkm> PostCheckSample26()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 3;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Вода 1л.",
            Quantity = 1m,
            Price = 40m,
            Sum = 40.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Payments = new Payments
        {
            Cash = 40.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
