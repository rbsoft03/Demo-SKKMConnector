using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class ComprehensiveCheck : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Комплексный чек со всеми поддерживаемыми реквизитами";

    public async Task<ServerKkm> PostComprehensiveCheck()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10m,
            PaymentMethod = ElectronicPaymentMethod.FullPrepayment,
            Identifiers = "M=0",
            AdditionalInformation = "Способ 0",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10m,
            PaymentMethod = ElectronicPaymentMethod.PartialPrepayment,
            Identifiers = "M=1",
            AdditionalInformation = "Способ 1",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10m,
            PaymentMethod = ElectronicPaymentMethod.Advance,
            Identifiers = "M=2",
            AdditionalInformation = "Способ 2",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10m,
            PaymentMethod = ElectronicPaymentMethod.FullPayment,
            Identifiers = "M=3",
            AdditionalInformation = "Способ 3",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10m,
            PaymentMethod = ElectronicPaymentMethod.PartialPaymentAndCredit,
            Identifiers = "M=4",
            AdditionalInformation = "Способ 4",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10m,
            PaymentMethod = ElectronicPaymentMethod.CreditTransfer,
            Identifiers = "M=5",
            AdditionalInformation = "Способ 5",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10m,
            PaymentMethod = ElectronicPaymentMethod.CreditPayment,
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
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Payments = new Payments
        {
            ElectronicPayment = 70m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
