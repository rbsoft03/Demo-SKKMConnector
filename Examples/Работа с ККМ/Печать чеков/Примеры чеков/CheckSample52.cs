using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample52 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Позиция c указанием отдела со скидкой";

    public async Task<ServerKkm> PostCheckSample52()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Вода 1л.",
            Quantity = 2m,
            Price = 50m,
            Sum = 90m,
            DiscountSum = 10m,
            Department = 3,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Payments = new Payments
        {
            Cash = 90.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
