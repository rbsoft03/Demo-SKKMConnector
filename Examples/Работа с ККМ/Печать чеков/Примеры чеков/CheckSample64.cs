using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample64 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Комплексный чек со всеми поддерживаемыми реквизитами";

    public async Task<ServerKkm> PostCheckSample64()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.TimeZone = 7;
        kkm.Electronically = true;
        kkm.OperationOnline = true;
        kkm.SenderEmail = "ivanov@mail.ru";
        kkm.SaleAddress = "г. Москва, ул. Ленина, д. 1";
        kkm.SaleLocation = "https://shop.ru";
        kkm.AdditionalAttribute = "fp-src";
        kkm.TextBefore = "before";
        kkm.TextAfter = "after";
        kkm.Customer = new Customer
        {
            Info = "ООО Ромашка",
            Vatin = "7701234560",
            Email = "ivanov@mail.ru",
            Phone = "+79001234567"
        };
        kkm.IndustryAttribute = new Industry
        {
            IdentifierFoiv = "030",
            DocumentDate = "21.11.2023",
            DocumentNumber = "1944",
            AttributeValue = "UUID=8f3a9d1c-7e2b-4a5f-9c8d-1e2f3a4b5c6d&Time=1746530733410",
        };
        kkm.UserAttribute = new UserAttribute
        {
            Name = "НомерЗаказа",
            Value = "42",
        };
        kkm.OperationalAttribute = new OperationalAttribute
        {
            DateTime = "19.08.2026",
            OperationId = 42,
            OperationData = "Оплата по договору",
        };
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 100m,
            PaymentMethod = 3,
            Identifiers = "RRN=1",
            AdditionalInformation = "Карта *1234",
        });
        kkm.Positions.Add(new TextLine
        {
            Text = "Комплексный чек",
            Font = "Big",
            Alignment = "center",
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Сыр",
            Quantity = 0.5m,
            Price = 200m,
            Sum = 100.0m,
            Tax = "10",
            TaxSum = 9.09m,
            SignMethodCalculation = 4,
            SignCalculationObject = 33,
            MeasurementUnit = "11",
            MeasureOfQuantity = 11,
            AgentSign = 6,
            Vendor = new Vendor
            {
                Name = "ООО Ромашка",
                Phones = new[] { "+79001234567" },
                Vatin = "7701234560",
            },
            Marking = new Marking
            {
                Code = "MDEwNDYwNzAxMDM1MDI0NjIxNURzPkpSak5FIWpaIR05M2RHVno=",
            },
            Industry = new Industry
            {
                IdentifierFoiv = "030",
                DocumentDate = "21.11.2023",
                DocumentNumber = "1944",
                AttributeValue = "UUID=8f3a9d1c-7e2b-4a5f-9c8d-1e2f3a4b5c6d&Time=1746530733410",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 80m,
            Sum = 80.0m,
            Tax = "20",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 33,
            MeasureOfQuantity = 0,
            Fractional = new FractionalQuantity
            {
                Numerator = 1,
                Denominator = 4,
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 2m,
            Price = 15m,
            Sum = 30.0m,
            Tax = "22",
            TaxSum = 5.41m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "QR",
            Barcode = "https://shop.ru",
            Alignment = "center",
        });
        kkm.Positions.Add(new PictureLine
        {
            Value = "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAQAAAC1HAwCAAAAC0lEQVR42mNk+M9QDwADhgGAWjR9awAAAABJRU5ErkJggg==",
            Alignment = 3,
        });
        kkm.Positions.Add(new SeparatorLine { LineStyle = (LineStyle)4 });
        kkm.Payments = new Payments
        {
            Cash = 50m,
            ElectronicPayment = 100m,
            AdvancePayment = 50m,
            Credit = 80m,
            CashProvision = 65m,
        };
        await kkm.PrintCheck();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
