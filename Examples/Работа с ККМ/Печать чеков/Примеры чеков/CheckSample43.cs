using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample43 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Нулевое количество автоматически заменяется на единицу";

    public async Task<ServerKkm> PostCheckSample43()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Вода 1л.",
            Quantity = 0m,
            Price = 100m,
            Sum = 100m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Payments = new Payments
        {
            Cash = 100.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
