using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class AddCheckTemplate : Sample
{
    public const string GroupPath = "Работа с ККМ|Шаблоны чека";
    public const string Title = "Создание шаблона чека";

    public async Task<ServerKkm> PostAddCheckTemplate()
    {
        kkm.NewRequest();
        kkm.CheckTemplateParameters = new CheckTemplateParameters
        {
            Name = "sale_template_01",
            Document = new CheckTemplateDocument
            {
                PaymentType = CheckType.Sale,
                TaxVariant = TaxSystem.ОСН,
                Payments = new Payments { Cash = 101 }
            }
        };
        kkm.Positions.Add(new FiscalLine
        {
            Name = "Товар",
            Quantity = 1,
            Price = 101,
            Sum = 101,
            Tax = "0",
            SignMethodCalculation = SignMethodCalculation.FullPayment,
            SignCalculationObject = SignCalculationObject.ТМ
        });
        await kkm.AddCheckTemplate();
        return kkm;
    }
}
