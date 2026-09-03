using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class AddTemplate : Sample
{
    public const string GroupPath = "Работа с ККМ|Нефискальные чеки|Рекламные чеки";
    public const string Title = "Создание шаблона печати";
    public const int SortOrder = 0;

    public async Task<ServerKkm> PostAddTemplate()
    {
        kkm.TemplateParameters = new TemplateParameters
        {
            Name = "Template32",
            Type = PrintTemplateType.CheckLines,
            TemplateItems =
            {
                new TemplateItem
                {
                    PrintLine = new PrintLine
                    {
                        Type = PrintLineType.Text,
                        Line = "Текст",
                        LineRight = "Информация",
                        Alignment = PrintAlignment.Center,
                        Font = PrintFont.H1,
                        Wrap = true
                    }
                },
                new TemplateItem
                {
                    PrintLine = new PrintLine
                    {
                        Type = PrintLineType.Text,
                        Line = "Сумма",
                        LineRight = "1 250,00",
                        Alignment = PrintAlignment.Left,
                        Font = PrintFont.Normal,
                        Wrap = false
                    }
                },
                new TemplateItem
                {
                    PrintLine = new PrintLine
                    {
                        Type = PrintLineType.Separator,
                        SeparatorLine = new SeparatorLine { LineStyle = LineStyle.Solid }
                    }
                },
                new TemplateItem
                {
                    PrintLine = new PrintLine
                    {
                        Type = PrintLineType.Barcode,
                        Alignment = PrintAlignment.Center,
                        Barcode = new PrintFormBarcode
                        {
                            Type = BarcodeType.QR,
                            Value = "https://www.rbsoft.ru/",
                            PrintText = BarcodePrintText.None,
                            Height = 30,
                            BarWidth = 6
                        }
                    }
                },
                new TemplateItem
                {
                    PrintLine = new PrintLine
                    {
                        Type = PrintLineType.Picture,
                        Alignment = PrintAlignment.Center,
                        Scale = 100,
                        Picture = new Picture
                        {
                            PictureBase64 = "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mP8z8BQDwAEhQGAhKmMIQAAAABJRU5ErkJggg==",
                            Alignment = PictureAlignment.Center,
                            Width = 200,
                            Height = 80
                        }
                    }
                }
            }
        };
        await kkm.AddTemplate();
        return kkm;
    }
}
