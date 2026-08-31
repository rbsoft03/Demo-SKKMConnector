using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample44 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Возврат с дополнительным реквизитом";

    public async Task<ServerKkm> PostCheckSample44()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 2;
        kkm.TaxVariant = 0;
        kkm.AdditionalAttribute = "1352614355";
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Вода 1л.",
            Quantity = 1m,
            Price = 101m,
            Sum = 101.0m,
            Tax = "0",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Payments = new Payments
        {
            Cash = 101.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
