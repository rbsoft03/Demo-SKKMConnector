using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample13 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Данные агент и поставщика в позиции";

    public async Task<ServerKkm> PostCheckSample13()
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
            Price = 120m,
            Sum = 120.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
            AgentSign = 6,
            Agent = new Agent
            {
                PayingAgentOperation = "Приём платежей",
                PayingAgentPhone = new[] { "+79001234567" },
                ReceivePaymentsOperatorPhone = new[] { "+79001234567" },
            },
            Vendor = new Vendor
            {
                Name = "ООО Ромашка",
                Phones = new[] { "+79001234567" },
                Vatin = "7701234560",
            },
        });
        kkm.Payments = new Payments
        {
            Cash = 120.0m,
        };
        await kkm.PrintCheck();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
