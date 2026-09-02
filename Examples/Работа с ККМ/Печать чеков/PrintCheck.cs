using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class PrintCheck : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков";
    public const string Title = "Печать чека";
    public const int SortOrder = 0;

    public async Task<ServerKkm> PostPrintCheck()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Кофе американо",
            Quantity = 1,
            Price = 150,
            Sum = 150,
            Tax = "20"
        });
        kkm.Payments = new Payments { Cash = 150 };
        await kkm.PrintCheck();

        return kkm;
    }
}
