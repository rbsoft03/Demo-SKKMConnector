using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample57 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Цена ниже МРЦ";

    public async Task<ServerKkm> PostCheckSample57()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 80m,
            Sum = 80.0m,
            Tax = "20",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYyOTMwODg3NzA0NDIxRHprY1l0Mh04MDA1MDkwMDAwHTkzZEdWeg==",
            },
            Fractional = new FractionalQuantity
            {
                Numerator = 1,
                Denominator = 2,
            },
        });
        kkm.Payments = new Payments
        {
            Cash = 80.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
