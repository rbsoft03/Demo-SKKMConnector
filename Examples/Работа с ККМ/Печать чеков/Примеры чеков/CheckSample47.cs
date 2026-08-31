using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample47 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Комплексный чек со всеми поддерживаемыми реквизитами";

    public async Task<ServerKkm> PostCheckSample47()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10m,
            PaymentMethod = 0,
            Identifiers = "M=0",
            AdditionalInformation = "Способ 0",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10m,
            PaymentMethod = 1,
            Identifiers = "M=1",
            AdditionalInformation = "Способ 1",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10m,
            PaymentMethod = 2,
            Identifiers = "M=2",
            AdditionalInformation = "Способ 2",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10m,
            PaymentMethod = 3,
            Identifiers = "M=3",
            AdditionalInformation = "Способ 3",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10m,
            PaymentMethod = 4,
            Identifiers = "M=4",
            AdditionalInformation = "Способ 4",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10m,
            PaymentMethod = 5,
            Identifiers = "M=5",
            AdditionalInformation = "Способ 5",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10m,
            PaymentMethod = 6,
            Identifiers = "M=6",
            AdditionalInformation = "Способ 6",
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Вода 1л.",
            Quantity = 1m,
            Price = 70m,
            Sum = 70.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Payments = new Payments
        {
            ElectronicPayment = 70m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
