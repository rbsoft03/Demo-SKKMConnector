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
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.AgentSign = 2;
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
            SignMethodCalculation = 4,
            SignCalculationObject = 4,
            MeasureOfQuantity = 0,
            AgentSign = 2,
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
