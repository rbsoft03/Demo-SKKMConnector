using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample66 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Код маркировки передан без кодирования Base64";

    public async Task<ServerKkm> PostCheckSample66()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 101m,
            Sum = 101.0m,
            Tax = "0",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            MarkingCode = "0104670540176099215'W9Um93dGVz",
        });
        kkm.Payments = new Payments
        {
            Cash = 101.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
