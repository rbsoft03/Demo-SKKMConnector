using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class PrintCheckCorrection : Sample
{
    public const string GroupPath = "Работа с ККМ|Корректировочные чеки|Корректировки ФФД 1.2";
    public const string Title = "Коррекция прихода 1.2";

    public async Task<ServerKkm> PostPrintCheckCorrection()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.CorrectionSale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.CorrectionData = new CorrectionData
        {
            Type = CorrectionTypes.Самостоятельно,
            Description = "Коррекция расчёта",
            Date = DateTime.Today
        };
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар по коррекции",
            Quantity = 1,
            Price = 100,
            Sum = 100,
            Tax = "20"
        });
        kkm.Payments = new Payments { Cash = 100 };
        await kkm.PrintCheckCorrection120();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
