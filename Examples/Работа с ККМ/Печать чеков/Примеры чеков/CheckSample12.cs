using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample12 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Все ставки НДС";

    public async Task<ServerKkm> PostCheckSample12()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар без НДС",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 0%",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "0",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 5%",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "5",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 5/105",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "5/105",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 7%",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "7",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 7/107",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "7/107",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 10%",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "10",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 10/110",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "10/110",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 18%",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "18",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 18/118",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "18/118",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 20%",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "20",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 20/120",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "20/120",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 22%",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "22",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 22/122",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "22/122",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Payments = new Payments
        {
            Cash = 1400.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
