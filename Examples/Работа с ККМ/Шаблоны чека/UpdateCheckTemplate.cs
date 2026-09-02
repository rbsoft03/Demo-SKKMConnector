using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class UpdateCheckTemplate : Sample
{
    public const string GroupPath = "Работа с ККМ|Шаблоны чека";
    public const string Title = "Изменение шаблона чека";

    public async Task<ServerKkm> PutUpdateCheckTemplate()
    {
        kkm.NewRequest();
        kkm.CheckTemplateParameters = new CheckTemplateParameters
        {
            Name = "sale_template_01",
            Document = new CheckTemplateDocument
            {
                PaymentType = CheckType.Sale,
                TaxVariant = TaxSystem.ОСН,
                Payments = new Payments { Cash = 12 }
            }
        };
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар1",
            Quantity = 1,
            Price = 12,
            Sum = 12,
            Tax = "0",
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ
        });
        await kkm.UpdateCheckTemplate();
        return kkm;
    }
}
