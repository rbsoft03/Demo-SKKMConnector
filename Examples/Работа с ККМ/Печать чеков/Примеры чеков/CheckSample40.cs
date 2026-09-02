using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample40 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Все виды штрихкода";

    public async Task<ServerKkm> PostCheckSample40()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Вода 1л.",
            Quantity = 1m,
            Price = 10m,
            Sum = 10.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "шт",
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "QR",
            Barcode = "https://shop.ru/check",
            Alignment = "center",
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "EAN13",
            Barcode = "4601234567893",
            Alignment = "center",
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "EAN8",
            Barcode = "96385074",
            Alignment = "center",
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "CODE128",
            Barcode = "ABC-12345",
            Alignment = "center",
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "CODE39",
            Barcode = "CODE39-TEST",
            Alignment = "center",
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "CODE93",
            Barcode = "CODE93",
            Alignment = "center",
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "PDF417",
            Barcode = "pdf417-payload",
            Alignment = "center",
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "UPCA",
            Barcode = "012345678905",
            Alignment = "center",
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "UPCE",
            Barcode = "04252614",
            Alignment = "center",
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "ITF",
            Barcode = "1234567890",
            Alignment = "center",
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "CODABAR",
            Barcode = "A123456A",
            Alignment = "center",
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "CODE32",
            Barcode = "01234567",
            Alignment = "center",
        });
        kkm.Payments = new Payments
        {
            Cash = 10.0m,
        };
        await kkm.PrintCheck();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
