using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample35 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Все признаки предмета расчета";

    public async Task<ServerKkm> PostCheckSample35()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = 1;
        kkm.TaxVariant = 0;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 1,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Подакцизный товар",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 2,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Работа",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 3,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Услуга",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 4,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Ставка азартной игры",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 5,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Выигрыш азартной игры",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 6,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Лотерейный билет",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 7,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Выигрыш лотереи",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 8,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Предоставление РИД",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 9,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Платёж",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 10,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Агентское вознаграждение",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 11,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Составной предмет расчёта",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 12,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Иной предмет расчёта",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 13,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Имущественное право",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 14,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Внереализационный доход",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 15,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Страховые взносы",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 16,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Торговый сбор",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 17,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Курортный сбор",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 18,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Залог",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 19,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Расход",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 20,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Взносы на ОПС ИП",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 21,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Взносы на ОПС",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 22,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Взносы на ОМС ИП",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 23,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Взносы на ОМС",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 24,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Взносы на ОСС",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 25,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Платёж казино",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 26,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Выдача денежных средств",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 27,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "АТНМ",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 30,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "АТМ",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 31,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "ТНМ",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 32,
            MeasureOfQuantity = 0,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "ТМ",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = 4,
            SignCalculationObject = 33,
            MeasureOfQuantity = 0,
        });
        kkm.Payments = new Payments
        {
            Cash = 31.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
