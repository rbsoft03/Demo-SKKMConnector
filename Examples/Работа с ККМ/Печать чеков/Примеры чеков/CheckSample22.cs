using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample22 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Данные платёжного агента и поставщика в заголовке";

    public async Task<ServerKkm> PostCheckSample22()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.AgentSign = AgentType.PaymentAgent;
        kkm.Agent = new Agent
        {
            PayingAgentOperation = "Приём платежей",
            PayingAgentPhone = new[] { "+79001234567" },
            ReceivePaymentsOperatorPhone = new[] { "+79001234567" },
        };
        kkm.Vendor = new Vendor
        {
            Name = "ООО Ромашка",
            Phones = new[] { "+79001234567" },
            Vatin = "7701234560",
        };
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Услуга",
            Quantity = 1m,
            Price = 90m,
            Sum = 90.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Service,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.PaymentAgent,
        });
        kkm.Payments = new Payments
        {
            Cash = 90.0m,
        };
        await kkm.PrintCheck();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
