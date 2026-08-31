using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class PrintCheckAsync : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков";
    public const string Title = "Асинхронная печать чека";
    public const int SortOrder = 1;

    public async Task<ServerKkm> PostPrintCheckAsync()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 3;
        kkm.Electronically = false;
        kkm.Customer = new Customer
        {
            Info = "ООО 'Рога и Копыта'",
            Vatin = "500100732259",
            Email = "kuznicov@mail.ru"
        };
        kkm.Payments = new Payments
        {
            Cash = 30,
            ElectronicPayment = 0,
            AdvancePayment = 0,
            Credit = 0,
            CashProvision = 0
        };
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Бутылка с водой 1л.",
            Quantity = 1,
            Price = 30,
            Sum = 30,
            DiscountSum = 0,
            Department = 1,
            Tax = "0",
            TaxSum = 0,
            SignMethodCalculation = 4,
            SignCalculationObject = 4,
            MeasurementUnit = "0"
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Бутылка с крышкой (пустая) 4л.",
            Quantity = 1,
            Price = 30,
            Sum = 30,
            DiscountSum = 0,
            Department = 1,
            Tax = "20",
            TaxSum = 5,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "11",
            MeasureOfQuantity = 0
        });
        await kkm.PrintCheckAsync();
        return kkm;
    }
}
