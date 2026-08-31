using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample32 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Коррекция цены при количестве 0,001";

    public async Task<ServerKkm> PostCheckSample32()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Вода 1л.",
            Quantity = 0.001m,
            Price = 100m,
            Sum = 0.1m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Payments = new Payments
        {
            Cash = 0.1m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
