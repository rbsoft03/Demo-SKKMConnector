using SkkmConnector;

namespace SkkmNugetSample.Examples;

/// <summary>
/// Комплексный чек: объекты расчёта, НДС, агент, маркировка, безнал, нефискальные строки.
/// </summary>
public class ComprehensiveCheckExtended : Sample
{
    public const string GroupPath = "Работа с ККМ|Печать чеков|Примеры чеков";
    public const string Title = "Комплексный чек со всеми поддерживаемыми реквизитами";

    public async Task<ServerKkm> PostComprehensiveCheckExtended()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = "Иванов И. И.", Vatin = "500100732259" };
        kkm.NewRequest();
        kkm.DocumentId = "a7c4e2b1-9d58-4f06-8c3a-1b2e4d6f8091";
        kkm.PaymentType = CheckType.Sale;
        kkm.TaxVariant = TaxSystem.ОСН;
        kkm.TimeZone = CheckTimeZone.MskPlus5;
        kkm.SenderEmail = "ivanov@mail.ru";
        kkm.SaleAddress = "г. Москва, ул. Ленина, д. 1";
        kkm.SaleLocation = "https://shop.ru";
        kkm.TextBefore = "Текст 1";
        kkm.TextAfter = "Текст 2";

        kkm.Customer = new Customer
        {
            Info = "ООО Ромашка",
            Vatin = "7701234560",
            Email = "ivanov@mail.ru",
            Phone = "+79001234567",
            DateOfBirth = "01.01.1990",
            Citizenship = "643",
            DocumentTypeCode = "21",
            DocumentData = "4509 123456",
            Address = "г. Москва, ул. Ленина, д. 1",
        };

        kkm.AgentSign = AgentType.Agent;
        kkm.Agent = new Agent
        {
            PayingAgentOperation = "Приём платежей",
            PayingAgentPhone = ["+79001234567"],
            ReceivePaymentsOperatorPhone = ["+79001234567"],
            MoneyTransferOperatorPhone = ["+79001234567"],
            MoneyTransferOperatorName = "ООО Рога и копыта",
            MoneyTransferOperatorAddress = "г. Москва, ул. Ленина, д. 1",
            MoneyTransferOperatorVatin = "7701234560",
        };
        kkm.Vendor = new Vendor
        {
            Name = "ООО Ромашка",
            Vatin = "7701234560",
            Phones = ["+79001234567", "+79007654321"],
        };

        kkm.UserAttribute = new UserAttribute { Name = "НомерЗаказа", Value = "42" };
        kkm.OperationalAttribute = new OperationalAttribute
        {
            DateTime = "03.09.2026",
            OperationId = 42,
            OperationData = "Оплата по договору",
        };
        kkm.IndustryAttribute = new Industry
        {
            IdentifierFoiv = "030",
            DocumentDate = "21.11.2023",
            DocumentNumber = "1944",
            AttributeValue = "UUID=8f3a9d1c-7e2b-4a5f-9c8d-1e2f3a4b5c6d&Time=1746530733410",
        };

        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10,
            PaymentMethod = ElectronicPaymentMethod.FullPrepayment,
            Identifiers = "M=0",
            AdditionalInformation = "Не определено",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10,
            PaymentMethod = ElectronicPaymentMethod.PartialPrepayment,
            Identifiers = "M=1",
            AdditionalInformation = "Банковская карта",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10,
            PaymentMethod = ElectronicPaymentMethod.Advance,
            Identifiers = "M=2",
            AdditionalInformation = "СБП",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10,
            PaymentMethod = ElectronicPaymentMethod.FullPayment,
            Identifiers = "RRN=123456789012",
            AdditionalInformation = "Карта *1234",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10,
            PaymentMethod = ElectronicPaymentMethod.PartialPaymentAndCredit,
            Identifiers = "M=4",
            AdditionalInformation = "Перевод с банка",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10,
            PaymentMethod = ElectronicPaymentMethod.CreditTransfer,
            Identifiers = "M=5",
            AdditionalInformation = "Эл. кошелёк",
        });
        kkm.ElectronicPayments.Add(new ElectronicPayment
        {
            Amount = 10,
            PaymentMethod = ElectronicPaymentMethod.CreditPayment,
            Identifiers = "M=6",
            AdditionalInformation = "Иной безнал",
        });

        kkm.Positions.Add(new TextLine
        {
            Text = "[center]Комплексный чек: объекты, НДС, агент, маркировка",
            Alignment = "center",
            Font = "Big",
        });
        kkm.Positions.Add(new SeparatorLine { LineStyle = LineStyle.Dotted });

        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар",
            Quantity = 2,
            Price = 6,
            Sum = 10.0m,
            DiscountSum = 2,
            Tax = "none",
            TaxSum = 0,
            Department = 1,
            ProductCode = "2208 20 290 0",
            AdditionalAttribute = "Доп. реквизит товара",
            SignMethodCalculation = SignMethodCalculation.FullPrepayment,
            SignCalculationObject = SignCalculationObject.Goods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            Agent = new Agent
            {
                PayingAgentOperation = "Приём платежей",
                PayingAgentPhone = ["+79001234567"],
                ReceivePaymentsOperatorPhone = ["+79001234567"],
                MoneyTransferOperatorPhone = ["+79001234567"],
                MoneyTransferOperatorName = "ООО Рога и копыта",
                MoneyTransferOperatorAddress = "г. Москва, ул. Ленина, д. 1",
                MoneyTransferOperatorVatin = "7701234560",
            },
            Vendor = new Vendor
            {
                Name = "ООО Ромашка",
                Vatin = "7701234560",
                Phones = ["+79001234567", "+79007654321"],
            },
        });

        kkm.Positions.Add(new FiscalLine
        {
            Name = "Подакцизный товар",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            DiscountSum = 0,
            Tax = "20",
            TaxSum = 1.67m,
            Department = 2,
            ProductCode = "2402 20 900 0",
            AdditionalAttribute = "Подакциз",
            ExciseAmount = 5.5m,
            CountryOfOrigin = "643",
            CustomsDeclaration = "10009100/220211/0001122",
            SignMethodCalculation = SignMethodCalculation.PartialPrepayment,
            SignCalculationObject = SignCalculationObject.ExcisableGoods,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
            Agent = new Agent
            {
                PayingAgentOperation = "Приём платежей",
                PayingAgentPhone = ["+79001234567"],
                ReceivePaymentsOperatorPhone = ["+79001234567"],
                MoneyTransferOperatorPhone = ["+79001234567"],
                MoneyTransferOperatorName = "ООО Рога и копыта",
                MoneyTransferOperatorAddress = "г. Москва, ул. Ленина, д. 1",
                MoneyTransferOperatorVatin = "7701234560",
            },
        });

        kkm.Positions.Add(new FiscalLine
        {
            Name = "Работа",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "5",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.Advance,
            SignCalculationObject = SignCalculationObject.Work,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
            Vendor = new Vendor
            {
                Name = "ООО Ромашка",
                Vatin = "7701234560",
                Phones = ["+79001234567", "+79007654321"],
            },
        });

        kkm.Positions.Add(new FiscalLine
        {
            Name = "Услуга",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "5/105",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.Service,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
            Agent = new Agent
            {
                PayingAgentOperation = "Приём платежей",
                PayingAgentPhone = ["+79001234567"],
                ReceivePaymentsOperatorPhone = ["+79001234567"],
                MoneyTransferOperatorPhone = ["+79001234567"],
                MoneyTransferOperatorName = "ООО Рога и копыта",
                MoneyTransferOperatorAddress = "г. Москва, ул. Ленина, д. 1",
                MoneyTransferOperatorVatin = "7701234560",
            },
            Vendor = new Vendor
            {
                Name = "ООО Ромашка",
                Vatin = "7701234560",
                Phones = ["+79001234567", "+79007654321"],
            },
        });

        kkm.Positions.Add(new FiscalLine
        {
            Name = "Ставка азартной игры",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "7",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.PartialPaymentAndCredit,
            SignCalculationObject = SignCalculationObject.GamblingStake,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Выигрыш азартной игры",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "7/107",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.CreditTransfer,
            SignCalculationObject = SignCalculationObject.GamblingPrize,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Лотерейный билет",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "10",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.CreditPayment,
            SignCalculationObject = SignCalculationObject.LotteryTicket,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Выигрыш лотереи",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "10/110",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.FullPrepayment,
            SignCalculationObject = SignCalculationObject.LotteryPrize,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Предоставление РИД",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "18",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.PartialPrepayment,
            SignCalculationObject = SignCalculationObject.IntellectualProperty,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Платёж",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "18/118",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.Advance,
            SignCalculationObject = SignCalculationObject.Advance,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Агентское вознаграждение",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "20",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.AgentFee,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Составной предмет расчёта",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "20/120",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.PartialPaymentAndCredit,
            SignCalculationObject = SignCalculationObject.Payout,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Иной предмет расчёта",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "22",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.CreditTransfer,
            SignCalculationObject = SignCalculationObject.Other,
            MeasureOfQuantity = MeasureOfQuantity.Other,
            MeasurementUnit = "255",
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Имущественное право",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "22/122",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.CreditPayment,
            SignCalculationObject = SignCalculationObject.PropertyRight,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Внереализационный доход",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "none",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.FullPrepayment,
            SignCalculationObject = SignCalculationObject.NonOperatingIncome,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Страховые взносы",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "0",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.PartialPrepayment,
            SignCalculationObject = SignCalculationObject.OtherPayments,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Торговый сбор",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "5",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.Advance,
            SignCalculationObject = SignCalculationObject.TradeFee,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Курортный сбор",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "5/105",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.TouristTax,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Залог",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "7",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.PartialPaymentAndCredit,
            SignCalculationObject = SignCalculationObject.Deposit,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Расход",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "7/107",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.CreditTransfer,
            SignCalculationObject = SignCalculationObject.Expense,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Взносы на ОПС ИП",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "10",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.CreditPayment,
            SignCalculationObject = SignCalculationObject.PensionContributionIp,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Взносы на ОПС",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "10/110",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.FullPrepayment,
            SignCalculationObject = SignCalculationObject.PensionContribution,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Взносы на ОМС ИП",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "18",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.PartialPrepayment,
            SignCalculationObject = SignCalculationObject.MedicalContributionIp,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Взносы на ОМС",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "18/118",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.Advance,
            SignCalculationObject = SignCalculationObject.MedicalContribution,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Взносы на ОСС",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "20",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.SocialContribution,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Платёж казино",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "20/120",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.PartialPaymentAndCredit,
            SignCalculationObject = SignCalculationObject.CasinoPayment,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Выдача денежных средств",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "22",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.CreditTransfer,
            SignCalculationObject = SignCalculationObject.CashWithdrawalByAgent,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
        });

        kkm.Positions.Add(new FiscalLine
        {
            Name = "АТНМ",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "20",
            TaxSum = 1.67m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.АТНМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
            ExciseAmount = 12.3m,
            CountryOfOrigin = "276",
            CustomsDeclaration = "10009100/140923/0001122",
            ProductCode = "2208 20 290 0",
        });

        kkm.Positions.Add(new FiscalLine
        {
            Name = "АТМ",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "20",
            TaxSum = 1.67m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.АТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
            ExciseAmount = 185.4m,
            CountryOfOrigin = "276",
            CustomsDeclaration = "10009100/140923/0001122",
            ProductCode = "2208 20 290 0",
            AdditionalAttribute = "Импорт АТМ",
            Marking = new Marking
            {
                Code = "MDEwNDYwMTkwNzAwMjgwNTIxNUR0RDJReUlCSjVrYR05MUYwMTMdOTJnajR4alVwdzlCZHVLUXZhT3pNYmFyeGhkVFRqWmp1cFR0RkFZOTl0WmhVPQ==",
                Gtin = "04601907002805",
                StampType = "05",
                SerialNumber = "DtD2QyIBJ5ka",
            },
            Industry = new Industry
            {
                IdentifierFoiv = "030",
                DocumentDate = "21.11.2023",
                DocumentNumber = "1944",
                AttributeValue = "UUID=8f3a9d1c-7e2b-4a5f-9c8d-1e2f3a4b5c6d&Time=1746530733410",
            },
        });

        kkm.Positions.Add(new FiscalLine
        {
            Name = "ТНМ",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "10",
            TaxSum = 0,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТНМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
            ProductCode = "0402 10 190 0",
        });

        kkm.Positions.Add(new FiscalLine
        {
            Name = "ТМ",
            Quantity = 1,
            Price = 10,
            Sum = 10.0m,
            Tax = "10",
            TaxSum = 0.91m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Piece,
            AgentSign = AgentType.Agent,
            MarkingCode = "MDEwNDYwNzAxMDM1MDI0NjIxNURzPkpSak5FIWpaIR05M2RHVno=",
            Fractional = new FractionalQuantity { Numerator = 1, Denominator = 4 },
            Industry = new Industry
            {
                IdentifierFoiv = "030",
                DocumentDate = "21.11.2023",
                DocumentNumber = "1944",
                AttributeValue = "UUID=8f3a9d1c-7e2b-4a5f-9c8d-1e2f3a4b5c6d&Time=1746530733410",
            },
        });

        kkm.Positions.Add(new FiscalLine
        {
            Name = "Сыр",
            Quantity = 0.5m,
            Price = 20,
            Sum = 10.0m,
            Tax = "10",
            TaxSum = 0.91m,
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ,
            MeasureOfQuantity = MeasureOfQuantity.Kilogram,
            MeasurementUnit = "11",
            AgentSign = AgentType.Agent,
            Marking = new Marking
            {
                Code = "MDEwNDYwMjIyMDAwNjU0OTIxNW9wRmNtSx05M2RHVno=",
            },
            Industry = new Industry
            {
                IdentifierFoiv = "030",
                DocumentDate = "21.11.2023",
                DocumentNumber = "1944",
                AttributeValue = "UUID=8f3a9d1c-7e2b-4a5f-9c8d-1e2f3a4b5c6d&Time=1746530733410",
            },
        });

        kkm.Positions.Add(new BarcodeLine
        {
            Type = "CODE128",
            Barcode = "ABC-12345",
            Alignment = "center",
        });
        kkm.Positions.Add(new BarcodeLine
        {
            Type = "QR",
            Barcode = "https://shop.ru",
            Alignment = "center",
        });
        kkm.Positions.Add(new PictureLine
        {
            Value = "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mNk+M9QDwADhgGAWjR9awAAAABJRU5ErkJggg==",
            Alignment = PictureAlignment.Right,
        });
        kkm.Positions.Add(new SeparatorLine { LineStyle = LineStyle.Dotted });

        kkm.Payments = new Payments
        {
            Cash = 50,
            ElectronicPayment = 70,
            AdvancePayment = 70,
            Credit = 70,
            CashProvision = 60,
        };

        await kkm.PrintCheck();
        return kkm;
    }
}
