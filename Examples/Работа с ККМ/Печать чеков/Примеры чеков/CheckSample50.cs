using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample50 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Товар со страной происхождения и номером таможенной декларации";

    public async Task<ServerKkm> PostCheckSample50()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар импортный",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            CountryOfOrigin = "276",
            CustomsDeclaration = "10009100/140923/0001122",
        });
        kkm.Payments = new Payments
        {
            Cash = 100.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
