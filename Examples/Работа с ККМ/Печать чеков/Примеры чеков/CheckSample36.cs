using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample36 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Все признаки способа расчета";

    public async Task<ServerKkm> PostCheckSample36()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Предоплата 100%",
            Quantity = 1m,
            Price = 10m,
            Sum = 10.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 1,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Предоплата",
            Quantity = 1m,
            Price = 10m,
            Sum = 10.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 2,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Аванс",
            Quantity = 1m,
            Price = 10m,
            Sum = 10.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 3,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Полный расчёт",
            Quantity = 1m,
            Price = 10m,
            Sum = 10.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Частичный расчёт",
            Quantity = 1m,
            Price = 10m,
            Sum = 10.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 5,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Передача в кредит",
            Quantity = 1m,
            Price = 10m,
            Sum = 10.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 6,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Оплата кредита",
            Quantity = 1m,
            Price = 10m,
            Sum = 10.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 7,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Payments = new Payments
        {
            Cash = 70.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
