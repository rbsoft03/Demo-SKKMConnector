using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample19 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Дробное количество маркированного товара";

    public async Task<ServerKkm> PostCheckSample19()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.NewRequest();
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.УСН;
        kkm.Customer = new Customer
        {
            Info = "ООО 'Рога и Копыта'",
            Vatin = "500100732259",
            Email = "kuznicov@mail.ru"
        };
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Бутылка с водой 1л.",
            Quantity = 1.234m,
            Price = 750.0m,
            Sum = 750.0m,
            Department = 2,
            Tax = "20",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasurementUnit = "0",
            Marking = new Marking
            {
                Gs1m = "MDEwNDYwNzAxMDM1MDI0NjIxNURzPkpSak5FIWpaIR05M2RHVno=",
            },
            Fractional = new FractionalQuantity
            {
                Numerator = 1,
                Denominator = 208,
            },
        });
        kkm.Payments = new Payments
        {
            Cash = 750.0m,
            ElectronicPayment = 0.0m,
            AdvancePayment = 0.0m,
            Credit = 0.0m,
            CashProvision = 0.0m,
        };
        await kkm.PrintCheck();
        if (!kkm.Ok)
            throw new InvalidOperationException(kkm.ErrorDescription);

        return kkm;
    }
}
