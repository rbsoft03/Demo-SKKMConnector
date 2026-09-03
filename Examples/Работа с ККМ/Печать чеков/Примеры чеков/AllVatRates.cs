using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class AllVatRates : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Все ставки НДС";

    public async Task<ServerKkm> PostAllVatRates()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар без НДС",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 0%",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "0",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 5%",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "5",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 5/105",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "5/105",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 7%",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "7",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 7/107",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "7/107",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 10%",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "10",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 10/110",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "10/110",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 18%",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "18",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 18/118",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "18/118",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 20%",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "20",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 20/120",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "20/120",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 22%",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "22",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар НДС 22/122",
            Quantity = 1m,
            Price = 100m,
            Sum = 100.0m,
            Tax = "22/122",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Payments = new Payments
        {
            Cash = 1400.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
