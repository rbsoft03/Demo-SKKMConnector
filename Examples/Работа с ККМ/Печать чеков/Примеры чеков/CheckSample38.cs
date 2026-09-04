using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample38 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Сведения об оплате безналичными";

    public async Task<ServerKkm> PostCheckSample38()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 60m,
            PaymentMethod = ElectronicPaymentMethod.FullPayment,
            Identifiers = "RRN=123456789012",
            AdditionalInformation = "Карта *1234",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 40m,
            PaymentMethod = ElectronicPaymentMethod.FullPayment,
            Identifiers = "RRN=987654321000",
            AdditionalInformation = "СБП",
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Вода 1л.",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Payments = new Payments
        {
            ElectronicPayment = 100m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
