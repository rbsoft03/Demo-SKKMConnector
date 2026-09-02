using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample42 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Чек с нефискальными строками";

    public async Task<ServerKkm> PostCheckSample42()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.Positions.Add(new TextLine
        {
            Text = "Заголовок чека",
            Font = "H1",
            Alignment = "center",
        });
        kkm.Positions.Add(new SeparatorLine { LineStyle = (LineStyle)0 });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Вода 1л.",
            Quantity = 1m,
            Price = 50m,
            Sum = 50.0m,
            Tax = "20",
            TaxSum = 8.33m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new TextLine
        {
            Text = "Спасибо за покупку",
            Font = "Small",
            Alignment = "center",
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "QR",
            Barcode = "https://shop.ru/loyalty",
            Alignment = "center",
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "EAN13",
            Barcode = "4601234567890",
            Alignment = "left",
        });
        kkm.Positions.Add(new PictureLine
        {
            Value = "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAQAAAC1HAwCAAAAC0lEQVR42mNk+M9QDwADhgGAWjR9awAAAABJRU5ErkJggg==",
            Alignment = 2,
            Width = 1,
            Height = 1,
        });
        kkm.Positions.Add(new SeparatorLine { LineStyle = (LineStyle)1 });
        kkm.Positions.Add(new SeparatorLine { LineStyle = (LineStyle)2 });
        kkm.Positions.Add(new SeparatorLine { LineStyle = (LineStyle)3 });
        kkm.Positions.Add(new SeparatorLine { LineStyle = (LineStyle)4 });
        kkm.Positions.Add(new TextLine
        {
            Text = "https://nalog.gov.ru",
        });
        kkm.Payments = new Payments
        {
            Cash = 50.0m,
        };
        await kkm.PrintCheck();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
