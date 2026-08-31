using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample33 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Коррекция цены с округлением до копейки";

    public async Task<ServerKkm> PostCheckSample33()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Вода 1л.",
            Quantity = 1.5m,
            Price = 0.67m,
            Sum = 1.01m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Payments = new Payments
        {
            Cash = 1.01m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
