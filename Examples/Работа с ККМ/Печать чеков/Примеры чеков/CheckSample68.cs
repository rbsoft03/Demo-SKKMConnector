using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample68 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Маркированный товар без указания типа маркировки";

    public async Task<ServerKkm> PostCheckSample68()
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
            Price = 101m,
            Sum = 101.0m,
            Tax = "0",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 33,
            MeasureOfQuantity = 0,
            Marking = new Marking
            {
                Gtin = "04670540176099",
                Code = "MDEwNDYwNzAxMDM1MDI0NjIxNURzPkpSak5FIWpaIR05M2RHVno=",
            },
        });
        kkm.Payments = new Payments
        {
            Cash = 101.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
