using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample69 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Импортный маркированный подакцизный товар с таможенной декларацией";

    public async Task<ServerKkm> PostCheckSample69()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Коньяк 0.5л.",
            Quantity = 1m,
            Price = 2480m,
            Sum = 2480.0m,
            Tax = "20",
            TaxSum = 413.33m,
            SignMethodCalculation = 4,
            SignCalculationObject = 31,
            MeasureOfQuantity = 0,
            ExciseAmount = 185.4m,
            CountryOfOrigin = "276",
            CustomsDeclaration = "10009100/140923/0001122",
            Marking = new Marking
            {
                Code = "MDEwNDYwNzAxMDM1MDI0NjIxNURzPkpSak5FIWpaIR05M2RHVno=",
            },
        });
        kkm.Payments = new Payments
        {
            Cash = 2480.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
