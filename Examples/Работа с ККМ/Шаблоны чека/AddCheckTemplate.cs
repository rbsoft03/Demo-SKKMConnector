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
                PaymentType = 1,
                TaxVariant = 0,
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
            SignMethodCalculation = 4,
            SignCalculationObject = 33
        });
        await kkm.AddCheckTemplate();
        return kkm;
    }
}
