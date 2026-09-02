using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class PrintCheckReturnAdvance : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Печать чека возврата аванса";

    public async Task<ServerKkm> PostPrintCheckReturnAdvance()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.Electronically = false;
        kkm.PaymentType = CheckType.SaleReturn;
        kkm.TaxVariant = TaxSystem.УСНД_Р;
        kkm.Customer = new Customer
        {
            Info = "ООО 'Рога и Копыта'",
            Vatin = "500100732259",
            Email = "kuznicov@mail.ru"
        };
        kkm.Payments = new Payments
        {
            AdvancePayment = 10,
            Cash = 0,
            CashProvision = 0,
            Credit = 0,
            ElectronicPayment = 0
        };
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Бутылка с водой 1л.",
            Quantity = 1,
            Price = 10,
            Sum = 10,
            DiscountSum = 0,
            Department = 2,
            Tax = "120",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.Advance,
            SignCalculationObject = SignCalculationObject.Advance
        });
        await kkm.PrintCheck();
        return kkm;
    }
}
