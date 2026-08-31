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
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Вода 1л.",
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
            Name = "Сахар 500г.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "10",
            MeasureOfQuantity = 10,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Мука 0.5кг.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "11",
            MeasureOfQuantity = 11,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Песок 0.5т.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "12",
            MeasureOfQuantity = 12,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Ткань 0.5см.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "20",
            MeasureOfQuantity = 20,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Ткань 0.5дм.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "21",
            MeasureOfQuantity = 21,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Ткань 0.5м.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "22",
            MeasureOfQuantity = 22,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Плитка 0.5кв.см",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "30",
            MeasureOfQuantity = 30,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Плитка 0.5кв.дм",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "31",
            MeasureOfQuantity = 31,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Плитка 0.5кв.м",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "32",
            MeasureOfQuantity = 32,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Масло 0.5мл.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "40",
            MeasureOfQuantity = 40,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 0.5л.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "41",
            MeasureOfQuantity = 41,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Газ 0.5м3",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "42",
            MeasureOfQuantity = 42,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Электроэнергия",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "50",
            MeasureOfQuantity = 50,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Тепло",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "51",
            MeasureOfQuantity = 51,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Аренда, сутки",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "70",
            MeasureOfQuantity = 70,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Аренда, час",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "71",
            MeasureOfQuantity = 71,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Аренда, мин.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "72",
            MeasureOfQuantity = 72,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Аренда, сек.",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "73",
            MeasureOfQuantity = 73,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Файл, КБ",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "80",
            MeasureOfQuantity = 80,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Файл, МБ",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "81",
            MeasureOfQuantity = 81,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Файл, ГБ",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "82",
            MeasureOfQuantity = 82,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Файл, ТБ",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "83",
            MeasureOfQuantity = 83,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Прочее",
            Quantity = 0.5m,
            Price = 10m,
            Sum = 5.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasurementUnit = "255",
            MeasureOfQuantity = 255,
        });
        kkm.Payments = new Payments
        {
            Cash = 125.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
