using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample53 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Частичная оплата чека";

    public async Task<ServerKkm> PostCheckSample53()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Вода 1л.",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.PartialPaymentAndCredit,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Payments = new Payments
        {
            Cash = 40m,
            Credit = 60m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
