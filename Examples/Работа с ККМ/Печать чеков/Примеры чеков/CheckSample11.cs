using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample11 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Все способы оплаты";

    public async Task<ServerKkm> PostCheckSample11()
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
            Price = 100m,
            Sum = 100.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Payments = new Payments
        {
            Cash = 20m,
            ElectronicPayment = 20m,
            AdvancePayment = 20m,
            Credit = 20m,
            CashProvision = 20m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
