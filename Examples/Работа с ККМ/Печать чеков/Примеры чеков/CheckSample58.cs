using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample58 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Два одинаковых кода маркировки в двух позициях";

    public async Task<ServerKkm> PostCheckSample58()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Сыр",
            Quantity = 0.2m,
            Price = 300m,
            Sum = 60.0m,
            Tax = "10",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasurementUnit = "11",
            MeasureOfQuantity = MeasureOfQuantity.Kilogram,
            Marking = new Marking
            {
                Code = "MDEwNDYwMjIyMDAwNjU0OTIxNW9wRmNtSx05M2RHVno=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Сыр",
            Quantity = 0.15m,
            Price = 300m,
            Sum = 45.0m,
            Tax = "10",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasurementUnit = "11",
            MeasureOfQuantity = MeasureOfQuantity.Kilogram,
            Marking = new Marking
            {
                Code = "MDEwNDYwMjIyMDAwNjU0OTIxNW9wRmNtSx05M2RHVno=",
            },
        });
        kkm.Payments = new Payments
        {
            Cash = 105.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
