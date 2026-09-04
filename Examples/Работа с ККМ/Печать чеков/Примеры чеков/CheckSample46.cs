using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample46 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Коррекция малой суммы с распределением по нескольким видам оплаты";

    public async Task<ServerKkm> PostCheckSample46()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Вода 1л.",
            Quantity = 3m,
            Price = 0.01m,
            Sum = 0.04m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Хлеб",
            Quantity = 1.7m,
            Price = 0.03m,
            Sum = 0.05m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 0.333m,
            Price = 0.3m,
            Sum = 0.1m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Сок 1л.",
            Quantity = 11m,
            Price = 0.09m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Payments = new Payments
        {
            Cash = 1.19m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
