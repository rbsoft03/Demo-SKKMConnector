using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CommissionAgent : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Комиссионер";

    public async Task<ServerKkm> PostCommissionAgent()
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
            AgentSign = AgentType.Commissioner,
        });
        kkm.Payments = new Payments
        {
            Cash = 60.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
