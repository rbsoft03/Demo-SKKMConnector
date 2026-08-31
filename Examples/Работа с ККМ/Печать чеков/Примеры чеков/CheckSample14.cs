using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample14 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Агент";

    public async Task<ServerKkm> PostCheckSample14()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Вода 1л.",
            Quantity = 1m,
            Price = 60m,
            Sum = 60.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
            AgentSign = 6,
        });
        kkm.Payments = new Payments
        {
            Cash = 60.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
