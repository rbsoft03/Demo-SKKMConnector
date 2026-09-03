using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class UnitWithoutMeasureCode : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Единица измерения указана без кода меры количества";

    public async Task<ServerKkm> PostUnitWithoutMeasureCode()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Сыр",
            Quantity = 0.353m,
            Price = 200m,
            Sum = 70.6m,
            Tax = "10",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasurementUnit = "11",
            Marking = new Marking
            {
                Code = "MDEwNDYwMjIyMDAwNjU0OTIxNW9wRmNtSx05M2RHVno=",
            },
        });
        kkm.Payments = new Payments
        {
            Cash = 70.6m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
