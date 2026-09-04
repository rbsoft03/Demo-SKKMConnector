using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample20 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Банковский платежный субагент";

    public async Task<ServerKkm> PostCheckSample20()
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
            Price = 60m,
            Sum = 60.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.BankPaymentSubagent,
        });
        kkm.Payments = new Payments
        {
            Cash = 60.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
