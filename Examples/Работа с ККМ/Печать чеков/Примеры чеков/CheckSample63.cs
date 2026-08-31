using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample63 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Заполненный goodCodeData";

    public async Task<ServerKkm> PostCheckSample63()
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
            Price = 40m,
            Sum = 40.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 33,
            MeasureOfQuantity = 0,
            Marking = new Marking
            {
                Gtin = "04670540176099",
                StampType = "05",
                Stamp = "RU-ABC/1234567890123456",
                SerialNumber = "5kX9mP2vQ7nR",
                Code = "MDEwNDYwNzAxMDM1MDI0NjIxNURzPkpSak5FIWpaIR05M2RHVno=",
                Barcode = "4670540176099",
                Ean13 = "NDY3MDU0MDE3NjA5OQ==",
                Gs1m = "MDEwNDYwNzAxMDM1MDI0NjIxNURzPkpSak5FIWpaIR05M2RHVno=",
            },
        });
        kkm.Payments = new Payments
        {
            Cash = 40.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
