using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class ExciseWithAmount : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Подакцизный товар с указанием суммы акциза.";

    public async Task<ServerKkm> PostExciseWithAmount()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Сигареты",
            Quantity = 1m,
            Price = 200m,
            Sum = 200.0m,
            Tax = "20",
            TaxSum = 33.33m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ExcisableGoods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            ExciseAmount = 48.5m,
        });
        kkm.Payments = new Payments
        {
            Cash = 200.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
