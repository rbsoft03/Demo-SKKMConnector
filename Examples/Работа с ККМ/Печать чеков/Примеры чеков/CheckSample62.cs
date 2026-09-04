using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class CheckSample62 : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "128 маркированных позиций";

    public async Task<ServerKkm> PostCheckSample62()
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
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIwMDIxUzAwMDIwMB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIwMTIxUzAwMDIwMR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIwMjIxUzAwMDIwMh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIwMzIxUzAwMDIwMx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIwNDIxUzAwMDIwNB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIwNTIxUzAwMDIwNR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIwNjIxUzAwMDIwNh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIwNzIxUzAwMDIwNx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIwODIxUzAwMDIwOB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIwOTIxUzAwMDIwOR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIxMDIxUzAwMDIxMB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIxMTIxUzAwMDIxMR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIxMjIxUzAwMDIxMh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIxMzIxUzAwMDIxMx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIxNDIxUzAwMDIxNB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIxNTIxUzAwMDIxNR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIxNjIxUzAwMDIxNh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIxNzIxUzAwMDIxNx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIxODIxUzAwMDIxOB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIxOTIxUzAwMDIxOR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIyMDIxUzAwMDIyMB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIyMTIxUzAwMDIyMR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIyMjIxUzAwMDIyMh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIyMzIxUzAwMDIyMx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIyNDIxUzAwMDIyNB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIyNTIxUzAwMDIyNR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIyNjIxUzAwMDIyNh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIyNzIxUzAwMDIyNx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIyODIxUzAwMDIyOB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIyOTIxUzAwMDIyOR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIzMDIxUzAwMDIzMB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIzMTIxUzAwMDIzMR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIzMjIxUzAwMDIzMh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIzMzIxUzAwMDIzMx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIzNDIxUzAwMDIzNB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIzNTIxUzAwMDIzNR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIzNjIxUzAwMDIzNh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIzNzIxUzAwMDIzNx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIzODIxUzAwMDIzOB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDIzOTIxUzAwMDIzOR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI0MDIxUzAwMDI0MB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI0MTIxUzAwMDI0MR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI0MjIxUzAwMDI0Mh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI0MzIxUzAwMDI0Mx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI0NDIxUzAwMDI0NB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI0NTIxUzAwMDI0NR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI0NjIxUzAwMDI0Nh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI0NzIxUzAwMDI0Nx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI0ODIxUzAwMDI0OB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI0OTIxUzAwMDI0OR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI1MDIxUzAwMDI1MB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI1MTIxUzAwMDI1MR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI1MjIxUzAwMDI1Mh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI1MzIxUzAwMDI1Mx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI1NDIxUzAwMDI1NB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI1NTIxUzAwMDI1NR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI1NjIxUzAwMDI1Nh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI1NzIxUzAwMDI1Nx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI1ODIxUzAwMDI1OB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI1OTIxUzAwMDI1OR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI2MDIxUzAwMDI2MB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI2MTIxUzAwMDI2MR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI2MjIxUzAwMDI2Mh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI2MzIxUzAwMDI2Mx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI2NDIxUzAwMDI2NB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI2NTIxUzAwMDI2NR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI2NjIxUzAwMDI2Nh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI2NzIxUzAwMDI2Nx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI2ODIxUzAwMDI2OB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI2OTIxUzAwMDI2OR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI3MDIxUzAwMDI3MB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI3MTIxUzAwMDI3MR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI3MjIxUzAwMDI3Mh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI3MzIxUzAwMDI3Mx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI3NDIxUzAwMDI3NB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI3NTIxUzAwMDI3NR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI3NjIxUzAwMDI3Nh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI3NzIxUzAwMDI3Nx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI3ODIxUzAwMDI3OB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI3OTIxUzAwMDI3OR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI4MDIxUzAwMDI4MB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI4MTIxUzAwMDI4MR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI4MjIxUzAwMDI4Mh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI4MzIxUzAwMDI4Mx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI4NDIxUzAwMDI4NB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI4NTIxUzAwMDI4NR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI4NjIxUzAwMDI4Nh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI4NzIxUzAwMDI4Nx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI4ODIxUzAwMDI4OB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI4OTIxUzAwMDI4OR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI5MDIxUzAwMDI5MB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI5MTIxUzAwMDI5MR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI5MjIxUzAwMDI5Mh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI5MzIxUzAwMDI5Mx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI5NDIxUzAwMDI5NB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI5NTIxUzAwMDI5NR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI5NjIxUzAwMDI5Nh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI5NzIxUzAwMDI5Nx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI5ODIxUzAwMDI5OB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDI5OTIxUzAwMDI5OR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMwMDIxUzAwMDMwMB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMwMTIxUzAwMDMwMR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMwMjIxUzAwMDMwMh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMwMzIxUzAwMDMwMx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMwNDIxUzAwMDMwNB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMwNTIxUzAwMDMwNR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMwNjIxUzAwMDMwNh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMwNzIxUzAwMDMwNx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMwODIxUzAwMDMwOB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMwOTIxUzAwMDMwOR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMxMDIxUzAwMDMxMB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMxMTIxUzAwMDMxMR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMxMjIxUzAwMDMxMh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMxMzIxUzAwMDMxMx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMxNDIxUzAwMDMxNB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMxNTIxUzAwMDMxNR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMxNjIxUzAwMDMxNh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMxNzIxUzAwMDMxNx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMxODIxUzAwMDMxOB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMxOTIxUzAwMDMxOR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMyMDIxUzAwMDMyMB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMyMTIxUzAwMDMyMR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMyMjIxUzAwMDMyMh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMyMzIxUzAwMDMyMx05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMyNDIxUzAwMDMyNB05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMyNTIxUzAwMDMyNR05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMyNjIxUzAwMDMyNh05M1RFU1Q=",
            },
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Молоко 1л.",
            Quantity = 1m,
            Price = 1m,
            Sum = 1.0m,
            Tax = "none",
            TaxSum = 0m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Marking = new Marking
            {
                Code = "MDEwNDYwMDAwMDAwMDMyNzIxUzAwMDMyNx05M1RFU1Q=",
            },
        });
        kkm.Payments = new Payments
        {
            Cash = 128.0m,
        };
        await kkm.PrintCheck();

        return kkm;
    }
}
