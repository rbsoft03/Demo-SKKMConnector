using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class UpdateTemplate : Sample
{
    public const string GroupPath = "Работа с ККМ|Нефискальные чеки|Рекламные чеки";
    public const string Title = "Редактирование шаблона печати";
    public const int SortOrder = 1;

    public async Task<ServerKkm> PutUpdateTemplate()
    {
        kkm.TemplateParameters = new TemplateParameters
        {
            Name = "name120",
            Type = 0,
            TemplateItems =
            {
                new TemplateItem
                {
                    PrintLine = new PrintLine
                    {
                        Type = 1,
                        Line = "Текс222т",
                        LineRight = "",
                        Alignment = 1,
                        Font = 5,
                        Wrap = true
                    }
                },
                new TemplateItem
                {
                    PrintLine = new PrintLine
                    {
                        Type = 1,
                        Line = "Сумма",
                        LineRight = "1 250,00",
                        Alignment = 0,
                        Font = 0,
                        Wrap = false
                    }
                },
                new TemplateItem
                {
                    PrintLine = new PrintLine
                    {
                        Type = 4,
                        SeparatorLine = new SeparatorLine { LineStyle = 0 }
                    }
                },
                new TemplateItem
                {
                    PrintLine = new PrintLine
                    {
                        Type = 2,
                        Alignment = 1,
                        Barcode = new PrintFormBarcode
                        {
                            Type = "QR",
                            Value = "https://www.rbsoft.ru/",
                            PrintText = 0,
                            Height = 30,
                            BarWidth = 6
                        }
                    }
                },
                new TemplateItem
                {
                    PrintLine = new PrintLine
                    {
                        Type = 3,
                        Alignment = 1,
                        Scale = 100,
                        Picture = new Picture
                        {
                            PictureBase64 = "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mP8z8BQDwAEhQGAhKmMIQAAAABJRU5ErkJggg==",
                            Alignment = 2,
                            Width = 200,
                            Height = 80
                        }
                    }
                }
            }
        };
        await kkm.UpdateTemplate();
        return kkm;
    }
}
