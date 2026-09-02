using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample01 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Продажа (базовый чек)";

    public async Task<ServerKkm> PostCheckSample01()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ЕНВД;
        kkm.Customer = new Customer
        {
            Info = "ООО 'Рога и Копыта'",
            Vatin = "500100732259",
            Email = "kuznicov@mail.ru"
        };
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Бутылка с водой 1л.",
            Quantity = 1m,
            Price = 30m,
            Sum = 30m,
            DiscountSum = 0m,
            Department = 1,
            Tax = "20",
            TaxSum = 5m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "11",
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Payments = new Payments
        {
            Cash = 30m,
            ElectronicPayment = 0m,
            AdvancePayment = 0m,
            Credit = 0m,
            CashProvision = 0m,
        };
        await kkm.PrintCheck();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
