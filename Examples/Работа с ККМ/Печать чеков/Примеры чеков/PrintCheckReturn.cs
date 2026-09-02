using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class PrintCheckReturn : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Печать чека возврата";

    public async Task<ServerKkm> PostPrintCheckReturn()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.SaleReturn;
        kkm.TaxVariant = TaxSystem.УСН;
        kkm.Customer = new Customer
        {
            Info = "ООО 'Рога и Копыта'",
            Email = "kuznicov@mail.ru",
            Vatin = "500100732259"
        };
        kkm.Payments = new Payments { Cash = 90 };
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Бутылка с водой 1л.",
            Quantity = 1,
            MeasurementUnit = "шт",
            Price = 60,
            Sum = 60,
            DiscountSum = 0,
            Department = 1,
            Tax = "20",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.FullPrepayment,
            SignCalculationObject = SignCalculationObject.Advance
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "SIMTEK манжета переходная D50х32",
            Quantity = 1,
            MeasurementUnit = "шт",
            Price = 21.85m,
            Sum = 21.85m,
            DiscountSum = 0,
            Department = 1,
            Tax = "none",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.FullPrepayment,
            SignCalculationObject = SignCalculationObject.Advance
        });
        await kkm.PrintCheck();
        return kkm;
    }
}
