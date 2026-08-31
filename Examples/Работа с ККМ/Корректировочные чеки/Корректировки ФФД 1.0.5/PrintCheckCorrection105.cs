using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class PrintCheckCorrection105 : Sample
{
    public const string GroupPath = "Работа с ККМ|Корректировочные чеки|Корректировки ФФД 1.0.5";
    public const string Title = "Печать чека коррекции 1.0.5";

    public async Task<ServerKkm> PostPrintCheckCorrection105()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = (int)CheckType.CorrectionSale;
        kkm.TaxVariant = (int)TaxSystem.ОСН;
        kkm.CorrectionData = new CorrectionData
        {
            Type = CorrectionTypes.Самостоятельно,
            Description = "Основание коррекции",
            Date = DateTime.Today
        };
        kkm.Correction105Taxes = new Correction105Taxes
        {
            SumTax20 = 16.67m
        };
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар по коррекции 1.05",
            Quantity = 1,
            Price = 100,
            Sum = 100,
            Tax = "20",
            TaxSum = 16.67m
        });
        kkm.Payments = new Payments { Cash = 100 };
        await kkm.PrintCheckCorrection105();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
