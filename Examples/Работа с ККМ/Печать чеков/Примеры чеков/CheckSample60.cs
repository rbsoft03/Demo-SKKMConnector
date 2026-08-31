using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample60 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Указание кода маркировки в фискальной строке";

    public async Task<ServerKkm> PostCheckSample60()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 55m,
            Sum = 55.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 33,
            MeasureOfQuantity = 0,
            MarkingCode = "MDEwNDYwNzAxMDM1MDI0NjIxNURzPkpSak5FIWpaIR05M2RHVno=",
        });
        kkm.Payments = new Payments
        {
            Cash = 55.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
