using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample37 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Все значения мер количества";

    public async Task<ServerKkm> PostCheckSample37()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Вода 1л.",
            Quantity = 1m,
            Price = 10m,
            Sum = 10.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Сахар 500г.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "10",
            MeasureOfQuantity = MeasureOfQuantity.Gram,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Мука 0.5кг.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "11",
            MeasureOfQuantity = MeasureOfQuantity.Kilogram,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Песок 0.5т.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "12",
            MeasureOfQuantity = MeasureOfQuantity.Tonne,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Ткань 0.5см.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "20",
            MeasureOfQuantity = MeasureOfQuantity.Centimeter,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Ткань 0.5дм.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "21",
            MeasureOfQuantity = MeasureOfQuantity.Decimeter,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Ткань 0.5м.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "22",
            MeasureOfQuantity = MeasureOfQuantity.Meter,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Плитка 0.5кв.см",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "30",
            MeasureOfQuantity = MeasureOfQuantity.SquareCentimeter,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Плитка 0.5кв.дм",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "31",
            MeasureOfQuantity = MeasureOfQuantity.SquareDecimeter,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Плитка 0.5кв.м",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "32",
            MeasureOfQuantity = MeasureOfQuantity.SquareMeter,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Масло 0.5мл.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "40",
            MeasureOfQuantity = MeasureOfQuantity.Milliliter,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 0.5л.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "41",
            MeasureOfQuantity = MeasureOfQuantity.Liter,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Газ 0.5м3",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "42",
            MeasureOfQuantity = MeasureOfQuantity.CubicMeter,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Электроэнергия",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "50",
            MeasureOfQuantity = MeasureOfQuantity.KilowattHour,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Тепло",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "51",
            MeasureOfQuantity = MeasureOfQuantity.Gigacalorie,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Аренда, сутки",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "70",
            MeasureOfQuantity = MeasureOfQuantity.Day,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Аренда, час",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "71",
            MeasureOfQuantity = MeasureOfQuantity.Hour,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Аренда, мин.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "72",
            MeasureOfQuantity = MeasureOfQuantity.Minute,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Аренда, сек.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "73",
            MeasureOfQuantity = MeasureOfQuantity.Second,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Файл, КБ",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "80",
            MeasureOfQuantity = MeasureOfQuantity.Kilobyte,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Файл, МБ",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "81",
            MeasureOfQuantity = MeasureOfQuantity.Megabyte,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Файл, ГБ",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "82",
            MeasureOfQuantity = MeasureOfQuantity.Gigabyte,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Файл, ТБ",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "83",
            MeasureOfQuantity = MeasureOfQuantity.Terabyte,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Прочее",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasurementUnit = "255",
            MeasureOfQuantity = MeasureOfQuantity.Other,
        });
        kkm.Payments = new Payments
        {
            Cash = 125.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
