using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample39 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Электронный чек";

    public async Task<ServerKkm> PostCheckSample39()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.TimeZone = 2;
        kkm.Electronically = true;
        kkm.OperationOnline = true;
        kkm.SenderEmail = "ivanov@mail.ru";
        kkm.SaleAddress = "г. Москва, ул. Ленина, д. 1";
        kkm.SaleLocation = "https://shop.ru";
        kkm.AdditionalAttribute = "6702704322";
        kkm.TextBefore = "Текст до товаров";
        kkm.TextAfter = "Текст после товаров";
        kkm.Customer = new Customer
        {
            Info = "Иванов И. И.",
            Vatin = "500100732259",
            Email = "ivanov@mail.ru",
            Phone = "+79001234567",
            DateOfBirth = "01.01.1990",
            Citizenship = "643",
            DocumentTypeCode = "21",
            DocumentData = "4509 123456",
            Address = "г. Москва, ул. Ленина, д. 1"
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
            DateTime = "03.07.2026",
            OperationId = 1,
            OperationData = "Оплата по договору",
        };
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Услуга",
            Quantity = 1m,
            Price = 250m,
            Sum = 250.0m,
            Tax = "20",
            TaxSum = 41.67m,
            SignMethodCalculation = 4,
            SignCalculationObject = 4,
            MeasureOfQuantity = 0,
        });
        kkm.Payments = new Payments
        {
            Cash = 250.0m,
        };
        await kkm.PrintCheck();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
